using System;

namespace CustomExcepitionsNamespace
{
    class CustomException : Exception
    {
        public CustomException() { }
        
        public CustomException(string msg): base(msg)
        {

        }
        public CustomException(string msg, Exception innerMessage) : base(msg, innerMessage)
        {

        }

    }

    class ExceptionProgram
    {
        static void Main(string[] args)
        {
            try
            {
                TryCustomException();
            }
            catch(CustomException ex)
            {
                Console.WriteLine($"Custom Exception is Caught :{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Generic Exception is Caught :{ex.Message}");
            }
        }

        static void TryCustomException()
        {
            throw new CustomException("This is a Custom Exception");
        }
    }
}

