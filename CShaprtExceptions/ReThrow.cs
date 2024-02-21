using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
     class ReThrow
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                   
            }
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch
            {
                throw;
            }
        }

        static void Method2()
        {
            string? s1 = null;

            try
            {
                Console.WriteLine(s1[0]);
            }
            catch
            {
                throw;
            }

            
        }

    }
}
