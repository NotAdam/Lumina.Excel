using Lumina.Excel.Generator.Schema;
using Lumina;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;
using Lumina.Text.ReadOnly;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lumina.Excel.Generator;

public class SchemaSourceConverter
{
    public Sheet Definition { get; }
    public GameData GameData { get; }
    public TypeGlobalizer TypeGlobalizer { get; }
    public string IndentString { get; }
    private RawExcelSheet GameSheet { get; }
    private string? ReferencedSheetNamespace { get; }

    public string Code { get; }

    public string SheetName { get; }
    public uint ColumnHash { get; }
    public bool HasSubrows { get; }

    public SchemaSourceConverter(Sheet sheetDefinition, GameData gameData, TypeGlobalizer typeGlobalizer, string indentString, string? referencedSheetNamespace)
    {
        Definition = sheetDefinition;
        GameData = gameData;
        TypeGlobalizer = typeGlobalizer;
        IndentString = indentString;

        GameSheet = GameData.Excel.GetSheetRaw(Definition.Name) ?? throw new InvalidOperationException($"Sheet {Definition.Name} not found in game data");

        if (string.IsNullOrEmpty(referencedSheetNamespace))
            ReferencedSheetNamespace = null;
        else
        {
            if (referencedSheetNamespace!.EndsWith('.'))
                referencedSheetNamespace = referencedSheetNamespace![..^1];
            ReferencedSheetNamespace = referencedSheetNamespace;
        }

        SheetName = GameSheet.Name;
        ColumnHash = GameSheet.HeaderFile.GetColumnsHash();
        HasSubrows = GameSheet.Header.Variant == ExcelVariant.Subrows;

        var orderedColumns = GameSheet.Columns.GroupBy(c => c.Offset).OrderBy(c => c.Key).SelectMany(g => g.OrderBy(c => c.Type)).ToArray();

        Code = ParseFields(new(Definition.Fields, ProcessRelations(Definition.Fields, Definition.Relations), orderedColumns, new OffsetExpression().Add("offset"), true, 'i'), out var cols);

        if (!cols.IsEmpty)
            throw new InvalidOperationException($"Expected {orderedColumns.Length} columns, but only parsed {orderedColumns.Length - cols.Length}");
    }

    private string ParseFields(in ParentInfo parentInfo, out ReadOnlyMemory<ExcelColumnDefinition> nextColumns)
    {
        var code = new IndentedStringBuilder(IndentString);

        List<string> structDefs = [];
        var memberOffset = 0;
        var currentColumns = parentInfo.Columns;

        foreach (var field in parentInfo.Fields)
        {
            var (fieldCode, fieldStructDefs, fieldTypeName, fieldMemberOffset, fieldRelationed) = GetFieldParseCode(field, in parentInfo, currentColumns, parentInfo.Offset.Add(memberOffset), out currentColumns);

            if (!fieldRelationed)
            {
                if (field.Comment is { } comment)
                    code.AppendLine($"/// {GeneratorUtils.CreateDocstring(comment)}");
                code.AppendLine($"public readonly {fieldTypeName} {field.Name} => {fieldCode};");
                structDefs.AddRange(fieldStructDefs);
            }

            memberOffset += fieldMemberOffset;
        }

        if (parentInfo.Relations.Count != 0)
            code.AppendLine();

        foreach (var relation in parentInfo.Relations)
        {
            var (fieldCode, fieldTypeName) = relation.GetParseCode(TypeGlobalizer, in parentInfo);

            code.AppendLine($"public readonly {fieldTypeName} {relation.Name} => {fieldCode};");

            structDefs.Add(relation.GetDefinition(TypeGlobalizer, IndentString));
        }

        nextColumns = currentColumns;

        foreach (var def in structDefs)
        {
            code.AppendLine();

            code.AppendLines(def);
        }

        return code.ToString();
    }

    private class RelationInfo(string name, List<Field> relations)
    {
        public string Name => name;
        public string StructTypeName => GeneratorUtils.ConvertNameToStruct(Name);
        public int ArrayLength => ArraySize ?? throw new InvalidOperationException("Array length is unknown");

