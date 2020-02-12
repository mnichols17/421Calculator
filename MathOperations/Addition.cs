using System;

namespace MathOperations
{
    public static class Addition
    {
        static public int Sum(int termA, int termB)
        {
            return (termA + termB);
        }
        static public decimal Sum(decimal termA, decimal termB)
        {
            return (termA + termB);
        }

        static public int Sum(int[] doubleArray)
        {
            int result = 0;

            foreach (var x in doubleArray)
            {
                result = Sum(result, x);
            }

            return result;
        }

        static public decimal Sum(decimal[] doubleArray)
        {
            decimal result = 0;

            foreach (var x in doubleArray)
            {
                result = Sum(result, x);
            }

            return result;
        }
    }
}