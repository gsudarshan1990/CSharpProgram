namespace ConsoleCalculator;

public class Calculator
{
    public int Calculate(int number1, int number2, string operation)
    {
        //if (operation == null)
        //{
        //    throw new ArgumentNullException(nameof(operation));
        //}

        // throw new ArgumentNullException(nameof(operation));

        //throw new ArgumentNullException(nameof(number1));

        string notnulloperation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (notnulloperation == "/")
        {
            try
            {
                return Divide(number1, number2);
            }
            catch (Exception e)
            {
                throw new CalculationException(e);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("...logging...");
            //    throw new ArithmeticException("An error occured during calcuation ", ex);


            //}

        }
        else
        {
            throw new CalculationOperationNotSupported(operation);
        }
        //{
        //    Console.WriteLine("Unknown operation.");
        //    return 0;

        //    throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported");
        //}
    }

    private int Divide(int number, int divisor) => number / divisor;
}

