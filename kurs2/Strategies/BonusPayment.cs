using kurs2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs2.Strategies
{
    namespace ShopSystem.Strategies
    {
        public class BonusPayment : IPayment
        {
            public bool Pay(Customer customer, decimal amount)
            {
                if (customer.BonusCard.BonusBalance >= amount)
                {
                    customer.BonusCard.BonusBalance -= amount;
                    return true;
                }

                return false;
            }
        }
    }
}
