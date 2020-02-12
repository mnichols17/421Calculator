using System;
using MathOperations;

namespace Multiplication
{
    public class Product : IMultiply
    {
        private dynamic Result;

        public dynamic Multiply(dynamic a, dynamic b)
        {
            Result = MathOperations.Multiplication.Product(a, b);
            return Result;
        }

        public dynamic Multiply(dynamic arrayList)
        {
            Result = MathOperations.Multiplication.Product(arrayList);
            return Result;
        }
    }
}
