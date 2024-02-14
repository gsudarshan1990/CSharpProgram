using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbuiltMethods
{
     class DateTimeExample
    {

     
            static void Main(string[] args)
            {
                DateTime dateTime1 = new DateTime(1980, 12, 12);
            DateTime dateTime2 = new DateTime(1994, 06, 01, 18, 30, 00);

                DateTime dateTime3 = DateTime.Today;
                DateTime dateTime4 = DateTime.Now;

                Console.WriteLine(dateTime1);

                Console.WriteLine(dateTime2);

                Console.WriteLine(dateTime3);

                Console.WriteLine(dateTime4);

                TimeSpan t = new TimeSpan(12, 10, 00);

                Console.WriteLine(t);

                DateTime datetime5 = dateTime4.Add(t);

                Console.WriteLine(dateTime3.ToShortDateString());

                Console.WriteLine(datetime5);

                DateTime datetime6 = dateTime2.AddDays(15);

                Console.WriteLine(datetime6);

                DateOnly startDate = new DateOnly(2022, 05, 03);

                DateTime endDate = new DateTime(2024, 02, 14, 0, 0, 0);

                Console.WriteLine(startDate);

                Console.WriteLine(endDate);


        }

    }
}
