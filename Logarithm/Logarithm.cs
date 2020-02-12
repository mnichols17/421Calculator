using System;
using MathOperations;

namespace Logarithm
{
    public class Log : ILog
    {
        private dynamic Result;

        public dynamic Logarithm(dynamic a, dynamic b)
        {
            Result = MathOperations.Logarithm.Log(a, b);
            return Result;
        }
    }
}