using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples1
{
     class NestedIfExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age of the Person");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 12)
            {
                Console.WriteLine("Please Let us know whether you have permission (1 or 0) with 1 indicating yes and 0 indicating no");
                int permission = Convert.ToInt32(Console.ReadLine());

                if (permission == 1)
                {
                    Console.WriteLine("Person has permission");
                }
                else if (permission == 0)
                {
                    Console.WriteLine("Person do not have permission");
                }
                else
                {
                    Console.WriteLine("Entered Option is wrong");
                }
            }
            else
            {
                Console.WriteLine("Age should be more than 12");
            }
        }
    }
}
