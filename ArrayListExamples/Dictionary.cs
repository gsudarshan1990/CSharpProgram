using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAndListExamples
{
     class Dictionary
    {

        static void Main(string[] args)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine("Key:{0}, value:{1}", kvp.Key, kvp.Value);
            }

            var cities = new Dictionary<string, string>();
            cities.Add("UK", "London Manchester ");
            cities.Add("US", "New york california");
            cities.Add("France", "Paris");

            foreach(var kvp in cities)
            {
                Console.WriteLine("Key:{0}, value:{1}", kvp.Key, kvp.Value);
            }
            var cities1 = new Dictionary<string, string>();
            cities1.Add("UK", "London Manchester ");
            cities1.Add("US", "New york california");
            cities1.Add("France", "Paris");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(cities1["UK"]);

            cities.Add("Germany", "Munich Berlin Bavaria");

            cities.Remove("UK");



            Console.WriteLine();
            Console.WriteLine();

            foreach (var kvp in cities)
            {
                Console.WriteLine("Key:{0}, value:{1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine();
            Console.WriteLine();
            cities["US"] = "FLorida Dayton Cicinatti";

            foreach (var kvp in cities)
            {
                Console.WriteLine("Key:{0}, value:{1}", kvp.Key, kvp.Value);
            }

            //Check Key and Values

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(cities.ContainsKey("US"));
            Console.WriteLine(cities.ContainsValue("Paris"));


        }



    }
}

