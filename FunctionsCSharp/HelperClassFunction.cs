using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCSharp
{
     internal class HelperClassFunction
    {
        public static int CalculateWageWithBonus(int a,int b)
        {
            if (b ==12)
            {
                return a * (b + 1);
            }

            return a * b;
        }
    }
}
