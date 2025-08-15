using System;

namespace ConstExamples
{
    class Program
    {
        // Class-level constants
        public const string ApplicationName = "My Calculator App";
        public const double PI = 3.14159;
        public const int MaxRetries = 3;
        private const string Version = "1.0.0";

        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Const Keyword Examples ===\n");

            // Using class-level constants
            Console.WriteLine("1. Class-Level Constants:");
            Console.WriteLine($"Application: {ApplicationName}");
            Console.WriteLine($"Version: {Version}");
            Console.WriteLine($"Max Retries: {MaxRetries}");
            Console.WriteLine();

            // Local constants
            Console.WriteLine("2. Local Constants:");
            const int daysInWeek = 7;
            const string greeting = "Hello World!";
            const bool isActive = true;

            Console.WriteLine($"Days in a week: {daysInWeek}");
            Console.WriteLine($"Greeting message: {greeting}");
            Console.WriteLine($"Is active: {isActive}");
            Console.WriteLine();

            // Using constants in calculations
            Console.WriteLine("3. Using Constants in Calculations:");
            double radius = 5.0;
            double area = CalculateCircleArea(radius);
            Console.WriteLine($"Circle with radius {radius} has area: {area:F2}");
            Console.WriteLine();

            // Constants vs variables demonstration
            Console.WriteLine("4. Constants vs Variables:");
            int variable = 10;
            const int constant = 20;
            
            Console.WriteLine($"Variable value: {variable}");
            Console.WriteLine($"Constant value: {constant}");
            
            variable = 15; // This works - variables can be changed
            Console.WriteLine($"Changed variable value: {variable}");
            
            // constant = 25; // This would cause a compile error!
            // Console.WriteLine("Cannot change constant value");
            
            Console.WriteLine("Note: Constants cannot be changed after declaration");
        }

        static double CalculateCircleArea(double radius)
        {
            return PI * radius * radius;
        }
    }
}
