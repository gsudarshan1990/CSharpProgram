namespace StaticNameSpaceExamples.ExternalLibrary
{
    internal class MathematicsOperationExternalLibrary
    {
        public static class MathematicsOperation
        {
            static int Add(int a, int b)
            {
                return a + b;
            }
            static int Multiply(int a, int b)
            {
                return a * b;
            }

            static double power(int a, int b)
            {
                return Math.Pow(a, b);
            }

        }
    }
}
