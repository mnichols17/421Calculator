using System;

namespace MathOperations
{
    public static class Exponentiation
    {
        static public double Power(int baseNum, int exponent)
        {
            return (Math.Pow(baseNum, exponent));
        }

        static public double Power(double baseNum, double exponent)
        {
            return (Math.Pow(baseNum, exponent));
        }
    }
}