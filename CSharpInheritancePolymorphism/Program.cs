// See https://aka.ms/new-console-template for more information
using System;

namespace OOPSConcepts
{
    class Shape
    {
        public Shape() { }
        public virtual void display()
        {
            Console.WriteLine("This is a generic shape");
        }

        public virtual double calculateArea()
        {
            return 0.0D;
        }
    }

    class Circle : Shape 
    {
        private double radius;

        public Circle(double radius)
        {
           this.radius= radius;
        }

        public override void display()
        {
            Console.WriteLine($"This is a circle shape with radius {radius}");
        }

        public override double calculateArea()
        {
            return Math.PI * radius * radius;
        }
    }


    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length= length;
            this.width= width;
        }

        public override void display()
        {
            Console.WriteLine($"This is a rectangle with length :{length} and width:{width}");
        }


        public override double calculateArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[3];
            shape[0] = new Circle(4.0D);
            shape[1] = new Rectangle(3.2D, 5.0D);
            shape[2] = new Circle(5.0D);


            foreach(var s in shape)
            {
                s.display();
                Console.WriteLine($"The area:{s.calculateArea():F2} squareunits\n");
            }
        }
    }
}