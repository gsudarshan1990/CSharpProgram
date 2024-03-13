namespace ConsoleCalculator
{
    //Class extending the custom exception
    public class CalculationOperationNotSupported : CalculationException
    {
        //Default Message
        private const string DefaultMessage = "Provided Operation is out of the range of valid values";

        public string Operation { get; }

        //Default Constructor
        public CalculationOperationNotSupported() : base(DefaultMessage) { }

        //One Parameter Constructor

        public CalculationOperationNotSupported(Exception innerexception) : base(DefaultMessage, innerexception) { }

        //Two Parameter Constructor

        public CalculationOperationNotSupported(string message, Exception innerexception) : base(message, innerexception) { }

        //Creating a constructor with operation parameter and setting its value
        public CalculationOperationNotSupported(string operation) : this() => Operation = operation;

        //creating a constructor with operation parater and message 
        public CalculationOperationNotSupported(string message, string operation) : base(message) => Operation = operation;


        public override string Message
        {
            get
            {
                if (Operation == null)
                {
                    return base.Message;
                }

                return base.Message + Environment.NewLine +
                    $"Unsupported Operation :{Operation}";
            }
        }
    }
}