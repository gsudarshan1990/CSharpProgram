using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAndListExamples
{
     class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<int> mq = new Queue<int>();
            mq.Enqueue(1);
            mq.Enqueue(2);
            mq.Enqueue(3);
            mq.Enqueue(4);

            foreach(var item in mq)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            Queue<string> queue2 = new Queue<string>();
            queue2.Enqueue("Hello");
            queue2.Enqueue("World");
            queue2.Enqueue("Who am I");
            queue2.Enqueue("How are you");

            foreach (var item in queue2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue2.Count);


            Console.WriteLine("Implementing Dequeu");

            Console.WriteLine("Before Dequeue{0}",mq.Count);
            while (mq.Count > 0)
            {
                mq.Dequeue();
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(mq.Count);

            if(queue2.Count >0)
            {
                Console.WriteLine(queue2.Peek());
            }
        }
    }
}
