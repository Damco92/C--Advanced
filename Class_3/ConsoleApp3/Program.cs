using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ExtensionMethodClass.IsNumericValue(54.545445454545454545454545454545454545454545453e645664565464564564564564545654645645645645645656465465466465465446456456456456456456456456456546546456546546546456456456456456456546546456546456546465465464645645646465465464564564564564645645645646456646);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
