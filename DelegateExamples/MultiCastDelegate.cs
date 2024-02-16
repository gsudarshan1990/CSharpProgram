using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    public delegate void DelegateMethod(string msg); // Delegate
     public class MultiCastDelegate
    {
        public static DelegateMethod? DelegateMethodInstance1;
        public static DelegateMethod? DelegateMethodInstance2;
        public static DelegateMethod?  DelegateMethodInstance3;
        public static DelegateMethod? DelegateMethodInstance4;// Instance
        static void Main(string[] args)
        {
            DelegateMethodInstance1 = classC.Method1;
            DelegateMethodInstance2 = classD.Method2;
            DelegateMethodInstance3 = DelegateMethodInstance1 + DelegateMethodInstance2;

            Console.WriteLine("After DelegateMethodInstance1 + DelegateMethodInstance2 ");
            DelegateMethodInstance3(" Hello World!");

            DelegateMethodInstance4 = (string msg) =>
            {
                Console.WriteLine("From Lambda" + msg);
            };

            DelegateMethodInstance3+= DelegateMethodInstance4;
            Console.WriteLine("After DelegateMethodInstance1 + DelegateMethodInstance2 +DelegateInstance4");
            DelegateMethodInstance3(" Hello World");

            DelegateMethodInstance3 -= DelegateMethodInstance2;
            Console.WriteLine("After DelegateMethodInstance1 + DelegateMethodInstance2 +DelegateInstance4 -DelegateMethodInstance2");
            if(DelegateMethodInstance3 !=null)
                DelegateMethodInstance3(" Hello World");

        }
    }

    class classC
    {
        public static void Method1(string msg)
        {
            Console.WriteLine("From Class C and Method 1" + msg);
        }

    }

    class classD
    {
        public static void Method2(string msg)
        {
            Console.WriteLine("From Class D and Method 2" + msg);


        }

    }
}
