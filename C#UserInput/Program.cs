// See https://aka.ms/new-console-template for more information
using System;

namespace UserInput
{
    class Employee
    {
        public string name;
        public int age = 0;
        public string id;

        public Employee(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the employee details");
            Console.WriteLine("Provide the Name");
            string? ename=Console.ReadLine();

            Employee? e = null ;
            Console.WriteLine("Provide the age");
            int eage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Provide the id");
            string? eid = Console.ReadLine();

            if (ename != null && eid != null)
            {
                 e = new Employee(ename, eage, eid);
            }

            if(e != null)
            {
                Console.WriteLine($"Name:{e.name},age:{e.age},id:{e.id}");
            }
        }
    }
}