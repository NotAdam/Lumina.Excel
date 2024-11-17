using CsvHelper;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Text.ReadOnly;
using System.Dynamic;
using System.Globalization;

namespace Lumina.Excel.Updater;

internal static class ExportCsv
{
    public static void Main(string[] args)
    {
        var outputPath = args[0];
        var gamePath = args[1];
        var sheet = args[2];

        using var data = new GameData(gamePath);

        var header = data.GetFile<ExcelHeaderFile>($"exd/{sheet}.exh")!;

        var orderedColumns = header.ColumnDefinitions.Zip(Enumerable.Range(0,header.ColumnDefinitions.Length)).GroupBy(c => c.First.Offset).OrderBy(c => c.Key).SelectMany(g => g.OrderBy(c => c.First.Type)).ToArray();

        var i = 0;
        foreach (var (def, idx) in orderedColumns)
        {
            string name;
            if (def.Type >= ExcelColumnDataType.PackedBool0)
                name = $"{def.Offset}_{(byte)(def.Type - ExcelColumnDataType.PackedBool0)}";
            else
                name = $"{def.Offset}";
            Console.WriteLine($"{i++} => {name}");
        }

        var outPath = Path.Combine(outputPath, $"{sheet}.csv");
        Directory.CreateDirectory(Path.GetDirectoryName(outPath)!);
        using (var writer = new StreamWriter(outPath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            if (header.Header.Variant == ExcelVariant.Default)
                csv.WriteRecords(IterateRow(data.Excel.GetSheet<RawRow>(name: sheet), orderedColumns).ToList());
            else if (header.Header.Variant == ExcelVariant.Subrows)
                csv.WriteRecords(IterateRow(data.Excel.GetSubrowSheet<RawSubrow>(name: sheet), orderedColumns).ToList());
        }

        Console.WriteLine($"{sheet}: {header.GetColumnsHash():X8}");
    }

    private static IEnumerable<dynamic> IterateRow(ExcelSheet<RawRow> sheet, (ExcelColumnDefinition def, int idx)[] cols)
    {
        foreach (var row in sheet)
        {
            IDictionary<string, object> d = new ExpandoObject()!;
            d["RowId"] = row.RowId;
            foreach (var (def, idx) in cols)
            {
                var value = row.ReadColumn(idx);
                if (value is ReadOnlySeString v)
                    value = v.ExtractText();
                string name;
                if (def.Type >= ExcelColumnDataType.PackedBool0)
                    name = $"{def.Offset}_{(byte)(def.Type - ExcelColumnDataType.PackedBool0)}";
                else
                    name = $"{def.Offset}";
                d[name] = value;
            }
            yield return d;
        }
    }

    private static IEnumerable<dynamic> IterateRow(SubrowExcelSheet<RawSubrow> sheet, (ExcelColumnDefinition def, int idx)[] cols)
    {
        foreach (var row in sheet)
        {
            IDictionary<string, object> d = new ExpandoObject()!;
            d["RowId"] = row.RowId;
            foreach (var (def, idx) in cols)
            {
                var value = row.First().ReadColumn(idx);
                if (value is ReadOnlySeString v)
                    value = v.ExtractText();
                string name;
                if (def.Type >= ExcelColumnDataType.PackedBool0)
                    name = $"{def.Offset}_{(byte)(def.Type-ExcelColumnDataType.PackedBool0)}";
                else
                    name = $"{def.Offset}";
                d[name] = value;
            }
            yield return d;
        }
    }
}
