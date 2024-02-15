using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
     class Exception4
    {
        static void Main(string[] args)
        {
            FileInfo? file = null;

            try
            {
                Console.WriteLine("Enter the File Name");
                string? name1 = Console.ReadLine();
                if (name1 != null)
                {
                    file = new FileInfo(name1);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Cleaning Up");
                file = null;
            }
        }
    }
}
