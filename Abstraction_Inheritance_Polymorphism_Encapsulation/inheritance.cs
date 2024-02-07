using System;


namespace inheritance_example
{
    class Vehicle
    {
        public void startengine()
        {
            Console.WriteLine("Starting the Engine");
        }
    }

    class Car : Vehicle
    {
        public void moving()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Car v = new Car();
            v.startengine();
            v.moving();
        }
    }
}