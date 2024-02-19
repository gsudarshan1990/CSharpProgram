namespace StringExamples
{
    internal class StringExample5
    {
        static void Main(string[] args)
        {
            string firstName = "rahul";
            string secondName = "Rahul";

            Console.WriteLine(firstName == secondName);
            Console.WriteLine(firstName.Equals("rahul"));
            Console.WriteLine(secondName.Equals("Rahul"));
            Console.WriteLine(firstName.ToLower() == secondName.ToLower());
        }
    }
}
