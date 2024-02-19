using System.Text;

namespace ClassExample_February_20
{
    internal class StringAndStringBuilderExample
    {
        static void Main(string[] args)
        {
            string name = "Ramachandran";
            string anotherName = name;

            name += " Balasubramanium";

            Console.WriteLine("name:" + name);
            Console.WriteLine("Another Name:" + anotherName);

            Console.WriteLine();
            string uppername = name.ToUpper();


            Console.WriteLine("Name:" + name);
            Console.WriteLine("Upper Name:" + uppername);

            string firstName = "Rahul";
            string lastname = "Samrat";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("FirstName:\t");
            stringBuilder.Append(firstName);
            stringBuilder.Append("\nLastName:\t");
            stringBuilder.Append(lastname);
            Console.WriteLine("Using the String Builder\n" + stringBuilder.ToString());


        }
    }
}
