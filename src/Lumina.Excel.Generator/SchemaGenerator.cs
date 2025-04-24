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
    private const bool DebugFiles = false;

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var assemblyName = context.CompilationProvider.Select((provider, _) => provider.Assembly.Identity.GetDisplayName());

        var options = context.AnalyzerConfigOptionsProvider.Combine(assemblyName).Select((opts, _) =>
        {
            var (provider, assemblyName) = opts;

            provider.GlobalOptions.TryGetValue("build_property.SchemaPath", out var schemaPath);
            if (!provider.GlobalOptions.TryGetValue("build_property.GamePath", out var gamePath))
                throw new InvalidOperationException("GamePath must be set");
            provider.GlobalOptions.TryGetValue("build_property.GeneratedNamespace", out var generatedNamespace);
            provider.GlobalOptions.TryGetValue("build_property.ReferencedNamespace", out var referencedNamespace);
            provider.GlobalOptions.TryGetValue("build_property.IndentSize", out var indentSize);
            provider.GlobalOptions.TryGetValue("build_property.UseUsings", out var useUsings);
            provider.GlobalOptions.TryGetValue("build_property.UseFileScopedNamespace", out var useFileScopedNamespace);
            provider.GlobalOptions.TryGetValue("build_property.UseThis", out var useThis);
            provider.GlobalOptions.TryGetValue("build_property.UseSchemaAttribute", out var useSchemaAttribute);
            provider.GlobalOptions.TryGetValue("build_property.GeneratePendingFields", out var generatePendingFields);

            if (schemaPath != null)
            {
                var schemaDir = new DirectoryInfo(schemaPath);
                if (!schemaDir.Exists)
                    throw new InvalidOperationException($"SchemaPath {schemaDir.FullName} does not exist");
            }

            var gameDir = new DirectoryInfo(gamePath);
            if (!gameDir.Exists)
                throw new InvalidOperationException($"GamePath {gameDir.FullName} does not exist");

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

            var generatePendingFieldsBool = true;
            if (generatePendingFields != null)
                generatePendingFieldsBool = generatePendingFields.Equals("true", StringComparison.InvariantCultureIgnoreCase) || generatePendingFields == "1";

            return new GeneratorOptions
            {
                SchemaPath = schemaPath,
                GamePath = gamePath,
                GeneratedNamespace = generatedNamespace,
                ReferencedNamespace = referencedNamespace ?? generatedNamespace ?? throw new InvalidOperationException("ReferencedNamespace must be set"),
                IndentString = indentString,
                UseUsings = useUsingsBool,
                UseFileScopedNamespace = useFileScopedNamespaceBool,
                UseSchemaAttribute = useSchemaAttributeBool,
                GeneratePendingFields = generatePendingFieldsBool,
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

        context.RegisterSourceOutput(options, (ctx, opts) => {
            if (string.IsNullOrEmpty(opts.GeneratedNamespace))
                return;
            GenerateSchemas(ctx, opts, false, opts.GeneratedNamespace!);
            if (opts.GeneratePendingFields)
                GenerateSchemas(ctx, opts, true, $"{opts.GeneratedNamespace!}.Experimental");
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
            resolvedSchemaFile = TryOpenFile(fileSchemaPath);
        }

        if (resolvedSchemaFile == null && options.SchemaPath != null)
        {
            var fileSchemaPath = Path.GetFullPath(Path.Combine(options.SchemaPath, schemaPath));
            attemptedFilePaths.Add(fileSchemaPath);
            resolvedSchemaFile = TryOpenFile(fileSchemaPath);
        }

        if (resolvedSchemaFile == null)
        {
            context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SchemaNotFound, attribute.ApplicationSyntaxReference?.GetSyntax().GetLocation(), string.Join(", ", attemptedFilePaths)));
            return;
        }

        using var schema = resolvedSchemaFile;
        using var reader = new StreamReader(schema);

        var deserializer = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
        var sheet = deserializer.Deserialize<Sheet>(reader);

        try
        {
            var converter = new SchemaSourceConverter(sheet, options.GameData, true, options.AssemblyName, new(options.UseUsings), options.IndentString, options.GeneratedNamespace, options.ReferencedNamespace);
            var source = SourceConstants.CreateSchemaSource(symbol.ContainingNamespace.IsGlobalNamespace ? null : symbol.ContainingNamespace.ToString(), symbol.Name, true, options.UseFileScopedNamespace, false, converter);
            if (DebugFiles)
                context.Debug($"{Convert.ToBase64String(Encoding.UTF8.GetBytes(source.ToString()))}");
            context.AddSource($"{symbol.Name}.g.cs", source);
        }
        catch (Exception e)
        {
            context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SheetFailedGeneration, Location.None, DiagnosticSeverity.Error, null, null, sheet.Name, e.Message));
        }
    }

    private void GenerateSchemas(SourceProductionContext context, GeneratorOptions options, bool usePendingFields, string generatedNamespace)
    {
        if (string.IsNullOrEmpty(options.SchemaPath))
            throw new ArgumentException("SchemaPath must be set", nameof(options.SchemaPath));

        foreach (var file in GetFiles(options.SchemaPath!, "*.yml"))
        {
            var schemaFile = TryOpenFile(file);
            if (schemaFile == null)
                throw new InvalidOperationException($"Failed to open schema file {file}");

            using var schema = schemaFile;
            using var reader = new StreamReader(schema);

            var deserializer = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
            var sheet = deserializer.Deserialize<Sheet>(reader);

            if (options.GameData.Excel.GetSheetRaw(sheet.Name) == null)
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SheetNotFound, Location.None, DiagnosticSeverity.Error, null, null, sheet.Name));
                continue;
            }

            try
            {
                var converter = new SchemaSourceConverter(sheet, options.GameData, usePendingFields, options.AssemblyName, new(options.UseUsings), options.IndentString, generatedNamespace, null);
                var source = SourceConstants.CreateSchemaSource(generatedNamespace, sheet.Name, false, options.UseFileScopedNamespace, usePendingFields, converter);
                var name = usePendingFields ? $"{sheet.Name}Experimental" : sheet.Name;
                if (DebugFiles)
                    context.Debug($"{name} -> {Convert.ToBase64String(Encoding.UTF8.GetBytes(source.ToString()))}");
                context.AddSource($"{name}.g.cs", source);
            }
            catch (Exception e)
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SheetFailedGeneration, Location.None, DiagnosticSeverity.Error, null, null, sheet.Name, e.Message));
            }
        }
    }

    private static Stream? TryOpenFile(string path)
    {
        try
        {
            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        }
        catch (Exception)
        {
            return null;
        }
    }

    private static string[] GetFiles(string folder, string pattern)
    {
        var type = Type.GetType("System.IO.Directory");
        var getFiles = type.GetMethod("GetFiles", [typeof(string), typeof(string)]);
        return (string[])getFiles.Invoke(null, [folder, pattern]);
    }
}

public sealed record GeneratorOptions
{
    public required string? SchemaPath { get; init; }
    public required string GamePath { get; init; }
    public required string? GeneratedNamespace { get; init; }
    public required string ReferencedNamespace { get; init; }
    public required string IndentString { get; init; }
    public required bool UseUsings { get; init; }
    public required bool UseFileScopedNamespace { get; init; }
    public required bool UseSchemaAttribute { get; init; }
    public required bool GeneratePendingFields { get; init; }
    public required string AssemblyName { get; init; }

    private GameData? gameData = null;
    public GameData GameData =>
        gameData ??= new GameData(GamePath, new() { LoadMultithreaded = true });
}
