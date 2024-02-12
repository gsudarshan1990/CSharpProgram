using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListAndListExamples
{
     class Hashtable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");

            foreach(DictionaryEntry de in  ht) { Console.WriteLine("Key {0} value {1}", de.Key, de.Value); }

            var ht1 = new Hashtable() { { "UK", "London Manchestor Bristol" }, { "US", "New York Boston Dayton" }, { "Germany", "Munich Berlin  Bavaria" } };
        
            foreach(DictionaryEntry de in ht1)
            {
                Console.WriteLine("Key {0} value {1}", de.Key,de.Value);
            }

            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(1, "Hello");
            dict1.Add(2, "World");
            dict1.Add(3, "Wonderful");

            Hashtable ht2 = new Hashtable(dict1);

            Console.WriteLine();
            Console.WriteLine();

            foreach (DictionaryEntry de in ht2)
            {
                Console.WriteLine("Key {0} value {1}", de.Key, de.Value);
            }


            ht2.Add(4, "How are you?");
            ht2.Remove(2);

            ht2[3] = "Jump";

            Console.WriteLine();
            Console.WriteLine();

            foreach (DictionaryEntry de in ht2)
            {
                Console.WriteLine("Key {0} value {1}", de.Key, de.Value);
            }



        }
    }


}

