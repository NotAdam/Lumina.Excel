using CsvHelper;
using CsvHelper.Configuration.Attributes;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Excel.Updater.Schema;
using System.Collections.Immutable;
using System.Globalization;
using System.Runtime.InteropServices;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lumina.Excel.Updater;

internal static class ExportHashes
{
    public static void Main(string[] args)
    {
        var outputPath = args[0];
        var gamePath = args[1];
        var schemaPath = (args.Length > 2) ? args[2] : null;

        using var data = new GameData(gamePath);
        foreach (var sheet in data.Excel.SheetNames)
        {
            if (sheet.Contains('/'))
                continue;

            var header = data.GetFile<ExcelHeaderFile>($"exd/{sheet}.exh")!;
            var hash = $"{header.GetColumnsHash():X8}";
            IEnumerable<string>? schemaPaths = null;
            if (schemaPath != null)
            {
                var path = Path.Combine(schemaPath, $"{sheet}.yml");
                if (File.Exists(path))
                    schemaPaths = GetSchemaFieldPaths(path);
            }

            var orderedColumns = header.ColumnDefinitions.GroupBy(c => c.Offset).OrderBy(c => c.Key).SelectMany(g => g.OrderBy(c => c.Type)).ToArray();

            var orderedPaths = schemaPaths?.ToArray() ?? new string[orderedColumns.Length];
            Array.Resize(ref orderedPaths, orderedColumns.Length);

            var entries = orderedColumns.Zip(orderedPaths, (c, p) => new FieldEntry(c, p));

            var outPath = Path.Combine(outputPath, $"{sheet}.csv");
            Directory.CreateDirectory(Path.GetDirectoryName(outPath)!);
            using (var writer = new StreamWriter(outPath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(entries);
            }

            Console.WriteLine($"{sheet}: {hash}");
        }
    }

    private static IEnumerable<string> GenerateFieldPaths(ImmutableArray<string> scope, List<Field> fields, bool isArray = false)
    {
        foreach (var field in fields)
        {
            var fieldScope = scope;
            if (isArray)
            {
                if (field.Name != null)
                    fieldScope = fieldScope.Add($".{field.Name}");
            }
            else
                fieldScope = fieldScope.Add(field.Name ?? "Unk");
            if (field.Type == FieldType.Array)
            {
                var subfields = field.Fields ?? [new Field() { Type = FieldType.Scalar }];
                for (var i = 0; i < (field.Count ?? 1); ++i)
                {
                    foreach (var item in GenerateFieldPaths(fieldScope.Add($"[{i}]"), subfields, true))
                        yield return item;
                }
            }
            else
                yield return string.Join("", fieldScope);
        }
    }

    public static string[] GetSchemaFieldPaths(string path)
    {
        using var schema = File.OpenRead(path);
        using var reader = new StreamReader(schema);
        var sheetSchema = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build().Deserialize<Sheet>(reader);
        return GenerateFieldPaths([], sheetSchema.Fields).ToArray();
    }

    private sealed class FieldEntry(ExcelColumnDefinition definition, string? path)
    {
        [Index(0)]
        public ushort Offset { get; } = definition.Offset;

        [Index(1)]
        public ExcelColumnDataType Type { get; } = definition.Type;

        [Index(2)]
        public string? Path { get; } = path;
    }
}
