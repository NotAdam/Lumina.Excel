using Lumina.Excel.Generator.Schema;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lumina.Excel.Generator;

[Generator]
public class SchemaGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var assemblyName = context.CompilationProvider.Select((provider, _) => provider.Assembly.Identity.GetDisplayName());

        var options = context.AnalyzerConfigOptionsProvider.Combine(assemblyName).Select((opts, _) =>
        {
            var (provider, assemblyName) = opts;

            provider.GlobalOptions.TryGetValue("build_property.SchemaPath", out var schemaPath);
            provider.GlobalOptions.TryGetValue("build_property.ExperimentalSchemaPath", out var experimentalSchemaPath);
            provider.GlobalOptions.TryGetValue("build_property.ColumnsPath", out var columnsPath);
            provider.GlobalOptions.TryGetValue("build_property.GamePath", out var gamePath);
            provider.GlobalOptions.TryGetValue("build_property.GeneratedNamespace", out var generatedNamespace);
            provider.GlobalOptions.TryGetValue("build_property.ReferencedNamespace", out var referencedNamespace);
            provider.GlobalOptions.TryGetValue("build_property.IndentSize", out var indentSize);
            provider.GlobalOptions.TryGetValue("build_property.UseUsings", out var useUsings);
            provider.GlobalOptions.TryGetValue("build_property.UseFileScopedNamespace", out var useFileScopedNamespace);
            provider.GlobalOptions.TryGetValue("build_property.UseThis", out var useThis);
            provider.GlobalOptions.TryGetValue("build_property.UseSchemaAttribute", out var useSchemaAttribute);
            provider.GlobalOptions.TryGetValue("build_property.Debug", out var debugFiles);

            if (schemaPath != null)
            {
                var schemaDir = new DirectoryInfo(schemaPath);
                if (!schemaDir.Exists)
                    throw new InvalidOperationException($"SchemaPath {schemaDir.FullName} does not exist");
            }

            if (experimentalSchemaPath != null)
            {
                var schemaDir = new DirectoryInfo(experimentalSchemaPath);
                if (!schemaDir.Exists)
                    throw new InvalidOperationException($"ExperimentalSchemaPath {schemaDir.FullName} does not exist");
            }

            if (columnsPath != null)
            {
                var columnsFile = new FileInfo(columnsPath);
                if (!columnsFile.Exists)
                    throw new InvalidOperationException($"ColumnsPath {columnsFile.FullName} does not exist");
            }

            if (gamePath != null)
            {
                var gameDir = new DirectoryInfo(gamePath);
                if (!gameDir.Exists)
                    throw new InvalidOperationException($"GamePath {gameDir.FullName} does not exist");
            }

            var indentString = "    ";
            if (!string.IsNullOrWhiteSpace(indentSize))
            {
                if (int.TryParse(indentSize, out var size))
                    indentString = new string(' ', size);
                else if (indentSize!.Equals("tab", StringComparison.InvariantCultureIgnoreCase))
                    indentString = "\t";
                else
                    throw new InvalidOperationException("IndentSize must be a number or 'tab'");

            }

            var useUsingsBool = false;
            if (useUsings != null)
                useUsingsBool = useUsings.Equals("true", StringComparison.InvariantCultureIgnoreCase) || useUsings == "1";

            var useFileScopedNamespaceBool = false;
            if (useFileScopedNamespace != null)
                useFileScopedNamespaceBool = useFileScopedNamespace.Equals("true", StringComparison.InvariantCultureIgnoreCase) || useFileScopedNamespace == "1";

            var useThisBool = true;
            if (useThis != null)
                useThisBool = useThis.Equals("true", StringComparison.InvariantCultureIgnoreCase) || useThis == "1";

            var useSchemaAttributeBool = true;
            if (useSchemaAttribute != null)
                useSchemaAttributeBool = useSchemaAttribute.Equals("true", StringComparison.InvariantCultureIgnoreCase) || useSchemaAttribute == "1";

            var debugFilesBool = false;
            if (debugFiles != null)
                debugFilesBool = debugFiles.Equals("true", StringComparison.InvariantCultureIgnoreCase) || debugFiles == "1";

            return new GeneratorOptions
            {
                SchemaPath = schemaPath,
                ExperimentalSchemaPath = experimentalSchemaPath,
                ColumnsPath = columnsPath,
                GamePath = gamePath,
                GeneratedNamespace = generatedNamespace,
                ReferencedNamespace = referencedNamespace ?? generatedNamespace ?? throw new InvalidOperationException("ReferencedNamespace must be set"),
                IndentString = indentString,
                UseUsings = useUsingsBool,
                UseFileScopedNamespace = useFileScopedNamespaceBool,
                UseSchemaAttribute = useSchemaAttributeBool,
                DebugFiles = debugFilesBool,
                AssemblyName = assemblyName
            };
        });

        context.RegisterSourceOutput(options, (ctx, opts) =>
        {
            if (opts.UseSchemaAttribute)
                ctx.AddSource("SheetSchemaAttribute.g.cs", SourceConstants.CreateAttributeSource("SheetSchema", false));
        });

        var fqmn = $"{SourceConstants.GeneratedNamespace}.SheetSchemaAttribute";

        var attributeMetadata = context.SyntaxProvider.ForAttributeWithMetadataName(fqmn, (node, _) => true, (ctx, _) =>
        {
            var data = ctx.Attributes.FirstOrDefault(a => a.AttributeClass?.ToDisplayString() == fqmn) ?? throw new InvalidOperationException("Attribute not found");
            if (data.ConstructorArguments[0].Value is not string schemaPath)
                throw new InvalidOperationException("Schema path must be a string literal");
            return (schemaPath, data, (INamedTypeSymbol)ctx.TargetSymbol);
        });

        context.RegisterSourceOutput(options, (ctx, opts) =>
        {
            if (string.IsNullOrEmpty(opts.GeneratedNamespace))
                return;
            GenerateSchemas(ctx, opts, false);
            if (!string.IsNullOrEmpty(opts.ExperimentalSchemaPath))
                GenerateSchemas(ctx, opts, true);
        });
        context.RegisterSourceOutput(attributeMetadata.Combine(options), GenerateSchema);
    }

    private void GenerateSchema(SourceProductionContext context, ((string, AttributeData, INamedTypeSymbol), GeneratorOptions) args)
    {
        var ((schemaPath, attribute, symbol), options) = args;

        if (!options.UseSchemaAttribute)
            return;

        Stream? resolvedSchemaFile = null;
        List<string> attemptedFilePaths = [];

        var filePath = attribute.ApplicationSyntaxReference?.SyntaxTree.FilePath;
        if (filePath != null)
        {
            var fileSchemaPath = Path.GetFullPath(Path.Combine(filePath, "..", schemaPath));
            attemptedFilePaths.Add(fileSchemaPath);
            resolvedSchemaFile = FileIO.TryOpenFile(fileSchemaPath);
        }

        if (resolvedSchemaFile == null && options.SchemaPath != null)
        {
            var fileSchemaPath = Path.GetFullPath(Path.Combine(options.SchemaPath, schemaPath));
            attemptedFilePaths.Add(fileSchemaPath);
            resolvedSchemaFile = FileIO.TryOpenFile(fileSchemaPath);
        }

        if (resolvedSchemaFile == null)
        {
            context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SchemaNotFound, attribute.ApplicationSyntaxReference?.GetSyntax().GetLocation(), string.Join(", ", attemptedFilePaths)));
            return;
        }

        using var schema = resolvedSchemaFile;
        using var reader = new StreamReader(schema);

        var deserializer = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
        var sheetName = Path.GetFileNameWithoutExtension(schemaPath);

        try
        {
            var sheet = deserializer.Deserialize<Sheet>(reader);
            sheetName = sheet.Name;

            var converter = new SchemaSourceConverter(sheet, options.ColumnDefinitions, options.AssemblyName, new(options.UseUsings), options.IndentString, options.GeneratedNamespace, options.ReferencedNamespace);
            var source = SourceConstants.CreateSchemaSource(symbol.ContainingNamespace.IsGlobalNamespace ? null : symbol.ContainingNamespace.ToString(), symbol.Name, true, options.UseFileScopedNamespace, false, converter);
            if (options.DebugFiles)
                context.Debug($"{Convert.ToBase64String(Encoding.UTF8.GetBytes(source.ToString()))}");
            context.AddSource($"{symbol.Name}.g.cs", source);
        }
        catch (Exception e)
        {
            context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SheetFailedGeneration, Location.None, DiagnosticSeverity.Error, null, null, sheetName, e.Message));
        }
    }

    private void GenerateSchemas(SourceProductionContext context, GeneratorOptions options, bool useExperimentalSchema)
    {
        var schemaPath = useExperimentalSchema ? options.ExperimentalSchemaPath : options.SchemaPath;
        var generatedNamespace = useExperimentalSchema ? $"{options.GeneratedNamespace}.Experimental" : options.GeneratedNamespace;

        if (schemaPath == null)
            throw new ArgumentException("schemaPath must be set", nameof(schemaPath));

        foreach (var file in FileIO.GetFiles(schemaPath, "*.yml"))
        {
            var schemaFile = FileIO.TryOpenFile(file);
            if (schemaFile == null)
                throw new InvalidOperationException($"Failed to open schema file {file}");

            using var schema = schemaFile;
            using var reader = new StreamReader(schema);

            var deserializer = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
            var sheetName = Path.GetFileNameWithoutExtension(schemaPath);

            try
            {
                var sheet = deserializer.Deserialize<Sheet>(reader);
                sheetName = sheet.Name;

                if (!options.ColumnDefinitions.Contains(sheet.Name))
                {
                    context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SheetNotFound, Location.None, DiagnosticSeverity.Error, null, null, sheet.Name));
                    continue;
                }

                var converter = new SchemaSourceConverter(sheet, options.ColumnDefinitions, options.AssemblyName, new(options.UseUsings), options.IndentString, generatedNamespace, null);
                var source = SourceConstants.CreateSchemaSource(generatedNamespace, sheet.Name, false, options.UseFileScopedNamespace, useExperimentalSchema, converter);
                var name = useExperimentalSchema ? $"{sheet.Name}.Experimental" : sheet.Name;
                if (options.DebugFiles)
                    context.Debug($"{name} -> {Convert.ToBase64String(Encoding.UTF8.GetBytes(source.ToString()))}");
                context.AddSource($"{name}.g.cs", source);
            }
            catch (Exception e)
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SheetFailedGeneration, Location.None, DiagnosticSeverity.Error, null, null, sheetName, e.Message));
            }
        }
    }
}

public sealed record GeneratorOptions
{
    public required string? SchemaPath { get; init; }
    public required string? ExperimentalSchemaPath { get; init; }
    public required string? ColumnsPath { get; init; }
    public required string? GamePath { get; init; }
    public required string? GeneratedNamespace { get; init; }
    public required string ReferencedNamespace { get; init; }
    public required string IndentString { get; init; }
    public required bool UseUsings { get; init; }
    public required bool UseFileScopedNamespace { get; init; }
    public required bool UseSchemaAttribute { get; init; }
    public required bool DebugFiles { get; init; }
    public required string AssemblyName { get; init; }

    private ColumnDefinitions? columnDefinitions = null;
    public ColumnDefinitions ColumnDefinitions =>
        columnDefinitions ?? ColumnDefinitions.FromInputs(GamePath, ColumnsPath ?? Path.Combine(SchemaPath, ".github", "columns.yml"));
}
