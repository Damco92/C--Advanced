using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;
using CSharpAdvanced_Class4.Enums;

namespace CSharpAdvanced_Class4
{
    public class GraphicCard : Part,IPrice
    {
        public GraphicCard(string name,double price,int memorySpeed,int memory) : base(name,price,PartRole.Graphic_Card)
        {
            MemorySpeed = memorySpeed;
            StandardMemory = memory;
        }

        public GraphicCard()
        {

        }

        public int MemorySpeed { get; set; }
        public int StandardMemory { get; set; }
    }
}
