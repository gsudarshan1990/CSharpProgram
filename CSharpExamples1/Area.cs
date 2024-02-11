using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples1
{
     class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of the Rectangle {0}", length * width);


        }
    }
}
