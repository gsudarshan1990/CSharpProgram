using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCSharp
{
    internal class MethodOverLoadingClass
    {
        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int sum(int a,int b, int c)
        {
            return a + b + c;
        }
    }
}
