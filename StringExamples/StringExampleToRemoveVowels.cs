namespace StringExamples
{


    class StringExampleToRemoveVowels
    {
        public static string RemoveVowels(string input)
        {
            string newString = string.Empty;
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                char c = input[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
                {
                    continue;
                }
                else
                {
                    newString += c;
                }
            }
            return newString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide some input");
            string input = Console.ReadLine();
            RemoveVowels(input);
        }
    }
}
