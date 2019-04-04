using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
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

            if (discount < 0)
            {
                throw new Exception("The discount percentege must be positive number!");
            }
            else if(discount > 0 && discount < 100)
            {
                Discount = discount / 100;
            }
            else
            {
                throw new Exception("The discount can not be higher then 100!");
            }
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }
    }
}
