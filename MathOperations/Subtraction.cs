using System;

namespace MathOperations
{
    public static class Subtraction
    {
        static public int Difference(int termA, int termB)
        {
            return (termA - termB);
        }

        static public decimal Difference(decimal termA, decimal termB)
        {
            return (termA - termB);
        }

        static public int Difference(int[] doubleArray)
        {
            int result = doubleArray[0];

            for (var i = 1; i < doubleArray.Length; i++)
            {
                result = Difference(result, doubleArray[i]);
            }

            return result;
        }

        static public decimal Difference(decimal[] doubleArray)
        {
            decimal result = doubleArray[0];

            for(var i = 1; i < doubleArray.Length; i++)
            {
                result = Difference(result, doubleArray[i]);
            }

            return result;
        }
    }
}