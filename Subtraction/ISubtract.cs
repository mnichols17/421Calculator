using System;
using System.Collections.Generic;
using System.Text;

namespace Subtraction
{
    public interface ISubtract
    {
        dynamic Subtract(dynamic a, dynamic b);
        dynamic Subtract(dynamic arrayList);
    }
}