using System;

namespace MathOperations
{
    public static class Root
    {
        static public double rootAns(double radicant, double degree)
        { 
            return (Math.Pow(radicant, 1/degree));
        }
    }
}