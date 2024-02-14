using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbuiltMethods
{
     class IFELSE
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            string? stringage = Console.ReadLine();
            int age = 0;
            if(stringage != null)
               age = int.Parse(stringage);

            if (age < 18)
            {
                Console.WriteLine("Too Young to apply");
                Console.WriteLine("Send email to Candidate");
            }
            else if ( age > 65)
            {
                Console.WriteLine("Sorry, Selected Age it too old");
                Console.WriteLine("Send email to Candidate");
            }
            else
            {
                Console.WriteLine("Congratulations you can start the application");
            }
        }
    }
}
