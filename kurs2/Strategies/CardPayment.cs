using kurs2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//создание оплаты картой 
namespace kurs2.Strategies
{
    public class CardPayment : IPayment
    {
        public bool Pay(Customer customer, decimal amount)
        {
            if (customer.BankCardBalance >= amount)
            {
                customer.BankCardBalance -= amount;
                return true;
            }
            return false;
        }
    }
}
