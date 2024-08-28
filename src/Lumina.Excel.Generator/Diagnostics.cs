using Microsoft.CodeAnalysis;

namespace Lumina.Excel.Generator;

internal static class Diagnostics
{
    public static DiagnosticDescriptor InvalidSchemaPath => new("EXD001", "Schema path must be a string literal", "Schema path must be a string literal", "Schema", DiagnosticSeverity.Error, true);

    public static DiagnosticDescriptor SchemaNotFound => new("EXD002", "Schema not found", "Schema file not found. Attempted: {0}", "Schema", DiagnosticSeverity.Error, true);
    
    public static DiagnosticDescriptor SheetNotFound => new("EXD003", "Sheet not found", "Sheet file not found in game files. Sheet name: {0}", "Schema", DiagnosticSeverity.Error, true);

    public static DiagnosticDescriptor SheetFailedGeneration => new("EXD004", "Sheet failed to generate", "Sheet failed to generate. Sheet name: {0} Error: {1}", "Schema", DiagnosticSeverity.Error, true);
}
