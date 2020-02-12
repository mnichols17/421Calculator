using System;
using MathOperations;

namespace Root
{
    public class Root : IRoot
    {
        private dynamic Result;

        public dynamic ansRoot(dynamic a, dynamic b)
        {
            Result = MathOperations.Root.rootAns(a, b);
            return Result;
        }
    }
}
