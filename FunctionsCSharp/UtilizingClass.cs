using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionsCSharp;

namespace FunctionsCSharp
{
    internal class UtilizingClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");

            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");

            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide any of the options +,-,*,/,%");
            char op = Console.ReadKey().KeyChar;

            Console.WriteLine();
            int result = 0;

            switch(op)
            {
                case '+':
                    result = MathsFormulaClass.sum(number1, number2);
                    break;

                case '-':
                    result = MathsFormulaClass.subtract(number1, number2);
                    break;
                case '*':
                    result = MathsFormulaClass.multiply(number1, number2);
                    break;
                case '/':
                    result = MathsFormulaClass.divide(number1, number2);
                    break;
                case '%':
                    result = MathsFormulaClass.modulo(number1, number2);
                    break;
                default:
                    Console.WriteLine("Wrong Option Selected");
                    break;
            }

            Console.WriteLine("Result of the Operation:" + result);
        }
    }
}
