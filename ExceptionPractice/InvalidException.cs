namespace ExceptionPractice
{
    internal class InvalidInputException
    {
        public void method1(string operation)
        {
            if (operation == "+")
                throw new InvalidException();

        }
    }
}
