using Microsoft.CodeAnalysis;
using System.Text;
using System.Text.Encodings.Web;
using System.Xml;

namespace Lumina.Excel.Generator;

internal static class GeneratorUtils
{
    public static void Debug(this SourceProductionContext context, string message)
    {
        context.ReportDiagnostic(Diagnostic.Create("EXD000", "Debug", message, DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));
    }

    public static string EscapeStringToken(string text) =>
        $"\"{JavaScriptEncoder.UnsafeRelaxedJsonEscaping.Encode(text)}\"";

    public static string CreateDocstring(string text)
    {
        var sb = new StringBuilder();
        using (var writer = XmlWriter.Create(sb, new XmlWriterSettings() { OmitXmlDeclaration = true, NewLineChars = " " })) 
        {
            writer.WriteStartElement("summary");
            writer.WriteString(text);
            writer.WriteEndElement();
        }
        return sb.ToString();
    }

    public static string ConvertNameToStruct(string name)
    {
        return $"{name}Struct";
    }
}
