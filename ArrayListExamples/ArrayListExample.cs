using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAndListExamples
{
     class ListExample
    {
        static void Main(string[] args)
        {
            var arlist1 = new ArrayList();

            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);


            Console.WriteLine("First Array");
            for (int i = 0; i < arlist1.Count; i++)
            {
                Console.Write(arlist1[i] + ",");
            }

            var arlist2 = new ArrayList()
{
    2,"Hello","World",3
};

            Console.WriteLine();



            Console.WriteLine("Second Array");
            for (int i = 0; i < arlist2.Count; i++)
            {
                Console.Write(arlist2[i] + ",");
            }

        }
    }
}
