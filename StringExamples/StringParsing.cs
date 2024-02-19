namespace StringExamples
{
    internal class StringParsing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Wage");
            string? input1 = Console.ReadLine();
            int wage = 0;
            if (int.TryParse(input1, out wage))
                Console.WriteLine("Parsing Worked:" + wage);
            else
                Console.WriteLine("Parsing Did Not Work");

            Console.WriteLine(wage);
        }
    }
}
