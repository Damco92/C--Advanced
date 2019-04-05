using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;
using CSharpAdvanced_Class4.Enums;

namespace CSharpAdvanced_Class4
{
    public class Part : Item, IPrice
    {
        public PartRole PartRole { get; set; }

        public Part()
        {

        }

        public Part(string name,double price,PartRole role)
        {
            Name = name;
            Price = price;
            PartRole = role;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
