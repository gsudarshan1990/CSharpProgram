using System;

namespace Addition
{
    class Addition1
    {
        int num1, num2, sum;
        static void Main(string[] args)
        {

            Addition1 a = new Addition1();
            Console.WriteLine("Enter the first Number");
            a.num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            a.num2 = Convert.ToInt32(Console.ReadLine());

            a.sum = a.num1 + a.num2;

            Console.WriteLine($"Value After Addition is {a.sum}");
        }
    }
}
