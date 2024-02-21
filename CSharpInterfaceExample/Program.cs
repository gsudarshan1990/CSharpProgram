// See https://aka.ms/new-console-template for more information
using System;

namespace InterfaceExample
{
    interface IDrawable
    {
        void draw();
    }

    interface IResizable
    {
        void percentage(int percentage);
    }


    class Shape: IResizable, IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing the Shape");
        }

        public void percentage(int percentage)
        {
            Console.WriteLine($"Resizing the Shape by {percentage}");
        }
    }


    class Program
    {
        static void Main(string[] args) 
        {
            Shape s = new Shape();

            s.draw();
            s.percentage(300);

            Console.ReadLine();
        }
    }
}