// See https://aka.ms/new-console-template for more information
using System;

namespace StringExamples
{
    class Strings
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string greeting2 = "Nice to Meet You";
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            Console.WriteLine(txt);
            Console.WriteLine("The Length of the txt string is " + txt.Length);

            string txt1 = "HELLO WORLD";

            Console.WriteLine(txt1.ToLower());

            string txt2 = "hello world";

            Console.WriteLine(txt2.ToUpper());

            string firstname = "John";

            string secondname = "Doe";

            string fullname = firstname + secondname;

            Console.WriteLine(fullname);

            //Using Concat function 

            string fullname1 = string.Concat(firstname,secondname);

            Console.WriteLine(fullname1);

            string x = "10";

            string y = "20";

            Console.WriteLine(string.Concat(x, y));

            //Using String Interpolation 

            string fullname3 = $"My name is {firstname} {secondname}";

            Console.WriteLine(firstname);


            //Special Character 

            string txt3 = "We are so called \"vikings\" from the north";

            string txt4 = "It\'s alright";

            Console.WriteLine(txt3);
            Console.WriteLine(txt4);

        }
    }
}