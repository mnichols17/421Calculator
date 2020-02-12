using System;

namespace MathOperations
{
    public static class Division
    {
        static public double Quotient(int dividend, int divisor)
        {
            return (dividend / divisor);
        }

        static public double Quotient(double dividend, double divisor)
        {
            return (dividend / divisor);
        }

        static public double Quotient(int[] doubleArray)
        {
            double result = 0;

            for (var i = 0; i < doubleArray.Length; i++)
            {
                if (i > 1)
                {
                    result = Quotient(result, doubleArray[i]);
                }
                else
                {
                    result = Quotient(doubleArray[0], doubleArray[1]);
                }
            }

            return result;
        }

        static public double Quotient(double[] doubleArray)
        {
            double result = 0;

            for (var i = 0; i < doubleArray.Length; i++)
            {
                if (i > 1)
                {
                    result = Quotient(result, doubleArray[i]);
                }
                else
                {
                    result = Quotient(doubleArray[0], doubleArray[1]);
                }
            }

            return result;
        }
    }
}