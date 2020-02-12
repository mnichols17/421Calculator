using System;
using basicCalculator;

namespace StatsCalculator
{
    public class StatsCalc : Calculator
    {
        public decimal Mean(decimal[] dataPoints)
        {
            decimal results = 0M;
            decimal l = dataPoints.Length;
            results = Divide(Add(dataPoints), l);

            return results;
        }
    }
}
