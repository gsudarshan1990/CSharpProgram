// See https://aka.ms/new-console-template for more information
using System;


namespace enumExample
{
    enum EmployeeRole
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    class Employee
    {
        public string name { get; set; }
        public int age { get; set; }

        public EmployeeRole Role { get; set; }


        public Employee(string name, int age, EmployeeRole Role)
        {
            this.name = name;
            this.age = age;
            this.Role = Role;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name :{name}, age:{age}, Role:{Role}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Rahul", 20, EmployeeRole.Tester);
            Employee e2 = new Employee("Naman", 30, EmployeeRole.Developer);
            Employee e3 = new Employee("Yashwant", 30, EmployeeRole.Designer);
            Employee e4 = new Employee("Magesh", 30, EmployeeRole.Manager);

            e1.DisplayDetails();
            e2.DisplayDetails();
            e3.DisplayDetails();
            e4.DisplayDetails();
        }
    }
}