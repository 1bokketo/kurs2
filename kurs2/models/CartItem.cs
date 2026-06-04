using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs2.models
{

    public class CartItem
    {
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal Weight { get; set; }

        public decimal TotalPrice
        {
            get
            {
                if (Product.IsWeighted)
                    return Product.Price * Weight;

                return Product.Price * Quantity;
            }
        }
    }
}
