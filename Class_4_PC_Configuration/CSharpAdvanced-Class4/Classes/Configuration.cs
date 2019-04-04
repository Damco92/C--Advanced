using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using CSharpAdvanced_Class4.Interfaces;
using static CSharpAdvanced_Class4.Enums.Enums;

namespace CSharpAdvanced_Class4
{     
    public class Configuration : Item, IPrice, IDiscont
    {
        public Colors BoxColor { get; set; }
        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();
        public List<Part> Parts { get; set; }
        public List<Module> Modules { get; set; } 

        public Configuration() { }
        public Configuration(Colors boxColor)
        { 
            BoxColor = boxColor;
        }

        public void AddPartToProduct(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);
        }

        public void AddModuleToProduct(Module module, int quantity = 1)
        {
            module.Quantity = quantity;
            _modules.Add(module);
        }
         
        public double GetPrice()
        {
            double modulePrice = 0;
            double partsPrice = 0;
            foreach (var module in _modules)
            {
                modulePrice += module.GetPrice() * module.Quantity;

            }

            foreach (var part in _parts)
            {
                partsPrice += part.Price * part.Quantity;

            }
            var fullPrice = modulePrice + partsPrice;
            return fullPrice;
        }

        public void SetDiscount(double discount)
        {
            if(discount < 0)
            {
                throw new Exception("Discount must be positive number!");
            }
            else if(discount > 0 && discount < 100)
            {
                Discount = discount / 100;
            }
            else
            {
                throw new Exception("Discount can not be higher then 100");
            }
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }
    } 
}
