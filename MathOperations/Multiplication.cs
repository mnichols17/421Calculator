using System;

namespace MathOperations
{
    public static class Multiplication
    {
        static public int Product(int factorA, int factorB)
        {
            return (factorA * factorB);
        }

        static public decimal Product(decimal factorA, decimal factorB)
        {
            return (factorA * factorB);
        }

        static public int Product(int[] doubleArray)
        {
            int result = 0;

            for (var i = 0; i < doubleArray.Length; i++)
            {
                if(i > 1)
                {
                    result = Product(result, doubleArray[i]);
                }
                else
                {
                    result = Product(doubleArray[0], doubleArray[1]);
                }
            }

            return result;
        }

        static public decimal Product(decimal[] doubleArray)
        {
            decimal result = 0;

            for (var i = 0; i < doubleArray.Length; i++)
            {
                if (i > 1)
                {
                    result = Product(result, doubleArray[i]);
                }
                else
                {
                    result = Product(doubleArray[0], doubleArray[1]);
                }
            }

            return result;
        }
    }
}