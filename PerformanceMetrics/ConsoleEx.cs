
namespace PerformanceMetrics;

internal class ConsoleEx
{
    public static void WriteLine(string value)
    {
        Console.WriteLine(value);
    }

    public static void WriteBlankLine()
    {
        Console.WriteLine();
    }

    public static void WriteColoredLine(string value, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
        Console.ResetColor();
    }
}