        private char? IterIdx { get; set; }
        private int? ArraySize { get; set; }
        private List<string> StructDefs { get; } = [];
        private HashSet<Field> IncompleteFields { get; } = [.. relations];
        private List<(Field Field, string Code, string FieldTypeName)> Fields { get; } = [];

        public bool AddRelation(Field field, string code, List<string> structDefs, string fieldTypeName, int arraySize, char iterIdx)
        {
            if (!IncompleteFields.Contains(field))
                return false;

            if (ArraySize.HasValue && ArraySize != arraySize)
                throw new ArgumentOutOfRangeException(nameof(arraySize), arraySize, $"Relation array size mismatch (Expected {ArrayLength}, got {arraySize} for field {field.Name})");
            if (!ArraySize.HasValue)
                ArraySize = arraySize;

            if (IterIdx.HasValue && IterIdx != iterIdx)
                throw new ArgumentOutOfRangeException(nameof(iterIdx), iterIdx, "Relation iteration variable mismatch. The parent must be the same.");
            if (!IterIdx.HasValue)
                IterIdx = iterIdx;

            IncompleteFields.Remove(field);
            Fields.Add((field, code, fieldTypeName));
            StructDefs.AddRange(structDefs);
            return true;
        }

        public (string Code, string FieldTypeName) GetParseCode(TypeGlobalizer globalizer, in ParentInfo parentInfo)
        {
            var fieldTypeName = $"{globalizer.GlobalizeType("Lumina.Excel.Collection")}<{StructTypeName}>";

            var code = $"new(page, {(parentInfo.IsRoot ? "offset" : "parentOffset")}, offset, static (page, parentOffset, offset, {parentInfo.IterIdx}) => new(page, parentOffset, {parentInfo.Offset}, {parentInfo.IterIdx}), {ArrayLength})";

            return (code, fieldTypeName);
        }

        public string GetDefinition(TypeGlobalizer globalizer, string indentString)
        {
            if (IncompleteFields.Count != 0)
                throw new InvalidOperationException("Incomplete fields still exist");

            var code = new IndentedStringBuilder(indentString);

            code.AppendLine($"public readonly struct {StructTypeName}({globalizer.GlobalizeType("Lumina.Excel.ExcelPage")} page, uint parentOffset, uint offset, uint {IterIdx!.Value})");
            code.AppendLine("{");
            using (code.IndentScope())
            {
                foreach (var (field, parseCode, fieldTypeName) in Fields)
                {
                    if (field.Comment is { } comment)
                        code.AppendLine($"/// {GeneratorUtils.CreateDocstring(comment)}");
                    code.AppendLine($"public readonly {fieldTypeName} {field.Name} => {parseCode};");
                }

                foreach (var def in StructDefs)
                {
                    code.AppendLine();

                    code.AppendLines(def);
                }
            }
            code.AppendLine("}");

            return code.ToString();
        }
    }

    private readonly record struct ParentInfo(List<Field> Fields, List<RelationInfo> Relations, ReadOnlyMemory<ExcelColumnDefinition> Columns, OffsetExpression Offset, bool IsRoot, char IterIdx);

