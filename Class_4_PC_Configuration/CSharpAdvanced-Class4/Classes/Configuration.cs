using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using CSharpAdvanced_Class4.Interfaces;
using static CSharpAdvanced_Class4.Enums.Enums;

namespace CSharpAdvanced_Class4
{     
    public abstract class Item 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }  
    }

    public class Part : Item, IPrice
    { 
        public double GetPrice()
        {
            return Price;
        } 
    }

    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>(); 

        public Module() { }
        public Module(string name)
        {
            Name = name;
        }

        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part); 
        } 
        
        public double GetPrice()
        {
            double modulePrice = 0;
            foreach (var part in _parts)
            {
                modulePrice += part.Price * part.Quantity;
            }
            return modulePrice;
        }

        public void SetDiscount(double discount)
        {
            
            var modulePrice = GetPrice();
            if(discount < 0)
            {
                throw new Exception("The discount percentege must be positive number!");
            }

            Discount = modulePrice / 100 * discount;

        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() - ( Discount);
        }
    }

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
                modulePrice += module.GetPriceWithDiscount() * module.Quantity;

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
            Discount = GetPrice() / 100 * discount;
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() - ( Discount);
        }

       
    }
}
