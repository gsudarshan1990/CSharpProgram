// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;

namespace Level1Inheritance
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;

            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name of Animal {Name} and Age {Age}");
        }

    }

    class Dog : Animal
    {

        public string Breed;

        public Dog(string breed, string name, int age) : base(name,age)
        {
            Breed = breed;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name of Dog {Name}, Age {Age} and Breed {Breed}");
        }

        public void bark()
        {
            Console.WriteLine(" Woof Woof!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Generic Animal", 5);
            a.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine();

            Dog dog = new Dog("Golden Retriver", "buddy", 3);

            dog.DisplayInfo();
            dog.bark();
        }
    }
}
