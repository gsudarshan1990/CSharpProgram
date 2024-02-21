using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Using the Exception Class
namespace Exceptions
{
     class Example2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1");

            int number1 = 0;

            try
            {
                number1 = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message:" + ex.Message);
            }
            finally
            {
                             Console.WriteLine($"Square is {number1 * number1}");
                
            }
        }
    }
}
