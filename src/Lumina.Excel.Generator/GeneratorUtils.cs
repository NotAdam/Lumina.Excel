using Microsoft.CodeAnalysis;
using System;
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
        using (var writer = XmlWriter.Create(sb, new XmlWriterSettings() { OmitXmlDeclaration = true })) 
        {
            writer.WriteStartElement("summary");
            writer.WriteWhitespace("\n");
            writer.WriteString("/// ");
            var lines = text.Split(["\r\n", "\n"], StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (i > 0)
                {
                    writer.WriteElementString("br", string.Empty);
                    writer.WriteWhitespace("\n");
                    writer.WriteString("/// ");
                }
                writer.WriteString(line.Trim());
            }
            writer.WriteWhitespace("\n");
            writer.WriteString("/// ");
            writer.WriteEndElement();
        }
        return sb.ToString();
    }

    public static string ConvertNameToStruct(string name)
    {
        return $"{name}Struct";
    }
}
