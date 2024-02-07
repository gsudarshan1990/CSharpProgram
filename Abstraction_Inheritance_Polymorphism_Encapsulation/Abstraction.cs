// See https://aka.ms/new-console-template for more information

using System;

namespace Abstraction
{
    abstract class Shape  //Abstract Class Representing the Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape //Concrete Class Representing the Circle
    {
        public override void Draw()
        {
            Console.WriteLine("This Function Draws the Circle");
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Shape s = new Circle();
            s.Draw(); //Calls the Overriden Method

        }
    }
}
