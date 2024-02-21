using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{

    class ForEach
    {


        static int[] evenNum = new int[5] { 2, 4, 6, 8, 10 };

        static string[] cities = new string[3] { "London", "New York", "Delhi" };

        static void Main(string[] args)
        {
            foreach(var i in evenNum)
            {
                Console.WriteLine(i);
            }

            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
