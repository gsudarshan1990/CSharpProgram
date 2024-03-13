namespace ExceptionPropogationandNonPropogationToStack
{
    public class ExceptionHandledClass
    {
        public void CallingFunction()
        {
            try
            {
                nullfunction();
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine("This Exception is handled in the Calling Function");
                Console.WriteLine(ae.Message);
                Console.WriteLine(ae.StackTrace);
            }
        }


        public void nullfunction()
        {
            throw new ArgumentNullException("This operator is null ");
        }

    }


}
