using System;
using MathOperations;
using Addition;
using Subtraction;
using Multiplication;
using Division;
using Exponentiation;
using Logarithm;
using Root;

namespace basicCalculator
{
    public class Calculator : IAdd, ISubtract, IMultiply, IDivide, IExponent
    {
        private dynamic _result;

        public dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Sum Addition = new Sum();
        Difference Subtraction = new Difference();
        Product Multiplication = new Product();
        Quotient Division = new Quotient();
        Power Exponentiation = new Power();
        Log Logarithm = new Log();
        Root.Root ansRoot = new Root.Root();
        
        public dynamic Add(dynamic a, dynamic b)
        {
            Result = Addition.Add(a, b);
            return Result;
        }

        public dynamic Add(dynamic arrayList)
        {
            Result = Addition.Add(arrayList);
            return Result;
        }

        public dynamic Subtract(dynamic a, dynamic b)
        {
            Result = Subtraction.Subtract(a, b);
            return Result;
        }

        public dynamic Subtract(dynamic arrayList)
        {
            Result = Subtraction.Subtract(arrayList);
            return Result;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            Result = Multiplication.Multiply(a, b);
            return Result;
        }

        public dynamic Multiply(dynamic arrayList)
        {
            Result = Multiplication.Multiply(arrayList);
            return Result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            Result = Division.Divide(a, b);
            return Result;
        }

        public dynamic Divide(dynamic arrayList)
        {
            Result = Division.Divide(arrayList);
            return Result;
        }

        public dynamic Exponent(dynamic a, dynamic b)
        {
            Result = Exponentiation.Exponent(a, b);
            return Result;
        }

        public dynamic Root(dynamic a, dynamic b)
        {
            Result = ansRoot.ansRoot(a, b);
            return Result;
        }

        public dynamic Log(dynamic a, dynamic b)
        {
            Result = Logarithm.Logarithm(a, b);
            return Result;
        }
    }
}