namespace StaticNameSpaceExamples.NullableExamples
{
    internal class NullableValueType
    {
        static void Main(string[] args)
        {
            int? value = 15;
            Console.WriteLine("Original Value" + value);

            value = null;

            if (value.HasValue)
            {
                Console.WriteLine("Value is Null");
            }
            else
            {
                Console.WriteLine("Value is not Null");
            }
        }
    }
}
