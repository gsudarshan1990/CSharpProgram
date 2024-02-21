using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
     class NestedTryCatch
    {
        static void Main(string[] args)
        {
            var divider = 0;
            int number1 = 0;

            try
            {
                try
                {
                    number1 = 100 / divider;

                }
                catch
                {
                    Console.WriteLine("Inner Exception");
                }
            }
            catch
            {
                Console.WriteLine("Outer Exception");
            }
        }
    }
}
