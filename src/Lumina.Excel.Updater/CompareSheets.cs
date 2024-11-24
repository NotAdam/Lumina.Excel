using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using MinHashSharp;
using System.Text.RegularExpressions;

namespace Lumina.Excel.Updater;

internal static class CompareSheets
{
    public static void Main(string[] args)
    {
        var gamePathOld = args[0];
        var gamePathNew = args[1];
        var schemaPath = (args.Length > 2) ? args[2] : null;
        var sheetNameFilter = (args.Length > 3) ? args[3] : null;
        var forceNewColumnsString = (args.Length > 4) ? args[4] : null;

        HashSet<int> forceNewColumns = [];
        if (forceNewColumnsString != null)
        {
            foreach (var s in forceNewColumnsString.Split(','))
                forceNewColumns.Add(int.Parse(s));
        }

        using var dataOld = new GameData(gamePathOld);
        using var dataNew = new GameData(gamePathNew);

        var sheetsOld = dataOld.Excel.SheetNames.Where((string s) => !s.Contains('/'));
        var sheetsNew = dataNew.Excel.SheetNames.Where((string s) => !s.Contains('/'));

        var addedSheets = sheetsNew.Except(sheetsOld).Order();
        var deletedSheets = sheetsOld.Except(sheetsNew).Order();

        if (addedSheets.Any())
        {
            Console.WriteLine("New sheets:");
            foreach (var sheet in addedSheets)
                Console.WriteLine($"    {sheet}");
            Console.WriteLine();
        }
        if (deletedSheets.Any())
        {
            Console.WriteLine("Deleted sheets:");
            foreach (var sheet in deletedSheets)
                Console.WriteLine($"    {sheet}");
        }

        var modifiedSheets = sheetsNew.Intersect(sheetsOld).Order();
        foreach (var sheet in modifiedSheets)
        {
            if (sheetNameFilter != null)
            {
                if (!Regex.IsMatch(sheet, sheetNameFilter, RegexOptions.IgnoreCase))
                    continue;
            }

            try
            {
                var headerOld = dataOld.GetFile<ExcelHeaderFile>($"exd/{sheet}.exh")!;
                var headerNew = dataNew.GetFile<ExcelHeaderFile>($"exd/{sheet}.exh")!;
                if (headerOld.GetColumnsHash() == headerNew.GetColumnsHash())
                    continue;

                Console.WriteLine();
                Console.WriteLine("Modified sheet: " + sheet);

                string[]? schemaPaths = null;
                if (schemaPath != null)
                {
                    var path = Path.Combine(schemaPath, $"{sheet}.yml");
                    if (File.Exists(path))
                        schemaPaths = ExportHashes.GetSchemaFieldPaths(path);
                }

                var orderedColumnsOld = headerOld.ColumnDefinitions.GroupBy(c => c.Offset).OrderBy(c => c.Key).SelectMany(g => g.OrderBy(c => c.Type)).ToArray();
                var orderedColumnsNew = headerNew.ColumnDefinitions.GroupBy(c => c.Offset).OrderBy(c => c.Key).SelectMany(g => g.OrderBy(c => c.Type)).ToArray();

                var oldHashes = Enumerable.Range(0, orderedColumnsOld.Length).Select(i => new SimilarColumn()).ToArray();
                var newHashes = Enumerable.Range(0, orderedColumnsNew.Length).Select(i => new SimilarColumn()).ToArray();

                {
                    void PopulateColumns(uint rowId, IExcelSheet sheet, ExcelColumnDefinition[] columns, SimilarColumn[] hashes)
                    {
                        switch (headerOld.Header.Variant)
                        {
                            case ExcelVariant.Default:
                                {
                                    var row = ((ExcelSheet<RawRow>)sheet).GetRow(rowId);
                                    for (var n = 0; n < columns.Length; n++)
                                        row.AppendHashCode(hashes[n], columns[n]);
                                    break;
                                }
                            case ExcelVariant.Subrows:
                                {
                                    var row = ((SubrowExcelSheet<RawSubrow>)sheet).GetRow(rowId).First();
                                    for (var m = 0; m < columns.Length; m++)
                                        row.AppendHashCode(hashes[m], columns[m]);
                                    break;
                                }
                        }
                    }

                    uint ResolveRowIdAt(int i, IExcelSheet sheet) =>
                        headerOld.Header.Variant switch
                        {
                            ExcelVariant.Default => ((ExcelSheet<RawRow>)sheet).GetRowAt(i).RowId,
                            ExcelVariant.Subrows => ((SubrowExcelSheet<RawSubrow>)sheet).GetRowAt(i).RowId
                        };

                    var sheetType = headerOld.Header.Variant switch
                    {
                        ExcelVariant.Default => typeof(RawRow),
                        ExcelVariant.Subrows => typeof(RawSubrow),
                        _ => throw new InvalidDataException("Invalid variant"),
                    };

                    var oldSheet = dataOld.Excel.GetBaseSheet(sheetType, name: sheet);
                    var newSheet = dataNew.Excel.GetBaseSheet(sheetType, name: sheet);

                    var oldRowIds = Enumerable.Range(0, oldSheet.Count).Select(i => ResolveRowIdAt(i, oldSheet)).ToArray();
                    var newRowIds = Enumerable.Range(0, newSheet.Count).Select(i => ResolveRowIdAt(i, newSheet)).ToArray();

                    var comparableRowIds = oldRowIds.Intersect(newRowIds).Shuffle(new()).ToArray();

                    if (comparableRowIds.Length == 0)
                    {
                        Console.WriteLine("ERR: No rows to compare");
                        continue;
                    }

                    foreach (var rowId in comparableRowIds)
                    {
                        PopulateColumns(rowId, oldSheet, orderedColumnsOld, oldHashes);
                        PopulateColumns(rowId, newSheet, orderedColumnsNew, newHashes);
                    }
                }

                var movedHashes = new (int OldColumnIdx, bool IsMixed)[newHashes.Length];
                var usedColumns = new HashSet<int>();
                var unusedColumns = new HashSet<int>(Enumerable.Range(0, oldHashes.Length));
                for (var i = 0; i < newHashes.Length; ++i)
                {
                    var (oldCol, score) = forceNewColumns.Contains(i) ? ([], 0) : newHashes[i].FindBest(oldHashes, 0.8f, usedColumns);
                    var isMixed = oldCol.Count > 1;
                    if (isMixed)
                    {
                        var chosen = oldCol.GroupBy(k => Math.Abs(i - k)).MinBy(k => k.Key)!.Min();
                        Console.WriteLine($"WARN: Column {i} has equal candidates ({string.Join(", ", oldCol)}; {score:0.0000}; {chosen} was chosen)");
                        oldCol = [chosen];
                    }
                    if (oldCol.Count != 0)
                    {
                        usedColumns.Add(oldCol[0]);
                        unusedColumns.Remove(oldCol[0]);
                    }
                    movedHashes[i] = (oldCol.FirstOrDefault(-1), isMixed);
                }

                var deletedHashes = unusedColumns.Order().ToArray();
                if (deletedHashes.Length != 0)
                {
                    Console.WriteLine("Deleted columns:");
                    foreach (var colIdx in deletedHashes)
                    {
                        var (newCols, similarity) = oldHashes[colIdx].FindBest(newHashes);
                        Console.WriteLine($"    {colIdx} ({(schemaPaths?[colIdx]) ?? "Unknown"}) => ({string.Join(", ", newCols)}; {similarity:0.0000})");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Columns:");
                for (var l = 0; l < movedHashes.Length; l++)
                {
                    var (oldIdx, isMixed) = movedHashes[l];
                    var arrowChar = (oldIdx == l) ? '-' : '=';
                    if (oldIdx == -1)
                    {
                        Console.WriteLine($"    {l} <= New");
                        continue;
                    }
                    Console.WriteLine($"    {l} <{arrowChar} {oldIdx}{(isMixed ? "*" : "")} ({(schemaPaths?[oldIdx]) ?? "Unknown"}) ({newHashes[l].Similarity(oldHashes[oldIdx]):0.0000})");
                }
            }
            catch (Exception value)
            {
                Console.WriteLine($"Exception caught for {sheet}. {value}");
            }
        }
    }

    internal static void AppendHashCode(this RawRow row, SimilarColumn code, ExcelColumnDefinition column)
    {
        _ = column.Type switch
        {
            ExcelColumnDataType.String => code.Add(row.ReadString(column.Offset).ExtractText()),
            ExcelColumnDataType.Bool => code.Add(row.ReadBool(column.Offset)),
            ExcelColumnDataType.Int8 => code.Add(row.ReadInt8(column.Offset)),
            ExcelColumnDataType.UInt8 => code.Add(row.ReadUInt8(column.Offset)),
            ExcelColumnDataType.Int16 => code.Add(row.ReadInt16(column.Offset)),
            ExcelColumnDataType.UInt16 => code.Add(row.ReadUInt16(column.Offset)),
            ExcelColumnDataType.Int32 => code.Add(row.ReadInt32(column.Offset)),
            ExcelColumnDataType.UInt32 => code.Add(row.ReadUInt32(column.Offset)),
            ExcelColumnDataType.Float32 => code.Add(row.ReadFloat32(column.Offset)),
            ExcelColumnDataType.Int64 => code.Add(row.ReadInt64(column.Offset)),
            ExcelColumnDataType.UInt64 => code.Add(row.ReadUInt64(column.Offset)),
            >= ExcelColumnDataType.PackedBool0 and <= ExcelColumnDataType.PackedBool7 =>
                code.Add(row.ReadPackedBool(column.Offset, (byte)(column.Type - ExcelColumnDataType.PackedBool0))),
            _ => throw new InvalidOperationException($"Unknown column type {column.Type}")
        };
    }

    internal static void AppendHashCode(this RawSubrow row, SimilarColumn code, ExcelColumnDefinition column)
    {
        _ = column.Type switch
        {
            ExcelColumnDataType.String => code.Add(row.ReadString(column.Offset).ExtractText()),
            ExcelColumnDataType.Bool => code.Add(row.ReadBool(column.Offset)),
            ExcelColumnDataType.Int8 => code.Add(row.ReadInt8(column.Offset)),
            ExcelColumnDataType.UInt8 => code.Add(row.ReadUInt8(column.Offset)),
            ExcelColumnDataType.Int16 => code.Add(row.ReadInt16(column.Offset)),
            ExcelColumnDataType.UInt16 => code.Add(row.ReadUInt16(column.Offset)),
            ExcelColumnDataType.Int32 => code.Add(row.ReadInt32(column.Offset)),
            ExcelColumnDataType.UInt32 => code.Add(row.ReadUInt32(column.Offset)),
            ExcelColumnDataType.Float32 => code.Add(row.ReadFloat32(column.Offset)),
            ExcelColumnDataType.Int64 => code.Add(row.ReadInt64(column.Offset)),
            ExcelColumnDataType.UInt64 => code.Add(row.ReadUInt64(column.Offset)),
            >= ExcelColumnDataType.PackedBool0 and <= ExcelColumnDataType.PackedBool7 =>
                code.Add(row.ReadPackedBool(column.Offset, (byte)(column.Type - ExcelColumnDataType.PackedBool0))),
            _ => throw new InvalidOperationException($"Unknown column type {column.Type}")
        };
    }

    internal static IList<T> Shuffle<T>(this IEnumerable<T> sequence, Random randomNumberGenerator)
    {
        ArgumentNullException.ThrowIfNull(sequence);
        ArgumentNullException.ThrowIfNull(randomNumberGenerator);

        var values = sequence.ToList();
        var currentlySelecting = values.Count;
        while (currentlySelecting > 1)
        {
            var selectedElement = randomNumberGenerator.Next(currentlySelecting);
            currentlySelecting--;
            if (currentlySelecting != selectedElement)
                (values[selectedElement], values[currentlySelecting]) = (values[currentlySelecting], values[selectedElement]);
        }
        return values;
    }

    public sealed class SimilarColumn : IComparable<SimilarColumn>
    {
        private HashCode hash;
        private readonly List<int> fields = [];
        private readonly MinHash sim = new(16384);

        public SimilarColumn Add<T>(T value) where T : notnull
        {
            hash.Add(value);
            fields.Add(value.GetHashCode());
            if (fields.Count < 512)
                sim.Update(value.ToString()!);
            return this;
        }

        public double Similarity(SimilarColumn other)
        {
            if (fields.Count != other.fields.Count)
                return 0;

            if (fields.Count == 0)
                return 1;

            var totalSimilarity = fields.Zip(other.fields).Count((v) => v.First == v.Second) / (double)fields.Count;
            var sampleSimilarity = Math.Max(sim.Jaccard(other.sim), totalSimilarity);
            return (totalSimilarity + sampleSimilarity) / 2;
        }

        public (List<int> Columns, double Score) FindBest(SimilarColumn[] columns, double threshold = 0, HashSet<int>? matchedColumns = null)
        {
            List<int> bestColumn = [];
            var bestScore = 0.0;
            for (var i = columns.Length - 1; i >= 0; i--)
            {
                if (matchedColumns?.Contains(i) ?? false)
                    continue;
                var score = Similarity(columns[i]);
                if (score >= threshold)
                {
                    if (score == bestScore)
                        bestColumn.Add(i);
                    else if (score > bestScore)
                    {
                        bestColumn.Clear();
                        bestColumn.Add(i);
                        bestScore = score;
                    }
                }
            }
            return (bestColumn, bestScore);
        }

        public int CompareTo(SimilarColumn? other) =>
            hash.ToHashCode().CompareTo(other?.hash.ToHashCode());
    }
}
