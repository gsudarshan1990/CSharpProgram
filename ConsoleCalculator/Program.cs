using ConsoleCalculator;
using static System.Console;

// Note: Additional input validation omitted for brevity

AppDomain appDomain = AppDomain.CurrentDomain;
appDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);


WriteLine("Enter first number");
int number1 = int.Parse(ReadLine()!);

WriteLine("Enter second number");
int number2 = int.Parse(ReadLine()!);

WriteLine("Enter operation");
string operation = ReadLine()!.ToUpperInvariant();

try
{
    var calculator = new Calculator();
    int result = calculator.Calculate(number1, number2, operation);
    DisplayResult(result);
}
catch (ArgumentNullException ex) when (ex.ParamName == "operation")
{
    WriteLine($"Operation is not valid {ex}");
}
catch (ArgumentNullException ae)
{
    WriteLine($"an argument was null {ae}");
}
catch (ArgumentOutOfRangeException are)
{
    WriteLine($"Sorry, something went wrong. {are}");
}
catch (Exception ex)
{
    WriteLine($"Sorry, something went wrong. {ex}");
}
finally
{
    WriteLine("...finally....");
}


WriteLine("\nPress enter to exit.");
ReadLine();

static void HandleException(object sender, UnhandledExceptionEventArgs e)
{
    WriteLine($"We cannot handle this exception {e.ExceptionObject}");
}

static void DisplayResult(int result) => WriteLine($"Result is: {result}");