    private (string Code, List<string> StructDefs, string FieldTypeName, int MemberOffset, bool AddedToRelation) GetFieldParseCode(Field field, in ParentInfo parentInfo, ReadOnlyMemory<ExcelColumnDefinition> columns, OffsetExpression currentOffset, out ReadOnlyMemory<ExcelColumnDefinition> nextColumns)
    {
        if (field.Type is FieldType.Scalar or FieldType.Icon or FieldType.Color or FieldType.ModelId)
        {
            var column = columns.Span[0];

            var columnParseCode = LookupReadFunc(column.Type)(currentOffset.ToString(), parentInfo.IsRoot ? "offset" : "parentOffset");

            var memberOffset = GetFirstColumnSize(columns.Span);
            nextColumns = columns[1..];

            return (columnParseCode, [], LookupTypeName(column.Type), memberOffset, false);
        }
        else if (field.Type is FieldType.Link)
        {
            var column = columns.Span[0];

            var columnParseCode = LookupReadFunc(column.Type)(currentOffset.ToString(), parentInfo.IsRoot ? "offset" : "parentOffset");
            if (column.Type != ExcelColumnDataType.UInt32)
                columnParseCode = $"(uint){columnParseCode}";

            var memberOffset = GetFirstColumnSize(columns.Span);
            nextColumns = columns[1..];

            if ((field.Targets is null) == (field.Condition is null))
                throw new InvalidOperationException("Field must have either a condition or a list of targets");

            if (field.Targets is { } targets)
            {
                var linkParseCode = GetLinkTargetCode(field.Targets, columnParseCode, false, out var fieldTypeName);
                return (linkParseCode, [], fieldTypeName, memberOffset, false);
            }
            else
            {
                var fieldTypeName = Globalize("Lumina.Excel.RowRef");

                var code = new IndentedStringBuilder(IndentString);

                var condition = field.Condition!.Switch ??
                    throw new InvalidOperationException("Conditional fields must have a switch reference");
                var conditionField = parentInfo.Fields.First(f => field.Condition.Switch.Equals(f.Name, StringComparison.Ordinal));
                if (conditionField.Type == FieldType.Array)
                    throw new InvalidOperationException("Conditional field cannot use an array as a switch condition.");
                var conditionOffset = GetMemberOffset(conditionField, in parentInfo, out var conditionColumns);
                if (conditionField.Type == FieldType.Link) // We only need the data/row id to switch on.
                    conditionField = conditionField with { Type = FieldType.Scalar };
                var (conditionParseCode, _, _, _, _) = GetFieldParseCode(conditionField, in parentInfo, conditionColumns, parentInfo.Offset.Add(conditionOffset), out _);

                code.AppendLine($"(/* {field.Condition.Switch} */ {conditionParseCode}) switch");
                using (code.IndentScope())
                {
                    code.AppendLine("{");
                    using (code.IndentScope())
                    {
                        foreach (var (val, condTargets) in field.Condition.Cases!)
                        {
                            var linkParseCode = GetLinkTargetCode(condTargets, columnParseCode, true, out var _);
                            code.AppendLine($"{val} => {linkParseCode},");
                        }
                        code.AppendLine($"_ => {GetLinkTargetCode([], columnParseCode, true, out var _)},");
                    }
                    code.AppendLine("}");
                }

                return (code.ToString(), [], fieldTypeName, memberOffset, false);
            }
        }
        else if (field.Type is FieldType.Array)
        {
            var structFields = field.Fields ?? [new Field() { Type = FieldType.Scalar }];
            var structSize = GetStructSize(structFields, columns);

            bool structIsFlattened;
            if (structFields.Count > 1)
            {
                if (structFields.Any(f => string.IsNullOrEmpty(f.Name)))
                    throw new InvalidOperationException("All fields in a struct must have a name");
                structIsFlattened = false;
            }
            else
                structIsFlattened = string.IsNullOrEmpty(structFields[0].Name);

            var arrayLength = field.Count ?? 1;
            var arrayColumns = columns[..(structSize.ColumnCount * arrayLength)];
            var structColumns = columns[..structSize.ColumnCount];

            string arrayCode, elementCode;
            string structTypeName;
            List<string> structDefs;
            if (structIsFlattened)
            {
                var newParentInfo = parentInfo with { IterIdx = (char)(parentInfo.IterIdx + 1), IsRoot = false };
                (elementCode, structDefs, structTypeName, _, _) = GetFieldParseCode(structFields[0], in newParentInfo, structColumns, currentOffset.Multiply(parentInfo.IterIdx.ToString(), structSize.ByteSize), out _);
                arrayCode = $"new(page, {(parentInfo.IsRoot ? "offset" : "parentOffset")}, offset, static (page, parentOffset, offset, {parentInfo.IterIdx}) => {elementCode}, {arrayLength})";
            }
            else
            {
                structTypeName = GeneratorUtils.ConvertNameToStruct(field.Name!);

                var elementOffset = currentOffset.Multiply(parentInfo.IterIdx.ToString(), structSize.ByteSize);
                var structInfo = new ParentInfo(structFields, ProcessRelations(structFields, field.Relations), structColumns, new OffsetExpression().Add("offset"), false, 'i');
                var structCode = ParseFields(in structInfo, out _);
                elementCode = $"new(page, parentOffset, {elementOffset})";
                arrayCode = $"new(page, {(parentInfo.IsRoot ? "offset" : "parentOffset")}, offset, static (page, parentOffset, offset, {parentInfo.IterIdx}) => {elementCode}, {arrayLength})";

                var newStructCode = new IndentedStringBuilder(IndentString);

                newStructCode.AppendLine($"public readonly struct {structTypeName}({Globalize("Lumina.Excel.ExcelPage")} page, uint parentOffset, uint offset)");
                newStructCode.AppendLine("{");
                using (newStructCode.IndentScope())
                    newStructCode.AppendLines(structCode);
                newStructCode.AppendLine("}");

                structDefs = [newStructCode.ToString()];
            }

            var memberOffset = structSize.ByteSize * arrayLength;
            nextColumns = columns[(structSize.ColumnCount * arrayLength)..];
            var fieldTypeName = $"{Globalize("Lumina.Excel.Collection")}<{structTypeName}>";

            var addedToRelation = false;
            foreach (var relation in parentInfo.Relations)
            {
                if (relation.AddRelation(field, elementCode, structDefs, structTypeName, arrayLength, parentInfo.IterIdx))
                {
                    addedToRelation = true;
                    break;
                }
            }

            return (arrayCode, structDefs, fieldTypeName, memberOffset, addedToRelation);
        }
        else
            throw new ArgumentException("Unknown field type");
    }

