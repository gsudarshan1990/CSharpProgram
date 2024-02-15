using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
     class Example1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number1 = 0;
            try
            {
                 number1 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter the number");
            }
            finally 
            {
                Console.WriteLine("Program is Ended");
            }

            Console.WriteLine($"Square of {number1} is {number1 * number1}");



        }
    }
}
