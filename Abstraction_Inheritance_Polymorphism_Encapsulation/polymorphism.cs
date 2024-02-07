using System;

namespace polymorphism
{
    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Makes a generic sound");
        }
    }

    class Dog : Animal
    {
        public override void sound() 
        {
            Console.WriteLine("Dog makes a bow bow sound");
        }
    }

    class Cat : Animal
    {
        public override void sound() 
        {
            Console.WriteLine("Cat makes a meow meow sound");
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.sound();
            a = new Dog();
            a.sound();
            a = new Cat();
            a.sound();

        }
    }
}