using System;
using System.IO;

namespace Lumina.Excel.Generator;

public static class FileIO
{
    public static Stream? TryOpenFile(string path)
    {
        try
        {
            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public static string[] GetFiles(string folder, string pattern)
    {
        var type = Type.GetType("System.IO.Directory");
        var getFiles = type.GetMethod("GetFiles", [typeof(string), typeof(string)]);
        return (string[])getFiles.Invoke(null, [folder, pattern]);
    }
}