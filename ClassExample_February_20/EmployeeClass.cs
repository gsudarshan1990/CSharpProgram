namespace ClassExample_February_20
{
    class EmployeeClass
    {
        public string firstname = string.Empty;
        public string lastname = string.Empty;
        string email = string.Empty;

        public int numberOfHoursWorked;
        public double Wage;
        public double HourlyRate;

        DateTime birthDay;

        const int minimalAmountOfHoursWorked = 1;

        public EmployeeClass(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0)
        {

        }

        //Constructor
        public EmployeeClass(string first, string last, string em, DateTime bd, double rate)
        {
            firstname = first;
            lastname = last;
            email = em;
            birthDay = bd;
            HourlyRate = rate;
        }
        public void PerformWork()
        {
            /*numberOfHoursWorked++;
            Console.WriteLine($"firstname:\t {firstname}\nlastname:{lastname} has worked for {numberOfHoursWorked}");
            */
            PerformWork(minimalAmountOfHoursWorked);
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"firstname:\t {firstname}\nlastname:\t{lastname} has worked for {numberOfHoursWorked}");
        }

        public double ReturnWage(bool resetHours = true)
        {
            Wage = numberOfHoursWorked * HourlyRate;
            Console.WriteLine($"firstname:\t {firstname}\nlastname:\t{lastname} has Wage {Wage} for hours worked {numberOfHoursWorked}");


            if (resetHours)
                numberOfHoursWorked = 0;
            return Wage;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"firstname:\t {firstname}\nlastname:\t{lastname}\nemail:\t{email}\nbirthday:\t{birthDay.ToShortDateString()}");
        }


        //Creating a function to demonstrate the pass by value

        public int calculateBonus(int bonus1)
        {
            int bonus = 0;
            if (this.numberOfHoursWorked >= 10)
                bonus = bonus1 * 2;

            Console.WriteLine($"The Bonus for the hours worked {numberOfHoursWorked} is {bonus} ");

            return bonus;

        }

        //Creating a function to demonstrate the pass by reference

        public int calculateBonusWithTax(int bonus, ref int bonusTax)
        {

            if (this.numberOfHoursWorked >= 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The Bonus for the hours worked {numberOfHoursWorked} is {bonus} with {bonusTax} ");

            return bonus;

        }

        public int calculateBonusWithTaxUsingOut(int Bonus, out int BonusTax)
        {
            BonusTax = 0;
            if (numberOfHoursWorked >= 10)
                Bonus *= 2;

            if (Bonus >= 200)
            {
                BonusTax = Bonus / 10;
                Bonus -= BonusTax;
            }

            Console.WriteLine($"The Bonus of the user {Bonus}");
            return Bonus;

        }
    }
}