    private string GetLinkTargetCode(IReadOnlyList<string> targets, string columnParseCode, bool useGeneric, out string typeName)
    {
        if (targets.Count == 1)
        {
            var isSubrows = IsSheetSubrows(targets[0]);

            typeName = $"{Globalize(isSubrows ? "Lumina.Excel.SubrowRef" : "Lumina.Excel.RowRef")}<{DecorateReferencedType(targets[0])}>";
            if (useGeneric)
                return $"{Globalize("Lumina.Excel.RowRef")}.{(isSubrows ? "CreateSubrow" : "Create")}<{DecorateReferencedType(targets[0])}>(page.Module, {columnParseCode})";
            return $"new(page.Module, {columnParseCode})";
        }
        else if (targets.Count == 0)
        {
            typeName = Globalize("Lumina.Excel.RowRef");
            return $"{typeName}.CreateUntyped({columnParseCode})";
        }
        else
        {
            typeName = Globalize("Lumina.Excel.RowRef");
            return $"{typeName}.GetFirstValidRowOrUntyped(page.Module, {columnParseCode}, [{string.Join(", ", targets.Select(v => $"typeof({DecorateReferencedType(v)})"))}])";
        }
    }

    private List<RelationInfo> ProcessRelations(List<Field> fields, Dictionary<string, List<string>>? schemaRelations)
    {
        return schemaRelations?.Select(
            kv => new RelationInfo(kv.Key, kv.Value.Select(
                f => fields.First(field => f.Equals(field.Name, StringComparison.Ordinal))
            ).ToList()
        )).ToList() ?? [];
    }

    private (int ByteSize, int ColumnCount) GetStructSize(IEnumerable<Field> fields, ReadOnlyMemory<ExcelColumnDefinition> columns)
    {
        var byteSize = 0;
        var columnCount = 0;
        foreach(var field in fields)
        {
            if (field.Type == FieldType.Array)
            {
                var s = GetStructSize(field.Fields ?? [new Field() { Type = FieldType.Scalar }], columns[columnCount..]);
                var fieldCount = field.Count ?? 1;
                byteSize += s.ByteSize * fieldCount;
                columnCount += s.ColumnCount * fieldCount;
            }
            else
            {
                byteSize += GetFirstColumnSize(columns.Span[columnCount..]);
                columnCount++;
            }
        }
        return (byteSize, columnCount);
    }

