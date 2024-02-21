using System;
using System.Threading;

namespace  Level1Thread
{
    class Program1
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoTask1);
            Thread t2 = new Thread(DoTask2);

            t1.Start();
            t2.Start();

            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"Main Thread :{i}");
                Thread.Sleep(1500);
            }

            t1.Join();
            t2.Join();
        }

        static void DoTask1()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread 1:{i}");
                Thread.Sleep(2000);
            }

        }

        static void DoTask2()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread 2:{i}");
                Thread.Sleep(3000);
            }

        }
    }
}