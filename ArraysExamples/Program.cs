// See https://aka.ms/new-console-template for more information
using System;


class ArrayExample
{

    static int[] evenNum = new int[5] { 2, 4, 6, 8, 10 };

    static string[] cities = new string[3] {"London","New York","Delhi"};
    static void Main(string[] args)
    {
        for(int i =0;i<evenNum.Length;i++)
        {
            Console.WriteLine("Iteration {0}: {1}", i, evenNum[i]);
        }

        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine("Iteration {0}:{1}", i, cities[i]);
        }

    }
}
