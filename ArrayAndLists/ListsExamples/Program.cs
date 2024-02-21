// See https://aka.ms/new-console-template for more information
using ListsExamples;
Console.WriteLine("Hello, World!");


List<int> employees = new List<int>();

employees.Add(15);
employees.Add(23);
employees.Add(13);
employees.Add(10);
employees.Add(50);

if (employees.Contains(50))
    Console.WriteLine("Contains 50");

int length = employees.Count;
Console.WriteLine("size" + length);

employees.Add(510);
employees.Remove(15);
employees.Insert(2, 10);

foreach (int employee in employees)
{
    Console.WriteLine(employee);
}

Console.WriteLine("Please provide the employees ID");

List<int> employeessecond = new List<int>();

Console.WriteLine("How many employees you want to Add");
int.TryParse(Console.ReadLine(), out length);

for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter the Employee ID");
    int id = int.Parse(Console.ReadLine());
    employeessecond.Add(id);


}

foreach (int employee in employeessecond)
{
    Console.WriteLine(employee);
}



Employee e = new Employee("Rahul", "Jain", "Rahul.Jain@gmail.com", 30);
Employee e1 = new Employee("Bharath", "Mohan", "Bharath.Mohan@gmail.com", 26);
Employee e2 = new Employee("Naman", "Vastav", "Naman.Vastav@gmail.com", 33);
Employee e4 = new Employee("Hariharan", "Parker", "Hari.parker@gmail.com", 36);
Employee e5 = new Employee("Shashank", "garimella", "shashank.garimella@gmail.com", 33);

List<Employee> employeeobject = new List<Employee>();
employeeobject.Add(e);
employeeobject.Add(e1);
employeeobject.Add(e2);
employeeobject.Add(e4);
employeeobject.Add(e5);


foreach (Employee employee in employeeobject)
{
    employee.DisplayDetails();
}



foreach (Employee employee in employeeobject)
{
    Console.WriteLine(employee.convertToJson());
}

