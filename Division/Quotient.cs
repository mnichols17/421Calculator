using System;
using MathOperations;

namespace Division
{
    public class Quotient : IDivide
    {
        private dynamic Result;

        public dynamic Divide(dynamic a, dynamic b)
        {
            Result = MathOperations.Division.Quotient(a, b);
            return Result;
        }

        public dynamic Divide(dynamic arrayList)
        {
            Result = MathOperations.Division.Quotient(arrayList);
            return Result;
        }
    }
}