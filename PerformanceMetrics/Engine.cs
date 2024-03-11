using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMetrics;

internal class Engine
{
    private const int Iterations = 1000000;

    public void Run()
    {
        ConsoleEx.WriteLine($"Calculating Pi {Iterations:#,##0} times...");
        var piCalculator = new PiCalculator(Iterations);
        piCalculator.Calculate();
        ConsoleEx.WriteLine($"Inline took {piCalculator.InlineTicks} ticks.");
        ConsoleEx.WriteLine($"Method calls took {piCalculator.MethodTicks} ticks.");
        decimal delta = (piCalculator.MethodTicks - (decimal)piCalculator.InlineTicks) / piCalculator.MethodTicks;
        ConsoleEx.WriteColoredLine($"Calling a method is {delta:P} slower.", ConsoleColor.Yellow);
        ConsoleEx.WriteBlankLine();

    }
}
