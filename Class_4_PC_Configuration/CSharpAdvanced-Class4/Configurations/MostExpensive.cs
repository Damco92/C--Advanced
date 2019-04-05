using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Enums;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public static class MostExpensive
    {
        public static double GetPrice()
        {
            double mostExpensiveCPU = Category.CPU[0].Price;
            for (int i = 0; i < Category.CPU.Count; i++)
            {
                if (Category.CPU[i].Price > mostExpensiveCPU)
                {
                    mostExpensiveCPU = Category.CPU[i].Price;
                }
            }
            double mostExpensiveHDD = Category.HDD[0].Price;
            for (int i = 0; i < Category.HDD.Count; i++)
            {
                if (Category.HDD[i].Price > mostExpensiveHDD)
                {
                    mostExpensiveHDD = Category.HDD[i].Price;
                }
            }
            double mostExpensiveMotherboard = Category.MotherBoards[0].Price;
            for (int i = 0; i < Category.MotherBoards.Count; i++)
            {
                if (Category.MotherBoards[i].Price > mostExpensiveMotherboard)
                {
                    mostExpensiveMotherboard = Category.MotherBoards[i].Price;
                }
            }
            double mostExpensiveMonitor = Category.Monitors[0].Price;
            for (int i = 0; i < Category.Monitors.Count; i++)
            {
                if (Category.Monitors[i].Price > mostExpensiveMonitor)
                {
                    mostExpensiveMonitor = Category.MotherBoards[i].Price;
                }
            }
            double mostExpensiveGrapicCard = Category.GraphicCards[0].Price;
            for (int i = 0; i < Category.GraphicCards.Count; i++)
            {
                if (Category.GraphicCards[i].Price > mostExpensiveGrapicCard)
                {
                    mostExpensiveGrapicCard = Category.GraphicCards[i].Price;
                }
            }
            double mostExpensiveRam = Category.Rams[0].Price;
            for (int i = 0; i < Category.Rams.Count; i++)
            {
                if (Category.Rams[i].Price > mostExpensiveRam)
                {
                    mostExpensiveRam = Category.Rams[i].Price;
                }
            }
            double cablesPrice = Category.Cables[0].Price;
            for (int i = 0; i < Category.Cables.Count; i++)
            {
                cablesPrice += Category.Cables[i].Price;
            }
            
            double mostExpensive = mostExpensiveCPU + mostExpensiveHDD + mostExpensiveMotherboard + mostExpensiveMonitor + mostExpensiveGrapicCard + mostExpensiveRam + cablesPrice;
            return mostExpensive;
        }



    }
}
