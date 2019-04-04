using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "My name is Damjan and I am a student at SEDC!";
            Quoted.QuoutedText(text);
            Console.WriteLine(Quoted.QuoutedText(text));
            Console.Read();
        }
    }
}
