using Lumina.Excel.Generator.Schema;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Text.ReadOnly;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lumina.Excel.Generator;

public class SchemaSourceConverter
{
    public Sheet Definition { get; }
    public GameData GameData { get; }
    public string AssemblyName { get; }
    public TypeGlobalizer TypeGlobalizer { get; }
    public string IndentString { get; }
    private RawExcelSheet GameSheet { get; }
    private string? Namespace { get; }
    private string? ReferencedSheetNamespace { get; }

    public string Code { get; }

    public string SheetName { get; }
    public uint ColumnHash { get; }
    public bool HasSubrows { get; }

    public bool IsUnsafe { get; set; }

    public SchemaSourceConverter(Sheet sheetDefinition, GameData gameData, bool usePendingFields, string assemblyName, TypeGlobalizer typeGlobalizer, string indentString, string? selfNamespace, string? referencedSheetNamespace)
    {
        Definition = sheetDefinition;
        GameData = gameData;
        AssemblyName = assemblyName;
        TypeGlobalizer = typeGlobalizer;
        IndentString = indentString;

        GameSheet = GameData.Excel.GetSheetRaw(Definition.Name) ?? throw new InvalidOperationException($"Sheet {Definition.Name} not found in game data");

        Namespace = selfNamespace;

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
        var fields = !usePendingFields ? Definition.Fields : Definition.PendingFields ?? Definition.Fields;

        Code = ParseFields(new(fields, ProcessRelations(fields, Definition.Relations), [], orderedColumns, new OffsetExpression().Add("offset"), true), out var cols);

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
                WriteField(code, TypeGlobalizer, field, fieldCode, fieldTypeName);

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

        if (parentInfo.CollectionMethods.Count != 0)
        {
            IsUnsafe = true;
            code.AppendLine();
        }

        foreach (var method in parentInfo.CollectionMethods)
            code.AppendLine(method.GetParseCode(TypeGlobalizer));

        foreach (var def in structDefs)
        {
            code.AppendLine();

            code.AppendLines(def);
        }

        return code.ToString();
    }

    private readonly record struct CollectionMethod(string Name, string Code, string ReturnTypeName)
    {
        public readonly string GetParseCode(TypeGlobalizer globalizer) =>
            $"private static {ReturnTypeName} {Name}({globalizer.GlobalizeType("Lumina.Excel.ExcelPage")} page, uint parentOffset, uint offset, uint i) => {Code};";
    }

    private class RelationInfo(string name, List<Field> relations)
    {
        public string Name => name;
        public string StructTypeName => GeneratorUtils.ConvertNameToStruct(Name);
        public int ArrayLength => ArraySize ?? throw new InvalidOperationException("Array length is unknown");

        private int? ArraySize { get; set; }
        private List<string> StructDefs { get; } = [];
        private HashSet<Field> IncompleteFields { get; } = [.. relations];
        private List<(Field Field, string Code, string FieldTypeName)> Fields { get; } = [];
        private List<CollectionMethod> CollectionMethods { get; } = [];

        public bool AddRelation(Field field, string code, List<string> structDefs, string fieldTypeName, int arraySize)
        {
            if (!IncompleteFields.Contains(field))
                return false;

            if (ArraySize.HasValue && ArraySize != arraySize)
                throw new ArgumentOutOfRangeException(nameof(arraySize), arraySize, $"Relation array size mismatch (Expected {ArrayLength}, got {arraySize} for field {field.Name})");
            if (!ArraySize.HasValue)
                ArraySize = arraySize;

            IncompleteFields.Remove(field);
            Fields.Add((field, code, fieldTypeName));
            StructDefs.AddRange(structDefs);
            return true;
        }

        public void AddCollectionMethod(CollectionMethod method)
        {
            CollectionMethods.Add(method);
        }

        public (string Code, string FieldTypeName) GetParseCode(TypeGlobalizer globalizer, in ParentInfo parentInfo)
        {
            var fieldTypeName = $"{globalizer.GlobalizeType("Lumina.Excel.Collection")}<{StructTypeName}>";

            var methodName = parentInfo.AddCollectionMethod(Name, $"new(page, parentOffset, {parentInfo.Offset}, i)", StructTypeName);

            var code = $"new(page, {(parentInfo.IsRoot ? "offset" : "parentOffset")}, offset, &{methodName}, {ArrayLength})";

            return (code, fieldTypeName);
        }

