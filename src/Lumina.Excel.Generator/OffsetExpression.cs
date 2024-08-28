using System;
using System.Collections.Generic;

namespace Lumina.Excel.Generator;

internal readonly struct OffsetExpression
{
    private readonly struct OffsetPart(string? variable, int coefficient)
    {
        public string? Variable => variable;
        public int Coefficient => coefficient;

        public static OffsetPart? Multiply(string variable, int coefficient)
        {
            if (coefficient == 0)
                return null;

            return new(variable, coefficient);
        }

        public static OffsetPart? Add(string variable)
        {
            return Multiply(variable, 1);
        }

        public static OffsetPart? Add(int constant)
        {
            if (constant == 0)
                return null;

            return new(null, constant);
        }

        public override string ToString()
        {
            if (variable == null)
                return coefficient.ToString();

            if (coefficient == 0)
                throw new InvalidOperationException("Invalid state");

            if (coefficient == 1)
                return variable;

            return $"{variable} * {coefficient}";
        }
    }

    private readonly OffsetPart[] parts;

    private OffsetExpression(ReadOnlySpan<OffsetPart> initial, OffsetPart newPart)
    {
        var ret = new List<OffsetPart>(initial.Length + 1);
        var consumed = false;
        foreach (var part in initial)
        {
            if (!consumed && part.Variable == newPart.Variable &&
                OffsetPart.Multiply(part.Variable!, part.Coefficient + newPart.Coefficient) is { } next)
            {
                ret.Add(next);
                consumed = true;
            }
            else
                ret.Add(part);
        }
        if (!consumed)
            ret.Add(newPart);
        parts = [.. ret];
    }

    public OffsetExpression()
    {
        parts = [];
    }

    public OffsetExpression Add(int value)
    {
        if (OffsetPart.Add(value) is { } newPart)
            return new(parts, newPart);
        return this;
    }

    public OffsetExpression Add(string variable)
    {
        if (OffsetPart.Add(variable) is { } newPart)
            return new(parts, newPart);
        return this;
    }

    public OffsetExpression Multiply(string variable, int value)
    {
        if (OffsetPart.Multiply(variable, value) is { } newPart)
            return new(parts, newPart);
        return this;
    }

    public override string ToString()
    {
        if (parts.Length == 0)
            return "0";

        return string.Join(" + ", parts);
    }
}