    private int GetMemberOffset(Field field, in ParentInfo parentInfo, out ReadOnlyMemory<ExcelColumnDefinition> memberColumns)
    {
        var byteOffset = 0;
        var columnOffset = 0;
        foreach (var memberField in parentInfo.Fields)
        {
            int fieldByteSize;
            int fieldColumnSize;
            if (memberField.Type == FieldType.Array)
            {
                var s = GetStructSize(memberField.Fields ?? [new Field() { Type = FieldType.Scalar }], parentInfo.Columns[columnOffset..]);
                var fieldCount = memberField.Count ?? 1;
                fieldByteSize = s.ByteSize * fieldCount;
                fieldColumnSize = s.ColumnCount * fieldCount;
            }
            else
            {
                fieldByteSize = GetFirstColumnSize(parentInfo.Columns.Span[columnOffset..]);
                fieldColumnSize = 1;
            }

            if (memberField != field)
            {
                byteOffset += fieldByteSize;
                columnOffset += fieldColumnSize;
            }
            else
            {
                memberColumns = parentInfo.Columns.Slice(columnOffset, fieldColumnSize);
                return byteOffset;
            }
        }
        throw new ArgumentException("Field not found in fields");
    }

    private int GetFirstColumnSize(ReadOnlySpan<ExcelColumnDefinition> columns)
    {
        var column = columns[0];
        if (columns.Length > 1)
            return columns[1].Offset - column.Offset;
        return 0;
    }

    private string Globalize(string typeName) =>
        TypeGlobalizer.GlobalizeType(typeName);

    private string Globalize<T>() =>
        TypeGlobalizer.GlobalizeType(typeof(T).FullName);

    private string DecorateReferencedType(string typeName) =>
        ReferencedSheetNamespace == null ? typeName : Globalize($"{ReferencedSheetNamespace}.{typeName}");

    private string LookupTypeName(ExcelColumnDataType type) =>
        type switch
    {
        ExcelColumnDataType.String => Globalize<ReadOnlySeString>(),
        ExcelColumnDataType.Bool => "bool",
        ExcelColumnDataType.Int8 => "sbyte",
        ExcelColumnDataType.UInt8 => "byte",
        ExcelColumnDataType.Int16 => "short",
        ExcelColumnDataType.UInt16 => "ushort",
        ExcelColumnDataType.Int32 => "int",
        ExcelColumnDataType.UInt32 => "uint",
        ExcelColumnDataType.Float32 => "float",
        ExcelColumnDataType.Int64 => "long",
        ExcelColumnDataType.UInt64 => "ulong",
        >= ExcelColumnDataType.PackedBool0 and <= ExcelColumnDataType.PackedBool7 => "bool",
        var n => throw new InvalidOperationException($"Unknown column type {n}")
    };

    private Func<string, string, string> LookupReadFunc(ExcelColumnDataType type) =>
        type switch
    {
        ExcelColumnDataType.Bool or
        ExcelColumnDataType.Int8 or
        ExcelColumnDataType.UInt8 or
        ExcelColumnDataType.Int16 or
        ExcelColumnDataType.UInt16 or
        ExcelColumnDataType.Int32 or
        ExcelColumnDataType.UInt32 or
        ExcelColumnDataType.Float32 or
        ExcelColumnDataType.Int64 or
        ExcelColumnDataType.UInt64 => (d, _) => $"page.Read{type}({d})",
        ExcelColumnDataType.String => (d, o) => $"page.ReadString({d}, {o})",
        >= ExcelColumnDataType.PackedBool0 and <= ExcelColumnDataType.PackedBool7 => (d, _) => $"page.ReadPackedBool({d}, {(byte)(type - ExcelColumnDataType.PackedBool0)})",
        var n => throw new InvalidOperationException($"Unknown column type {n}")
    };

    private bool IsSheetSubrows(string sheetName) =>
        GameData.GetFile<ExcelHeaderFile>(ExcelModule.BuildExcelHeaderPath(sheetName))!.Header.Variant == ExcelVariant.Subrows;
}
