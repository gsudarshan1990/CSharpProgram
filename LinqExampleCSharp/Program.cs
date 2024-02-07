// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace LinqExample
{
    class  Linq1
    {
        static void Main(String[] args)
        {
            List<int> numbers = new List<int>();

            for(int i=0;i<50;i++)
            {
                numbers.Add(i);
            }

            var result = numbers.Where(n => n%2 ==0).Select(n => n*3).ToList();

            Console.WriteLine("Collecting the Even numbers and Multiplying By 3");

            foreach(int i in result) 
                Console.WriteLine(i);
        }
    }
}
