using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
     class ForLoop
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the Number");
            string? stringValue = Console.ReadLine();
            int startValue = 0;
            if (stringValue != null)
            {
                startValue = int.Parse(stringValue);
            }

            for(int i = startValue;i>0;i--)
            {
                sum += i;
            }

            Console.WriteLine("Sum:{0}", sum);
        }
    }
}
