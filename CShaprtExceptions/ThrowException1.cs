using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Student
    {
        int name;
        int age;
    }
    
    class ThrowException1
    {
        static void Main(string[] args)
        {
            Student? std = null;

            try
            {
                
                   printMessage(std);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static void printMessage(Student st)
        {
            if (st == null)
                throw new NullReferenceException("Student Object is Null");
        }
        
    }
}
