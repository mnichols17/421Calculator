using System;
using System.Collections.Generic;
using System.Text;

namespace Addition
{
    public interface IAdd
    {
        dynamic Add(dynamic a, dynamic b);
        dynamic Add(dynamic arrayList);

    }
}