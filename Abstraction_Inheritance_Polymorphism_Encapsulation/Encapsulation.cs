using System;

namespace Encapsulation_example
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >=0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age Cannot be negative");
                }
            }
        }
    }

    class Program4
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 10;
            p.Name = "Rahul";

            Console.WriteLine($" Name is {p.Name} and age is {p.Age}");
        }
    }
}
