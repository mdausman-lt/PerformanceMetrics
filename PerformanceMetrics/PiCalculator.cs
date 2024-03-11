using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMetrics
{
    internal class PiCalculator
    {
        int _iterations;

        public long InlineTicks { get; private set; } = 0;
        public long MethodTicks { get; private set; } = 0;

        public PiCalculator(int iterations)
        {
            _iterations = iterations;
        }

        public void Calculate()
        {
            decimal pi;
            var inlineStopwatch = new Stopwatch();
            var methodStopwatch = new Stopwatch();

            for (int x = 0; x < _iterations; x++)
            {
                inlineStopwatch.Restart();
                pi = 355 / 113;
                InlineTicks += inlineStopwatch.ElapsedTicks;

                methodStopwatch.Restart();
                pi = CalcPi();
                MethodTicks += methodStopwatch.ElapsedTicks;
            }
        }

        private decimal CalcPi()
        {
            return 355 / 113;
        }
    }
}
