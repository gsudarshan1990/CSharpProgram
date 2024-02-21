using System;

namespace ExternalLibrarySecond
{
    public class Mathematics
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }


        public static double Power(int a, int b)
        {
            return Math.Pow(a, b);
        }
    }
}
