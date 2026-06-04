using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs2.models
{
    public class Customer
    {
        public string Name { get; set; } = string.Empty;
        public decimal CashBalance { get; set; }
        public decimal BankCardBalance { get; set; }
        public BonusCard BonusCard { get; set; } = new BonusCard();
    }
}
