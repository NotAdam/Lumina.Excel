using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace Lumina.Excel.Generator;

internal static class SourceConstants
{
    public const string GeneratedNamespace = "Lumina.Excel.Generator";
    public const string GeneratedCodeToolName = "Lumina.Excel.Generator";
    public const string GeneratedCode = "2.0.0";

    public static SourceText CreateAttributeSource(string attributeName, bool useFileScopedNamespace)
    {
        var ret = $@"
[GeneratedCode({GeneratorUtils.EscapeStringToken(GeneratedCodeToolName)}, {GeneratorUtils.EscapeStringToken(GeneratedCode)})]
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
internal sealed class {attributeName}Attribute : Attribute
{{
    public string SchemaPath {{ get; }}
    
    public {attributeName}Attribute(string schemaPath)
    {{
        SchemaPath = schemaPath;
    }}
}}";

        ret = ScopeNamespace(useFileScopedNamespace, "    ", GeneratedNamespace, ret);

        ret = $@"
using System;
using System.CodeDom.Compiler;
{ret}";

        return SourceText.From(ret.Trim(), Encoding.UTF8);
    }

    public static SourceText CreateSchemaSource(string? targetNamespace, string className, bool isPartial, bool useFileScopedNamespace, bool markExperimental, SchemaSourceConverter converter)
    {
        var globalize = converter.TypeGlobalizer.GlobalizeType;

        var rowType = $"{globalize(converter.HasSubrows ? "Lumina.Excel.IExcelSubrow" : "Lumina.Excel.IExcelRow")}<{className}>";

        var sb = new IndentedStringBuilder(converter.IndentString);
        sb.AppendLine($@"[{globalize("System.CodeDom.Compiler.GeneratedCode")}({GeneratorUtils.EscapeStringToken(GeneratedCodeToolName)}, {GeneratorUtils.EscapeStringToken(GeneratedCode)})]");
        if (markExperimental)
            sb.AppendLine($@"[{globalize("System.Diagnostics.CodeAnalysis.Experimental")}({GeneratorUtils.EscapeStringToken("PendingExcelSchema")})]");
        sb.AppendLine($@"[{globalize("Lumina.Excel.Sheet")}({GeneratorUtils.EscapeStringToken(converter.SheetName)}, 0x{converter.ColumnHash:X8})]");
        sb.AppendLine($@"readonly {(isPartial ? "partial" : "public")}{(converter.IsUnsafe ? " unsafe" : string.Empty)} struct {className}({globalize("Lumina.Excel.ExcelPage")} page, uint offset, uint row{(converter.HasSubrows ? ", ushort subrow" : string.Empty)}) : {rowType}");
        sb.AppendLine("{");
        using (sb.IndentScope())
        {
            sb.AppendLine("public uint RowId => row;");
            if (converter.HasSubrows)
                sb.AppendLine("public ushort SubrowId => subrow;");
            sb.AppendLine();
            sb.AppendLines(converter.Code);
            sb.AppendLine();

            if (converter.HasSubrows)
            {
                sb.AppendLine($"static {className} {rowType}.Create({globalize("Lumina.Excel.ExcelPage")} page, uint offset, uint row, ushort subrow) =>");
                using (sb.IndentScope())
                    sb.AppendLine("new(page, offset, row, subrow);");
            }
            else
            {
                sb.AppendLine($"static {className} {rowType}.Create({globalize("Lumina.Excel.ExcelPage")} page, uint offset, uint row) =>");
                using (sb.IndentScope())
                    sb.AppendLine("new(page, offset, row);");
            }
        }
        sb.AppendLine("}");

        var ret = sb.ToString();

        if (!string.IsNullOrEmpty(targetNamespace))
            ret = ScopeNamespace(useFileScopedNamespace, converter.IndentString, targetNamespace!, ret);

        ret = $"{converter.TypeGlobalizer.GetUsings()}\n{ret}";

        return SourceText.From(ret.Trim(), Encoding.UTF8);
    }

    private static string ScopeNamespace(bool useFileScope, string indentString, string ns, string text)
    {
        var b = new StringBuilder();
        text = text.Trim();
        if (useFileScope)
        {
            b.AppendLine($"namespace {ns};");
            b.AppendLine();
            b.Append(text);
        }
        else
        {
            b.AppendLine($"namespace {ns}");
            b.AppendLine("{");
            b.AppendLine(IndentedStringBuilder.Indent(text, indentString, 1));
            b.AppendLine("}");
        }
        return b.ToString();
    }
}
