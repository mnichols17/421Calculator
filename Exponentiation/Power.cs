using System;
using MathOperations;

namespace Exponentiation
{
    public class Power : IExponent
    {
        private dynamic Result;

        public dynamic Exponent(dynamic a, dynamic b)
        {
            Result = MathOperations.Exponentiation.Power(a, b);
            return Result;
        }
    }
}