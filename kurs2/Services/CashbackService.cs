using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//расчет кешбека - 5% 
namespace kurs2.Services
{
    public class CashbackService
    {
        private const decimal CashbackPercent = 0.05m;
        public decimal CalculateCashback(decimal purchaseAmount)
        {
            return purchaseAmount * CashbackPercent;
        }
    }
}
