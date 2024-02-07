// See https://aka.ms/new-console-template for more information
using System;
using static myspace.Car;

namespace Employees
{
    class Employee
    {
        string name = "Rahul";
        string id ="120";
        string age = "30";

        static void Main(string[] args)
        {
            Employee employee = new Employee();


            Console.WriteLine(employee.name);
            Console.WriteLine(employee.id);
            Console.WriteLine(employee.age);

            myspace.Car car = new myspace.Car();
            myspace.Car car1 = new myspace.Car();

            Console.WriteLine(car.returncolor());
            Console.WriteLine(car1.returncolor());

        }
    }
}
