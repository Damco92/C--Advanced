using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CompareCountries : IComparer<Product>
    {
        public int Compare(Product product1, Product product2)
        {
            if (product1.DestinationCountries != null && product2.DestinationCountries != null)
            {
                foreach (var country in product1.DestinationCountries)
                {
                    return String.CompareOrdinal(country, country);
                };
                foreach (var country in product2.DestinationCountries)
                {
                    return String.CompareOrdinal(country, country);
                }
            }

            return 0;
        }
    }
}

