using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs2.models
{
    public class PieceProduct : Product
    {
        public override decimal GetTotalPrice()
        {
            return Price;
        }
    }
}
