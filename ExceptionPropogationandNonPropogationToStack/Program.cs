// See https://aka.ms/new-console-template for more information
using ExceptionPropogationandNonPropogationToStack;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Hello, World!");

ExceptionHandledClass exceptionHandledClass = new ExceptionHandledClass();
try
{
    exceptionHandledClass.CallingFunction();
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}

ExceptionNotHandledClass exceptionNotHandledClass = new ExceptionNotHandledClass();

try
{
    exceptionNotHandledClass.callingfunction();
}
catch (Exception e)
{
    Console.WriteLine("=============");

    Console.WriteLine(e.Message);

    Console.WriteLine(e.StackTrace);
}

Console.ResetColor();