using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCSharp
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodOverLoadingClass.sum(10, 2));
            Console.WriteLine(MethodOverLoadingClass.sum(10, 2, 3));
        }
    }
}
