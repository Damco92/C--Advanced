using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Quoted
    {
        public static string QuoutedText(this string text)
        {

            return $"\"{text}\"";
        }
    }
}
