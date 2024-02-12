using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{
   
      class ArrayLinq
    {
        static int[] numbers = new int[5] { 2, 4, 6, 8, 10 };

        static void Main(string[] args)
        {
            Console.WriteLine("Maximum:{0}",numbers.Max());
            Console.WriteLine("Minimum:{0}", numbers.Min());
            Console.WriteLine("Sum:{0}", numbers.Sum());
            Console.WriteLine("Average:{0}", numbers.Average());
        }

    }
}
