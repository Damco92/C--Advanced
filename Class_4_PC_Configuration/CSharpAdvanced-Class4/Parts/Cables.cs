using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;
using CSharpAdvanced_Class4.Enums;

namespace CSharpAdvanced_Class4
{
    public class Cables : Part,IPrice
    {
        public Cables(string name,double price,int length) : base(name,price,PartRole.Cables)
        {
            Length = length;
        }
        public Cables()
        {

        }

        public int Length { get; set; }

    }
}
