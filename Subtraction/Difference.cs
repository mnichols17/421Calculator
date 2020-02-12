using System;
using MathOperations;

namespace Subtraction
{

    public class Difference : ISubtract
    {
        private dynamic Result;

        public dynamic Subtract(dynamic a, dynamic b)
        {
            Result = MathOperations.Subtraction.Difference(a, b);
            return Result;
        }

        public dynamic Subtract(dynamic arrayList)
        {
            Result = MathOperations.Subtraction.Difference(arrayList);
            return Result;
        }
    }
}
