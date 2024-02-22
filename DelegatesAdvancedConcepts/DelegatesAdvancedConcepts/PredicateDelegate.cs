namespace DelegatesAdvancedConcepts
{

    class Numbers
    {
        public int a;
        public int b;

        public Numbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A
        {
            get { return a; }
        }

        public int B
        {
            get { return b; }
        }

    }
    internal class PredicateDelegate
    {

        public static bool greater(Numbers c)
        {
            bool result = Math.Abs(c.A) > Math.Abs(c.B);
            return result;

        }

        public static bool module(Numbers d)
        {
            int c = ((d.A) % (d.B));
            if (c == 0)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Predicate<Numbers> number = greater;
            bool result = number(new Numbers(10, -8));
            Console.WriteLine(result);

            number = module;
            result = module(new Numbers(100, 5));
            Console.WriteLine(result);

            Numbers one = new Numbers(10, 10);
            number = (one) =>
            {
                if (one.a == one.b)
                    return true;
                return false;
            };

            Numbers Two = new Numbers(100, 10);
            Predicate<Numbers> number2 = delegate (Numbers s)
            {
                int D = s.b * s.b;
                if (s.a == D)
                    return true;
                return false;


            };

            Console.WriteLine(number2(Two));
        }
    }
}
