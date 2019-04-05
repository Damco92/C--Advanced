using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;
using CSharpAdvanced_Class4.Enums;

namespace CSharpAdvanced_Class4
{
    public class Motherboard : Part,IPrice
    {
        public Motherboard(string name, double price, bool hdmi, bool port) : base(name,price,PartRole.Motherboard)
        {
            HDMI = hdmi;
            DisplayPort = port;
        }

        public Motherboard()
        {

        }
        

        public bool HDMI { get; set; }
        public bool  DisplayPort { get; set; }

    }
}
