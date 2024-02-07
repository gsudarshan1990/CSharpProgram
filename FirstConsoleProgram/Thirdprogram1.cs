// See https://aka.ms/new-console-template for more information
using System;

namespace ThirdProgram
{
    class Program
    {
        static void Main(String[] args)
        {
            const int myNum = 15;

            String name = "John";
            Console.WriteLine("Hello" + name);

            String firstname = "John";
            String secondname = "Doe";
            String fullName = firstname + secondname;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 7;

            Console.WriteLine(x + y);
            int sum = x + y;
            int z = 12;
            Console.WriteLine(sum + z);
        }
    }
}
