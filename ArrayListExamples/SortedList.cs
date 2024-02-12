using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ArrayListAndListExamples
{
     class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl1 = new SortedList<int, string>();
            sl1.Add(1, "Hello");
            sl1.Add(2, "World");
            sl1.Add(3, "Welcome");
            sl1.Add(4, "To India");

            foreach(var kvp in sl1) 
            {
                Console.WriteLine("Key:{0}, value {1}", kvp.Key, kvp.Value);
            }

            SortedList<string, string> cities = new SortedList<string, string>();
            cities.Add("UK", "London");
            cities.Add("US", "Dayton");
            cities.Add("India", "Delhi");
            cities.Add("srilanka", "Colombo");

            foreach (var kvp in cities)
            {
                Console.WriteLine("Key:{0}, value {1}", kvp.Key, kvp.Value);
            }


            SortedList<string, string> rivers = new SortedList<string, string>()
            {
                { "India","Godavari" },
                {"France","Rhine" },
                {"Egypt","Nile" },
                {"US","Ohio" }
            };


            foreach (var kvp in rivers)
            {
                Console.WriteLine("Key:{0}, value {1}", kvp.Key, kvp.Value);
            }



        }





    }
}
