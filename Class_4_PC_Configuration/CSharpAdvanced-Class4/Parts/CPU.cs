using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;
using CSharpAdvanced_Class4.Enums;

namespace CSharpAdvanced_Class4
{
    public class CPU : Part,IPrice
    {
        public CPU(string name,double price,int cores,int speed) : base(name,price,PartRole.CPU)
        {
            NumOfCores = cores;
            Speed = speed;
        }

        public CPU()
        {

        }
        public int NumOfCores { get; set; }
        public int Speed { get; set; }
    }
}
