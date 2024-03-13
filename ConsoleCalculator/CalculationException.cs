namespace ConsoleCalculator
{
    //Created a class name 
    // Class name extends the Exception Base class
    public class CalculationException : Exception
    {
        //Created a default message
        private const string DefaultMessage = "An error occured on the calculation. Please enter the apporpriate operation and the values should be within the expected range";

        //Default Constructor
        public CalculationException() : base(DefaultMessage) { }

        //one parameter constructor and the parameter is message
        public CalculationException(string message) : base(message) { }

        //Two parameter constructor and the parameter is Inner Exception

        public CalculationException(Exception innerexception) : base(DefaultMessage, innerexception) { }

        //Two parameter constructor and the parameter is message and inner exception

        public CalculationException(string message, Exception innerexception) : base(message, innerexception) { }
    }
}
