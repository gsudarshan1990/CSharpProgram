using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbuiltMethods
{
     class IFELSEEXAMPLE2
    {
        static void Main(string[] args)
        {
            DateTime datetime1 = DateTime.Now;
            bool employeesPaymentNotStarted = false;

            if(datetime1.Date.Day == 20)
            {
                Console.WriteLine("Start the Payments");
            }
            else if( (datetime1.Date.Day == 25) && !employeesPaymentNotStarted)
            {
                Console.WriteLine("Payments will Delay");
            }

        }

    }
}
