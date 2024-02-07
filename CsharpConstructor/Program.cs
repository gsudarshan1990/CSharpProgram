// See https://aka.ms/new-console-template for more information
using System;

namespace constructorExample
{
    class Car
    {
        string model;
        string color;
        string year;

        public Car(string model, string color, string year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("mustang", "red", "1969");

            Console.WriteLine($"Model:{Ford.model},color:{Ford.color},year:{Ford.year}");
        }
    }
}
