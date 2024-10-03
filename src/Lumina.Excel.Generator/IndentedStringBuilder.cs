using System;
using System.IO;
using System.Text;

namespace Lumina.Excel.Generator;

public class IndentedStringBuilder(string indentString, int initialIndentLevel = 0)
{
    private StringBuilder Builder { get; } = new();
    private int IndentLevel { get; set; } = initialIndentLevel;

    private void ApplyIndent(int additionalIndent)
    {
        if (IndentLevel + additionalIndent == 0)
            return;

        for (var i = 0; i < IndentLevel + additionalIndent; i++)
            Builder.Append(indentString);
    }

    public IndentedStringBuilder AppendLine(string value, int additionalIndent = 0)
    {
        ApplyIndent(additionalIndent);
        Builder.AppendLine(value);
        return this;
    }

    public IndentedStringBuilder AppendLines(string value, int additionalIndent = 0)
    {
        var reader = new StringReader(value);
        while (true)
        {
            var line = reader.ReadLine();
            if (line == null)
                break;
            AppendLine(line, additionalIndent);
        }
        return this;
    }

    public IndentedStringBuilder Append(string value)
    {
        Builder.Append(value);
        return this;
    }

    public IndentedStringBuilder AppendLine()
    {
        Builder.AppendLine();
        return this;
    }

    public Indenter IndentScope() =>
        new(this);

    public IndentedStringBuilder Indent()
    {
        IndentLevel++;
        return this;
    }

    public IndentedStringBuilder Deindent()
    {
        IndentLevel--;
        return this;
    }

    public static string Indent(string value, string indentString, int indentLevel)
    {
        var builder = new IndentedStringBuilder(indentString, indentLevel);
        builder.AppendLines(value);
        return builder.ToString();
    }

    public override string ToString()
    {
        return Builder.ToString().TrimEnd();
    }
}

public class Indenter : IDisposable
{
    private IndentedStringBuilder Builder { get; }

    public Indenter(IndentedStringBuilder builder)
    {
        Builder = builder;
        Builder.Indent();
    }

    public void Dispose() =>
        Builder.Deindent();
}
