using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;
using CSharpAdvanced_Class4.Enums;

namespace CSharpAdvanced_Class4
{
    public class RoomEquip : Item, IPrice, IDiscont
    {
        public RoomEquip() { }

        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();
        private List<Configuration> _configurations = new List<Configuration>();
        private List<Part> _spareParts = new List<Part>();
        public List<Part> Parts { get; set; }
        public List<Module> Modules { get; set; }
        public List<Part> SpareParts { get; set; }
        public List<Configuration> Configurations { get; set; }

        public void AddConfigurationsToRoom(Configuration config,int quantity = 1)
        {
            config.Quantity = quantity;
            _configurations.Add(config);
        }

        public void AddModuleToRoom(Module module, int quantity = 1)
        {
            module.Quantity = quantity;
            _modules.Add(module);
        }

        public void AddPartsToRoom(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);
        }

        public double GetPrice()
        {
            double configsPrice = 0;
            double modulesPrice = 0;
            double partsPrice = 0;
            foreach (var config in _configurations)
            {
                configsPrice += config.GetPrice();
            }

            foreach (var module in _modules)
            {
                modulesPrice += module.GetPrice();
            }
            foreach (var part in _parts)
            {
                partsPrice += part.GetPrice();
            }
            var fullPrice = configsPrice + modulesPrice + partsPrice;
            return fullPrice;
        }
        public void SetDiscount(double discount)
        {
            if(discount < 0)
            {
                throw new Exception("Discount must be positive number");
            }
            else if (discount > 0 && discount < 100)
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
