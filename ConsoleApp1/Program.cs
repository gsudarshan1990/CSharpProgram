// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the Name of the Employee");
string? name = string.Empty;
name = Console.ReadLine();

int value;
Console.WriteLine("Enter the Age of the Employee");
int.TryParse(Console.ReadLine(), out value);

Console.WriteLine("Enter the Id ");
string? id = Console.ReadLine();

Employee1? e1 = null;

if (name != null && id != null)
{
    e1 = new Employee1(name, id, value, EmployeeType.sales);
}

if (e1 != null)
{
    Console.WriteLine("Json value" + e1.convertToJson());
}

Console.WriteLine();

EmployeeWorkTask task;
task.TaskType = "Cooking the Sambhar";
task.hours = 5;

task.PerformTask();
