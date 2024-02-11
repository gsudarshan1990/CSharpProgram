// See https://aka.ms/new-console-template for more information
using System;


namespace ForExample
{
    class Program1
    {
        static void Main(string[] args)
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Iteration {0},{1}", i, i * 5);
            }
        }
    }
}

