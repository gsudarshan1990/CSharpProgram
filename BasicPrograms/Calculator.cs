using System;


namespace BasicPrograms
{
     class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Any one of the following options (+,-,*,/)");
            char op = Convert.ToChar(Console.ReadKey().KeyChar);

            double result = 0;

            switch(op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot Divide by Zero");
                    }
                    break;
                default:
                    Console.WriteLine("Provided An invalid Option");
                    return;
            }
            Console.WriteLine();
            Console.WriteLine($"Result:{result}");


        }

    }
}
