using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Enums;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public static class MinimumConfiguration 
    {
        public static double GetPrice()
        {
            double cheapestCPU = 0;
            for (int i = 0; i < Category.CPU.Count; i++)
            {
                if(Category.CPU[i].Price < Category.CPU[0].Price)
                {
                    cheapestCPU = Category.CPU[i].Price;
                }
            }
            double cheapestHDD = Category.HDD[0].Price;
            for (int i = 0; i < Category.HDD.Count; i++)
            {
                if (Category.HDD[i].Price < cheapestHDD)
                {
                    cheapestHDD = Category.HDD[i].Price;
                }
            }
            var cheapestPrice = cheapestCPU + cheapestHDD;
            return cheapestPrice;
        }
    }
}
