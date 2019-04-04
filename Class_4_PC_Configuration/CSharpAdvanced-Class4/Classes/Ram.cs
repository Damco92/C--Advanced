using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public class Ram : Part,IPrice
    {
        public Ram(string name, double price,double speed,double size) : base(name,price)
        {

            Speed = speed;
            Size = size;
        }

        public Ram()
        {

        }

        public double Speed { get; set; }
        public double Size { get; set; }
    }
}
