using System.Text;

namespace GetStartedDebugging
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiplicationTable.GetMultiplicationTable(5));
        }

        public static string GetMultiplicationTable(int number)
        {
            var result = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                result.AppendLine($"{number} X {i} = {number * i}");
            }
            return result.ToString();
        }
    }
}
