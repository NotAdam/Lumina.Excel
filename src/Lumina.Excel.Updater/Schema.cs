using System.ComponentModel;

namespace Lumina.Excel.Updater.Schema;

public record Sheet
{
    public required string Name { get; set; }

    public string? DisplayField { get; set; }

    public required List<Field> Fields { get; set; }

    public Dictionary<string, List<string>>? Relations { get; set; }
}

public record Field
{
    public string? Name { get; set; }

    public int? Count { get; set; }

    [DefaultValue(FieldType.Scalar)]
    public FieldType Type { get; set; }

    public string? Comment { get; set; }

    public List<Field>? Fields { get; set; }

    public Dictionary<string, List<string>>? Relations { get; set; }

    public Condition? Condition { get; set; }

    public List<string>? Targets { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Type})";
    }
}

public enum FieldType
{
    Scalar,
    Array,
    Icon,
    ModelId,
    Color,
    Link,
}

public record Condition
{
    public string? Switch { get; set; }

    public Dictionary<int, List<string>>? Cases { get; set; }
}
