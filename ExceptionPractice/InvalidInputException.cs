namespace ExceptionPractice
{
    public class InvalidException : Exception
    {
        private const string DefaultMessage = "Provided Input should be with in the valid range";

        public InvalidException() : base(DefaultMessage) { }
    }
}
