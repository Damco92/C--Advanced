using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public class HDD :Part,IPrice
    {
        public HDD(string name, double price, int space) : base(name,price)
        {

            StorageSpace = space;
        }

        public HDD()
        {

        }

        public int StorageSpace { get; set; }

        
    }
}
