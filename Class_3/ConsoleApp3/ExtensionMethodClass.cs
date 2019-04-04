using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class ExtensionMethodClass
    {
        public static double? IsNumericValue(this double num)
        {
            if(num % 1 == 0)
            {
                Console.WriteLine("This is an intiger!");
                return num;
            }
            else if (num % 1 != 0)
            {
                Console.WriteLine("This is a double!");
                return num;
            }
            else
            {
                Console.WriteLine("This is not a number at all");
                return null;
            }
        }
    }
}
