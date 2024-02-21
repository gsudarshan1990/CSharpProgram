using System;

namespace InheritanceLevelTwo
{
    class Baseclass
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Baseclass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void printMessage()
        {
            Console.WriteLine("This is from the Baseclass");
        }
    }

    class DerivedClass : Baseclass
    {
        public string Role { get; set; }

        public DerivedClass(string role, string name, int age):base(name,age)
        {
            Role = role;
        }

        public override void printMessage()
        {
            base.printMessage();
            Console.WriteLine("This is from the Derived Class");
            Console.WriteLine($"Name is {base.Name}, age is {base.Age} and Role is {Role} ");

        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass("Manager", "Raju", 20);
            d.printMessage();
        }
    }

}