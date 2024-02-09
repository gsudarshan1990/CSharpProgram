// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoTask1);
            Thread t2 = new Thread(DoTask2);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }

        static void DoTask1()
        {
            Console.WriteLine("This is Thread 1");

            Thread.Sleep(3000);
        }

        static void DoTask2()
        {
            Console.WriteLine("This is Thread 2");

            Thread.Sleep(2000);
        }
    }
}