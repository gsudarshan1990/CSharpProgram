using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAndListExamples
{

    class Student
    {
        int id;
        string? name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
     class ListExample1
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int> { 1, 2, 3, 4, 5 };

            List<string> l2 = new List<string>();

            l2.Add("a");
            l2.Add("b");
            l2.Add("c");
            l2.Add("d");

            List<string> l4 = new List<string> { "Hello", "World", "India", "Raj" };

            Console.WriteLine();
            Console.WriteLine();

            for (int i=0;i<l4.Count;i++) { Console.WriteLine(l4[i]); }


            List<Student> l5 = new List<Student>
            {
                new Student(10,"Rahul"),
                new Student(12,"John"),
                new Student(15,"Bogan")
            };

            int[] arr = new int[] { 2, 8, 5, 10 };

            l1.AddRange(arr);

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < l1.Count; i++) { Console.WriteLine(l1[i]); }

            l1.Remove(2);
            l1.RemoveAt(4);
            l1.RemoveRange(0, 2);

            l1.Insert(1, 20);
            l1.Contains(5);

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < l1.Count; i++) { Console.WriteLine(l1[i]); }




        }
    }
}
