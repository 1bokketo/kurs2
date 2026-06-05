using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//расчет кешбека - 5% 
namespace kurs2.Services
{
    namespace ShopSystem.Services
    {
        public class CashbackService
        {
            public decimal CalculateCashback(decimal amount)
            {
                return amount * 0.05m;
            }
        }
    }
}
