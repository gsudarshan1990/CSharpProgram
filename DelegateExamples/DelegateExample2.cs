using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{

     class DelegateExample2
    {
        public delegate void secondTestDelegate(string msg);

        public static secondTestDelegate secondTestDelegateinstance;
        static void Main(string[] args)
        {
            secondTestDelegateinstance = MyDelegateMethod;
            secondTestDelegateinstance.Invoke("Hello From Delegate Invoke Method");
        }

        static void MyDelegateMethod(string msg)
        {
            Console.WriteLine("This is the message " + msg);
        }
    }
}
