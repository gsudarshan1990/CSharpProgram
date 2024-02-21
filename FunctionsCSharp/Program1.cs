using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCSharp
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            HelperClassSecond.DisplayMessage();
            Console.WriteLine(HelperClassSecond.AddNumbers(10, 12));
        }
    }
}
