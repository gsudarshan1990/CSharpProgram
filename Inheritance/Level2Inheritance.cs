using System;

namespace Level2Inheritance
{
    class Vehicle
    {
        public string brand { get; set; }
        public string model { get; set; }

        public int year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand:{brand},Model:{model},Year:{year}");
        }
    }

    class Car : Vehicle
    {
        public int numDoors { get; set; }

        public Car(string brand, string model, int year, int numDoors) : base(brand,model, year) 
        {
            this.numDoors = numDoors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors {numDoors}");
        }
    }

    class MotorCycle : Vehicle
    {
        public string Type { get; set; }
        
        public MotorCycle(string brand, string model, int year, string Type) : base(brand, model, year)
        {
            this.Type = Type;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type {Type}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car("Toyota", "Innova", 2010, 5);

            v.DisplayInfo();

            Console.WriteLine();

            v = new MotorCycle("Harley Davidson", "Sports", 2022, "Cruiser");

            v.DisplayInfo();

        }
    }
}