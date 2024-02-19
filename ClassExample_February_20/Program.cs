See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using ClassExample_February_20;

Console.WriteLine("Creating the Employee");
Console.WriteLine("================");

EmployeeClass ec = new EmployeeClass("Rahul", "Bose", "rahul.bose@gmail.com", new DateTime(2004, 8, 28), 25);

Console.WriteLine("Displaying the Employee Details");
ec.DisplayDetails();

ec.PerformWork();
ec.PerformWork();
ec.PerformWork();
ec.PerformWork();
ec.PerformWork(5);
ec.PerformWork(2);
ec.PerformWork();

double wage = ec.ReturnWage(true);
Console.WriteLine($"Wage for the Employee firstname:\t{ec.firstname}\n lastname:{ec.lastname} is Wage:{ec.Wage}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

ec.firstname = "steven";
ec.HourlyRate = 15;



ec.PerformWork();
ec.PerformWork();
ec.PerformWork(1);

double wage2 = ec.ReturnWage(true);
Console.WriteLine($"Wage for the Employee firstname:\t{ec.firstname}\n lastname:{ec.lastname} is Wage:{wage2}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

EmployeeClass ec1 = new EmployeeClass("John", "smith", "John.smith@gmail.com", new DateTime(2002, 8, 12), 20);
Console.WriteLine("Displaying the Employee Details");
ec1.DisplayDetails();

ec1.numberOfHoursWorked = 12;

ec1.PerformWork();
ec1.PerformWork();
ec1.PerformWork(11);
ec1.PerformWork(10);
ec1.PerformWork();

double wage1 = ec1.ReturnWage(true);
Console.WriteLine($"Wage for the Employee firstname:\t{ec1.firstname}\n lastname:{ec1.lastname} is Wage:{wage1}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


EmployeeClass ec2 = new EmployeeClass("John", "smith", "John.smith@gmail.com", new DateTime(2002, 8, 12), 20);
Console.WriteLine("Displaying the Employee Details");
ec1.numberOfHoursWorked = 12;

int minimumBonus = 100;
int finalbonus = ec2.calculateBonus(minimumBonus);
Console.WriteLine($"The minimum bonus for {ec1.firstname} for the {ec1.numberOfHoursWorked} is {finalbonus}");

int minimumBouns = 100;
int bonusTax = 0;
int finalBonus = ec2.calculateBonusWithTax(minimumBouns, ref bonusTax);
Console.WriteLine($"The minimum bonus for {ec1.firstname} for the {ec1.numberOfHoursWorked} is {finalbonus} with tax {bonusTax}");


int minimumBonusout = 200;
int BonusTax;
int finalBonusout = ec1.calculateBonusWithTaxUsingOut(minimumBonusout, out BonusTax);
Console.WriteLine($"The minimum bonus for {ec1.firstname} for the {ec1.numberOfHoursWorked} is {finalbonus} with tax {BonusTax}");
