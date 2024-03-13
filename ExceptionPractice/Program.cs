// See https://aka.ms/new-console-template for more information
using ExceptionPractice;

Console.WriteLine("Hello, World!");


Console.WriteLine("Please provide some input");

string? input = Console.ReadLine();

InvalidInputException te = new InvalidInputException();

try
{
    if (input != null)
        te.method1(input);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}