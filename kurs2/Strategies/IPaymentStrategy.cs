using kurs2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//создание метода оплаты для каждого класса 
namespace kurs2.Strategies
{
    public interface IPaymentStrategy
    {
        bool Pay(Customer customer, decimal amount);
    }
}
