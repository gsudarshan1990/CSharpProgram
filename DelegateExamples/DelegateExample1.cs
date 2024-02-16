using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
   

     class DelegateExample1
    {
        public delegate void TestDelegate();

        private static TestDelegate TestDelegateInstance;
        static void Main(string[] args)
        {
            TestDelegateInstance = MyTestFunction;
            TestDelegateInstance();

        }

        static void MyTestFunction()
        {
            Console.WriteLine("This is the Test Delegate Method");
        }
    }
}
