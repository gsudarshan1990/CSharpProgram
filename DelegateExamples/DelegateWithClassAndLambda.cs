using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    //Creation of the Delegate
    public delegate void MyDelegate(string msg);
     class DelegateWithClassAndLambda
    {
        //Creating the Instance for delegate
        static MyDelegate delegateInstance;
        static void Main(string[] args)
        {
            delegateInstance = classA.MethodA;
            delegateInstance("Hello, Invoking Delegate using class A"); //Calling Delegate

            delegateInstance = classB.MethodB; //Assigning
            delegateInstance("Hello, Invoking Delegate using ClassB"); //Calling Delegate

            delegateInstance = (string msg) => //Lambda
            {
                Console.WriteLine("Invoking Delegate using the Lambda");
                Console.WriteLine(msg);
            };

            delegateInstance("Hello Lambda!"); //Calling

        }
    }

    class classA
    {
        //Reference Method For Delegate
        public static void MethodA(string msg)
        {
            Console.WriteLine("From MethodA of Class A");
            Console.WriteLine(msg);
        }
    }

    class classB
    {
        //Reference Method For Delegate
        public static void MethodB(string msg)
        {
            Console.WriteLine("From MethodB of Class B");
            Console.WriteLine(msg);
        }
    }
}
