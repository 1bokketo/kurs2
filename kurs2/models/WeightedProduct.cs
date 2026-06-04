using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs2.models
{
    public class WeightedProduct : Product
    {
        public decimal Weight { get; set; }
        public bool IsWeighed { get; set; }
        public override decimal GetTotalPrice()
        {
            return Price * Weight;
        }
    }
}
