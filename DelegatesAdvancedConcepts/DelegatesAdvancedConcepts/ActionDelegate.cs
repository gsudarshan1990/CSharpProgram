namespace DelegatesAdvancedConcepts
{
    internal class ActionDelegate
    {
        public static void Square(int a)
        {
            Console.WriteLine(Math.Pow(a, 2));
        }

        public static void Squareroot(int number)
        {
            Console.WriteLine(Math.Sqrt(number));
        }

        static void Main(string[] args)
        {
            Action<int> operation = Square;

            operation(4);

            operation = Squareroot;

            operation(256);


            //Anonymous function 

            operation = delegate (int a) { Console.WriteLine(a); };

            operation(10);

            //Lambda Function 

            operation = (a) => { Console.WriteLine(Math.Abs(a)); };

            operation(-20);

        }
    }
}
