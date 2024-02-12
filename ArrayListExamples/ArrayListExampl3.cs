using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListAndListExamples
{
     class ArrayListExampl3
    {
        static void Main(string[] args)
        {
            var arlist1 = new ArrayList() { 1, 4.5, null, true, "Hello", 2, "World" };

            arlist1.Insert(1, 12);

      

            var arlist2 = new ArrayList() { "Example", "Error", "Exception" };

            arlist1.InsertRange(5, arlist2);

            foreach (var item in arlist1)
            {
                Console.WriteLine(item);
            }


            var value1 = arlist2[0];

            var value2 = arlist1[1];

            arlist1.Add(10);
            arlist1[5] = value1;

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in arlist1)
            {
                Console.WriteLine(item);
            }

            arlist1.Remove(value2);


            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in arlist1)
            {
                Console.WriteLine(item);
            }


            arlist1.RemoveAt(4);
            arlist1.RemoveRange(3, 2);


            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in arlist1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(arlist2.Contains("Example"));
        }
    }
}
