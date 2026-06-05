using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kurs2.models;
using kurs2.Strategies;



namespace kurs2.Services
{
        public class PaymentService
        {
            public bool Pay(
                Customer customer,
                decimal amount,
                IPaymentStrategy strategy)
            {
                return strategy.Pay(customer, amount);
            }
        }
   }

