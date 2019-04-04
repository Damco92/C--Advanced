using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class IsDigit
    {
        public static bool IsDigits(this string input)
        {

            double myNum;
            bool cast;
            if (cast = double.TryParse(input, out myNum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        }
    }
}
