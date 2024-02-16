using CustomExcepitionsNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{

    class CustomException : Exception
    {
        public CustomException() { }

        public CustomException(string msg) : base(msg)
        {

        }
        public CustomException(string msg, Exception innerMessage) : base(msg, innerMessage)
        {

        }

    }

    class CustomExceptionsExample
    {
        static void Main(string[] args)
        {
            try
            {
                TryCustomException();
            }
            catch (CustomException ex)
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
