using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public class Monitor : Part
    {
        public Monitor(string name,double price,string pix,double size) : base(name,price)
        {
            Pixels = pix;
            Size = size;
        }

        public Monitor()
        {

        }

        public string Pixels { get; set; }
        public double Size { get; set; }
    }
}
