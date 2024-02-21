using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionsCSharp;

namespace FunctionsCSharp
{
     class FunctionImplementation
    {
        static void Main(string[] args)
        {
            int wage_amount = 1234;
            int months_worked = 12;

            CalculateWage(wage_amount, months_worked); //Without Return Type calling Function

            int totalwage = CalculateWageSecond(wage_amount, months_worked);//With Return Type calling Function
            Console.WriteLine(totalwage);

            int totalWageWithBonus = HelperClassFunction.CalculateWageWithBonus(wage_amount, months_worked);
            Console.WriteLine(totalWageWithBonus);
        }

        static void CalculateWage(int a, int b)
        {
            Console.WriteLine("Total Wage {0}", a * b);
        }

        static int CalculateWageSecond(int a, int b)
        {
            return a * b;
        }

    }
}
