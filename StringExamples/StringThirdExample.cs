namespace StringExamples
{
    internal class StringThirdExample
    {
        static void Main(string[] args)
        {
            string first = "Rahul";
            string second = "Dravid";

            Console.WriteLine("Concatination using first+second: " + first + second);
            Console.WriteLine();
            Console.WriteLine("Concatination using string.contact(first+second): " + string.Concat(first + second));

            string Third = "Sachin";
            int age = 45;
            string text1 = "Hello" + Third + "Your age is" + age;
            Console.WriteLine(text1);
            Console.WriteLine();

            string text2 = string.Format("Hello {0} your age is {1}", Third, age);
            Console.WriteLine("Using the String Format {0}", text2);

            string text3 = $"Hello {Third} your age is {age}";
            Console.WriteLine($"Using String Interpolation {text3}");
        }
    }
}
