namespace Exceptions_February_29
{
    public class Exception1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please provide the first number");
                string? number = Console.ReadLine();
                int number1 = 0, number2 = 0;
                if (number != null)
                    number1 = int.Parse(number);
                Console.WriteLine("Please provide the second number");
                string? secondnumber = Console.ReadLine();
                if (secondnumber != null)
                    number2 = int.Parse(secondnumber);

                Console.WriteLine(number1 / number2);
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please provide the number in correct format");
                Console.WriteLine(fex.Message);
                Console.WriteLine(fex.StackTrace);

            }
            catch (DivideByZeroException dex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Donot proivde second number as 0");
                Console.WriteLine(dex.Message);
                Console.WriteLine(dex.StackTrace);


            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
