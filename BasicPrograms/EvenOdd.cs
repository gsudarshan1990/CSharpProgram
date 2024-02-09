using System;


namespace BasicPrograms
{
     class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check for even or odd");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if(num1 %2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
