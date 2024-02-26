namespace Exceptions_February_29
{
    public static class Utilities
    {
        public static int DivideValues(string input1, string input2)
        {
            try
            {
                int value1 = int.Parse(input1);
                int value2 = int.Parse(input2);

                int result = value1 / value2;
                return result;

            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The entered value was not an integer!");
                Console.WriteLine(fex.Message);
                return -1;
            }
            catch (DivideByZeroException dex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dividing by zero is not possible!");
                Console.WriteLine(dex.Message);
                return -2;
            }
            catch (Exception ex)
            {
                return -3;
            }
            finally
            {
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string? number1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string? number2 = Console.ReadLine();

            int result = 0;
            if (number1 != null && number2 != null)
                result = Utilities.DivideValues(number1, number2);
            Console.WriteLine(result);

        }
    }
}
