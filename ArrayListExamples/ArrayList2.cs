using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListAndListExamples
{
     class ArrayList2
    {
        static void Main(string[] args)
        {
            var arlist1 = new ArrayList();

            var arlist2 = new ArrayList()
            {
                "Hello", 2, 4.5, true, null
            };

            int[] arr = new int[] { 2, 4, 6, 8, 10 };

            Queue myq = new Queue();
            myq.Enqueue("10");
            myq.Enqueue("Hello");

            arlist1.AddRange(arlist2);
            arlist1.AddRange(arr);
            arlist1.AddRange(myq);

            for(int i = 0;i<arlist1.Count;i++)
            {
                Console.WriteLine(arlist1[i]);
            }
        }
    }
}
