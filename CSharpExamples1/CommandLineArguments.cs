using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples1
{
    class CommandLineArguments
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("No command line arguments provided");

            }
            else
            {
                Console.WriteLine("Command Line Arugments");
                for(int i=0;i<args.Length;i++)
                {
                    Console.WriteLine($" Argument {i + 1}:args[{i}]");
                }
            }
        }
    }
}
