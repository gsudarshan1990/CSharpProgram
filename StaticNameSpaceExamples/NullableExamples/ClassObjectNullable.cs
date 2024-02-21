namespace StaticNameSpaceExamples.NullableExamples
{
    internal class ClassObjectNullable
    {
        static void Main(string[] args)
        {
            string mystring = "Hello C#";
            Console.WriteLine("Original String " + mystring);

            mystring = null;

            if (mystring == null)
            {
                Console.WriteLine("String is Null");
            }
            else
            {
                Console.WriteLine("String is not Null");
            }
        }

    }
}
