using System;
using System.Collections.Generic;
using System.Text;

namespace Lumina.Excel.Generator;

public class TypeGlobalizer(bool useUsings)
{
    private SortedSet<string>? Usings { get; } = useUsings ? [] : null;

    public string GlobalizeType(string type)
    {
        var nsIdx = type.LastIndexOf('.');
        if (nsIdx == -1)
            throw new InvalidOperationException($"Cannot globalize type. \"{type}\" is not in a namespace");
        var ns = type[..nsIdx];
        if (Usings != null)
        {
            Usings.Add(ns);
            return type[(nsIdx + 1)..];
        }
        return $"global::{type}";
    }

    public string GetUsings()
    {
        if (Usings == null)
            return string.Empty;

        var sb = new StringBuilder();
        foreach (var ns in Usings)
            sb.AppendLine($"using {ns};");
        return sb.ToString();
    }
}
