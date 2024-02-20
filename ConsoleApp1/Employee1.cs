using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Employee1
    {
        public string name;
        public string Id;
        public int age;

        public EmployeeType employeeType;
        public Employee1(string name1, string Id1, int age1, EmployeeType empType)
        {
            name = name1;
            Id = Id1;
            age = age1;
            this.employeeType = empType;
        }

        public string convertToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
