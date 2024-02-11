using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples1
{
     class IfelseProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age of the Person");
            int age = Convert.ToInt32(Console.ReadLine());

            if( age > 18)
            {
                Console.WriteLine("Person is Eligible for Vote");
            }
            else
            {
                Console.WriteLine("Person is not eligible for Vote");
            }
        }
    }
}
