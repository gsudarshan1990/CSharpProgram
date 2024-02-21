using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{

    
    class ImplementingArrayMethod
    {
        static int[] number = new int[] { 10, 25, 5, 15, 20 };

        static void Main(string[] args)
        {
            Console.WriteLine("Sorting");
            Array.Sort(number);

            foreach(var i in number)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Reverse");

            Array.Reverse(number);

            foreach (var i in number)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("FOREACH");
            Array.ForEach(number, n => Console.WriteLine(n * 2));


            Console.WriteLine();
            Console.WriteLine("Binary Search");

            Array.BinarySearch(number, 10);

        }
    }
}
