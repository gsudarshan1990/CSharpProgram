using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    
    class WhileExample2
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;

            while(i<=10)
            {
                while(j<=10)
                {
                    Console.WriteLine("i:" + i + " " + "j:" + j);
                    j++;
                }
                j = 0;
                i++;
            }
        }
    }
}
