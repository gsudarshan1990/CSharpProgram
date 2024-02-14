using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    
    class WhileLoopExample1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            string? stringValue = Console.ReadLine();
            int max = 0;
            if (stringValue != null)
            {
                max = int.Parse(stringValue);
            }
            int i = 0;
            while(i<max)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
