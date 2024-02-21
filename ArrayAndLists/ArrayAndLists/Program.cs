// See https://aka.ms/new-console-template for more information
using ArraysImplementation;
Console.WriteLine("Hello, World!");

int[] samplearray1 = new int[5];

int[] samplearray2 = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Enter the number of employees");
int.TryParse(Console.ReadLine(), out int length);

int[] samplearray3 = new int[length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter the Employee ID");
    int.TryParse(Console.ReadLine(), out samplearray3[i]);
}

Console.WriteLine("Printing The Employee IDs");
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Employee ID:" + samplearray3[i]);
}


Console.WriteLine("Sorting the Array");
Array.Sort(samplearray3);
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Employee ID:" + samplearray3[i]);
}


Console.WriteLine("Reversing the Array");
Array.Reverse(samplearray3);
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Employee ID:" + samplearray3[i]);
}

Console.WriteLine("Copying the Array");
int[] samplearray4 = new int[samplearray3.Length];
samplearray3.CopyTo(samplearray4, 0);
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Employee ID:" + samplearray4[i]);
}

Employee e = new Employee("Rahul", "Jain", "Rahul.Jain@gmail.com", 30);
Employee e1 = new Employee("Bharath", "Mohan", "Bharath.Mohan@gmail.com", 26);
Employee e2 = new Employee("Naman", "Vastav", "Naman.Vastav@gmail.com", 33);
Employee e4 = new Employee("Hariharan", "Parker", "Hari.parker@gmail.com", 36);
Employee e5 = new Employee("Shashank", "garimella", "shashank.garimella@gmail.com", 33);

Employee[] employees = new Employee[5];
employees[0] = e;
employees[1] = e1;
employees[2] = e2;
employees[3] = e5;
employees[4] = e4;

for (int i = 0; i < employees.Length; i++)
{
    employees[i].DisplayDetails();
}