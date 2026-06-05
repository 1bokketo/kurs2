using kurs2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// создание оплаты наличными 
namespace kurs2.Strategies
{
    public class CashPayment : IPayment
    {
        public bool Pay(Customer customer, decimal amount)
        {
            if (customer.CashBalance >= amount)
            {
                customer.CashBalance -= amount;
                return true;
            }
            return false;
        }
    }
}

