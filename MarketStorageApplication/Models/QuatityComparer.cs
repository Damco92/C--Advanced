using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class QuatityComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.MarketValueDetails.Quantity != null && y.MarketValueDetails.Quantity != null)
            {
                return x.MarketValueDetails.Quantity - y.MarketValueDetails.Quantity;
            }

            return 0;
        }
    }
}
