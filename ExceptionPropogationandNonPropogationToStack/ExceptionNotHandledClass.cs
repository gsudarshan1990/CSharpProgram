namespace ExceptionPropogationandNonPropogationToStack
{
    public class ExceptionNotHandledClass
    {
        public void callingfunction()
        {
            try
            {
                function2();
            }
            catch (ArgumentNullException ae)
            {
                throw;
            }
        }

        void function2()
        {
            throw new ArgumentNullException("This Operator is null");
        }
    }
}
