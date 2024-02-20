namespace ConsoleApp1
{
    public struct EmployeeWorkTask
    {
        public string TaskType;
        public int hours;

        public void PerformTask()
        {
            Console.WriteLine($"Employee has performed {TaskType} for {hours} hours");
        }
    }
}
