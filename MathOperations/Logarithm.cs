using System;

namespace MathOperations
{
    public static class Logarithm
    {
        static public double Log(int baseNum, int antiLog)
        {
            return (Math.Log(antiLog, baseNum));
        }

        static public double Log(double baseNum, double antiLog)
        {
            return (Math.Log(antiLog, baseNum));
        }
    }
}