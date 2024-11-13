namespace Lumina.Excel.Updater;

internal static class Program
{
    private static void Main(string[] args)
    {
        switch (args.Length == 0 ? null : args[0])
        {
            case "export_hash":
                ExportHashes.Main(args[1..]);
                break;
            case "compare_sheets":
                CompareSheets.Main(args[1..]);
                break;
            default:
                Console.WriteLine("Unknown args");
                break;
        }
    }
}
