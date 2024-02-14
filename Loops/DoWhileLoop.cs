using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
     class DoWhileLoop
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number for while loop");
            string? stringValue1 = Console.ReadLine();
            int value = 0;
            if(stringValue1 != null)
                value = int.Parse(stringValue1);
            int i = 0;
            int sum = 0;
            do
            {
                sum = sum + i;
                i++;
            }while(i < value);
            Console.WriteLine("sum:" + sum);

            
        }
    }
}
