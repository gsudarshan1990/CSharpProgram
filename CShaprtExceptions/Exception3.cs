using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
     class Exception3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number to divide 100:");

            try
            {
                int number1 = int.Parse(Console.ReadLine());

                int result = (100 / number1);

                Console.WriteLine("Result of 100/{0} : {1}", number1, result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide By Zero Excepiton " + e);
            }
            catch(InvalidOperationException e1)
            {
                Console.WriteLine("Invalid Operation Exception" + e1);
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Number Format Exception" + fe);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