        public string GetDefinition(TypeGlobalizer globalizer, string indentString)
        {
            if (IncompleteFields.Count != 0)
                throw new InvalidOperationException("Incomplete fields still exist");

            var code = new IndentedStringBuilder(indentString);

            code.AppendLine($"public readonly struct {StructTypeName}({globalizer.GlobalizeType("Lumina.Excel.ExcelPage")} page, uint parentOffset, uint offset, uint i)");
            code.AppendLine("{");
            using (code.IndentScope())
            {
                foreach (var (field, parseCode, fieldTypeName) in Fields)
                    WriteField(code, globalizer, field, parseCode, fieldTypeName);

                if (CollectionMethods.Count != 0)
                {
                    code.AppendLine();

                    foreach (var method in CollectionMethods)
                        code.AppendLine(method.GetParseCode(globalizer));
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

    private readonly record struct ParentInfo(List<Field> Fields, List<RelationInfo> Relations, List<CollectionMethod> CollectionMethods, ReadOnlyMemory<ExcelColumnDefinition> Columns, OffsetExpression Offset, bool IsRoot)
    {
        public string AddCollectionMethod(string name, string code, string returnTypeName)
        {
            name = $"{name}Ctor";
            var methodName = name;
            var i = 0;
            // So far, has never happened
            while (CollectionMethods.Any(c => c.Name.Equals(methodName, StringComparison.Ordinal)))
                methodName = $"{name}_{++i}";

            CollectionMethods.Add(new CollectionMethod(methodName, code, returnTypeName));
            return methodName;
        }
    }

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
            var structColumnSize = GetStructColumnSize(structFields, columns);
            var structByteSize = GetArraySize(columns, structColumnSize, 1);

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
            var arrayByteSize = GetArraySize(columns, structColumnSize, arrayLength);
            var arrayColumns = columns[..(structColumnSize * arrayLength)];
            var structColumns = columns[..structColumnSize];

            string arrayCode, elementCode;
            string structTypeName;
            List<string> structDefs;
            if (structIsFlattened)
            {
                var newParentInfo = parentInfo with { IsRoot = false };
                (elementCode, structDefs, structTypeName, _, _) = GetFieldParseCode(structFields[0] with { Name = structFields[0].Name ?? field.Name, PendingName = structFields[0].PendingName ?? field.PendingName }, in newParentInfo, structColumns, currentOffset.Multiply("i", structByteSize), out _);
            }
            else
            {
                structTypeName = GeneratorUtils.ConvertNameToStruct(field.Name!);

                var elementOffset = currentOffset.Multiply("i", structByteSize);
                var structInfo = new ParentInfo(structFields, ProcessRelations(structFields, field.Relations), [], structColumns, new OffsetExpression().Add("offset"), false);
                var structCode = ParseFields(in structInfo, out _);
                elementCode = $"new(page, parentOffset, {elementOffset})";

                var newStructCode = new IndentedStringBuilder(IndentString);

                newStructCode.AppendLine($"public readonly struct {structTypeName}({Globalize("Lumina.Excel.ExcelPage")} page, uint parentOffset, uint offset)");
                newStructCode.AppendLine("{");
                using (newStructCode.IndentScope())
                    newStructCode.AppendLines(structCode);
                newStructCode.AppendLine("}");

                structDefs = [newStructCode.ToString()];
            }

            var memberOffset = arrayByteSize;
            nextColumns = columns[(structColumnSize * arrayLength)..];
            var fieldTypeName = $"{Globalize("Lumina.Excel.Collection")}<{structTypeName}>";

            var addedToRelation = false;
            foreach (var relation in parentInfo.Relations)
            {
                if (relation.AddRelation(field, elementCode, structDefs, structTypeName, arrayLength))
                {
                    addedToRelation = true;
                    break;
                }
            }

            if (!addedToRelation)
            {
                var ctorName = parentInfo.AddCollectionMethod(field.Name!, elementCode, structTypeName);
                arrayCode = $"new(page, {(parentInfo.IsRoot ? "offset" : "parentOffset")}, offset, &{ctorName}, {arrayLength})";
            }
            else
                arrayCode = null!;
            
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
                return $"{Globalize("Lumina.Excel.RowRef")}.{(isSubrows ? "CreateSubrow" : "Create")}<{DecorateReferencedType(targets[0])}>(page.Module, {columnParseCode}, page.Language)";
            return $"new(page.Module, {columnParseCode}, page.Language)";
        }
        else if (targets.Count == 0)
        {
            typeName = Globalize("Lumina.Excel.RowRef");
            return $"{typeName}.CreateUntyped({columnParseCode}, page.Language)";
        }
        else
        {
            typeName = Globalize("Lumina.Excel.RowRef");
            var typeHash = CreateTypeHash(targets);
            return $"{typeName}.GetFirstValidRowOrUntyped(page.Module, {columnParseCode}, [{string.Join(", ", targets.Select(v => $"typeof({DecorateReferencedType(v)})"))}], {typeHash}, page.Language)";
        }

        int CreateTypeHash(IEnumerable<string> targets)
        {
            var ns = ReferencedSheetNamespace ?? Namespace;
            if (ns != null)
                ns = $"{ns}.";
            var ret = new HashCode();
            foreach (var target in targets)
                ret.Add($"{AssemblyName};{ns}{target}");
            return ret.ToHashCode();
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

    private static void WriteField(IndentedStringBuilder code, TypeGlobalizer globalizer, Field field, string parseCode, string fieldTypeName)
    {
        if (field.PendingName != null)
        {
            if (field.Comment != null)
                code.AppendLine($"/// {GeneratorUtils.CreateDocstring(field.Comment)}");
            code.AppendLine($"public readonly {fieldTypeName} {field.PendingName} => {parseCode};");
        }

        if (field.Comment is { } comment)
            code.AppendLine($"/// {GeneratorUtils.CreateDocstring(comment)}");
        if (field.PendingName != null)
            code.AppendLine($@"[{globalizer.GlobalizeType("System.Obsolete")}({GeneratorUtils.EscapeStringToken($"Use {field.PendingName} instead.")})]");
        code.AppendLine($"public readonly {fieldTypeName} {field.Name} => {parseCode};");
    }

    private int GetStructColumnSize(IEnumerable<Field> fields, ReadOnlyMemory<ExcelColumnDefinition> columns)
    {
        var columnCount = 0;
        foreach(var field in fields)
        {
            if (field.Type == FieldType.Array)
            {
                var s = GetStructColumnSize(field.Fields ?? [new Field() { Type = FieldType.Scalar }], columns[columnCount..]);
                columnCount += s * (field.Count ?? 1);
            }
            else
                columnCount++;
        }

        return columnCount;
    }

    private int GetArraySize(ReadOnlyMemory<ExcelColumnDefinition> columns, int columnCount, int arrayLength)
    {
        columnCount *= arrayLength;
        if (columnCount == columns.Length)
            return GetArraySize(columns, columns.Length - 1, 1) + GetFirstColumnSize(columns.Span[^1..]);
        return columns.Span[columnCount].Offset - columns.Span[0].Offset;
    }

    private int GetMemberOffset(Field field, in ParentInfo parentInfo, out ReadOnlyMemory<ExcelColumnDefinition> memberColumns)
    {
        var columnOffset = 0;
        foreach (var memberField in parentInfo.Fields)
        {
            int fieldColumnSize;
            if (memberField.Type == FieldType.Array)
            {
                var s = GetStructColumnSize(memberField.Fields ?? [new Field() { Type = FieldType.Scalar }], parentInfo.Columns[columnOffset..]);
                fieldColumnSize = s * (memberField.Count ?? 1);
            }
            else
                fieldColumnSize = 1;

            if (memberField != field)
                columnOffset += fieldColumnSize;
            else
            {
                memberColumns = parentInfo.Columns.Slice(columnOffset, fieldColumnSize);
                var byteSize = parentInfo.Columns.Span[columnOffset].Offset - parentInfo.Columns.Span[0].Offset;
                return byteSize;
            }
        }
        throw new ArgumentException("Field not found in fields");
    }

    private int GetFirstColumnSize(ReadOnlySpan<ExcelColumnDefinition> columns)
    {
        var column = columns[0];
        if (columns.Length > 1)
            return columns[1].Offset - column.Offset;
        return column.Type switch
        {
            ExcelColumnDataType.String => 4,
            ExcelColumnDataType.Bool => 1,
            ExcelColumnDataType.Int8 => 1,
            ExcelColumnDataType.UInt8 => 1,
            ExcelColumnDataType.Int16 => 2,
            ExcelColumnDataType.UInt16 => 2,
            ExcelColumnDataType.Int32 => 4,
            ExcelColumnDataType.UInt32 => 4,
            ExcelColumnDataType.Float32 => 4,
            ExcelColumnDataType.Int64 => 8,
            ExcelColumnDataType.UInt64 => 8,
            ExcelColumnDataType.PackedBool0 => 1,
            > ExcelColumnDataType.PackedBool0 and <= ExcelColumnDataType.PackedBool7 => 0,
            var n => throw new InvalidOperationException($"Unknown column type {n}")
        };
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
