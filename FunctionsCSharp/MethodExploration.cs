using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCSharp
{
    internal class MethodExploration
    {

        public int sum(int a, int b, int c = 100)
        {
            return a + b + c;
        }

        public int difference(int first, int second) => second - first;

    static void Main(string[] args)
        {
            MethodExploration me = new MethodExploration();
            Console.WriteLine("Using the Default Parameter");
            Console.WriteLine(me.sum(10,12));
            Console.WriteLine("Using the Named Parameters");
            Console.WriteLine(me.sum(b: 12, c: 9, a: 12));
            Console.WriteLine("Using Boiled Expresstion" + me.difference(102, 8));
        }
    }
}
