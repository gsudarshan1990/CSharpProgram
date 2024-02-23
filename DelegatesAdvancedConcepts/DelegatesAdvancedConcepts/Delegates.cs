namespace DelegatesAdvancedConcepts
{
    internal class Delegates
    {
        public static int sum(int a, int b)
        {
            return a + b;

        }

        public static int subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Func<int, int, int> calc = sum;
            int addresult = calc(10, 12);

            Console.WriteLine("Addition Result " + addresult);

            calc = subtract;
            Console.WriteLine("Subtract" + calc(12, 8));

            //Anonymous Function 

            Func<int> getRandomNumber = delegate ()
            {
                Random number = new Random();
                return number.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber());

            //Lambda Function 

            Func<int, int, int> Multiply = (a, b) => { return a * b; };
            Console.WriteLine(Multiply(10, 12));
        }
    }
}
