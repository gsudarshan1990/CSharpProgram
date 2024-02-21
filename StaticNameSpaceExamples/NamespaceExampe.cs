namespace StaticNameSpaceExamples
{

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int EmployeeID { get; set; }

        public Employee(string name, int age, int employeeID)
        {
            Name = name;
            Age = age;
            EmployeeID = employeeID;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name {Name}, Age {Age}, EmployeeId {EmployeeID}");
        }
    }

    public class Manager
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int EmployeeID { get; set; }

        public string Title { get; set; }

        public Manager(string name, int age, int employeeID, string title)
        {
            Name = name;
            Age = age;
            EmployeeID = employeeID;
            Title = title;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name {Name}, Age {Age}, EmployeeId {EmployeeID} and Title {Title}");
        }
    }


    internal class NamespaceExampe
    {


        static void Main(string[] args)
        {
            Employee e = new Employee("Rahul", 23, 101);
            e.DisplayDetails();

            Manager m = new Manager("Ram", 24, 102, "SalesManager");
            m.DisplayDetails();
        }

    }
}
