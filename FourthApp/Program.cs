// See https://aka.ms/new-console-template for more information
using System;

namespace FunctionExample
{
    class Function
    {
        static void Method()
        {
            Console.WriteLine("This is executing from the Method");
        }

        static void Method2()
        {
            Console.WriteLine("This is executing from the Method2");
        }

        static void Method3()
        {
            Console.WriteLine("This is executing from the Method3");
        }

        static void Main(String[] args)
        {

            Method();
            Method2();
            Method3();
        }
      
    }
}
