namespace StringExamples
{
    internal class StringSecondExample
    {
        static void Main(string[] args)
        {
            string first = "hello";
            Console.WriteLine("String Length: " + first.Length);

            string second = "HELLO";
            Console.WriteLine("To Lower: " + second.ToLower());

            string third = "world!";
            Console.WriteLine("To Upper: " + third.ToUpper());

            string fourth = "What do you know about me";

            bool result = fourth.Contains("do you know");

            string fifth = third.Replace('w', 'W');

            Console.WriteLine("After Replacing " + fifth);

            Console.WriteLine("Substring: " + fourth.Substring(2, 5));
        }
    }
}
