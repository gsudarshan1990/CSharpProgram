namespace ArraysImplementation
{
    class Employee
    {
        public string firstName;
        public string secondName;
        public string email;
        public int age;


        public Employee(string firstName, string secondName, string email, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.email = email;
            this.age = age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name {firstName}, SecondName {secondName}, email {email}, age {age}");
        }
    }
}
