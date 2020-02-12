using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplication
{
    public interface IMultiply
    {
        dynamic Multiply(dynamic a, dynamic b);
        dynamic Multiply(dynamic arrayList);

    }
}