using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//добавлены новые методы для генерации и сохранения чека, а также свойства для хранения информации о покупке, таких как дата, список купленных товаров, общая сумма, кэшбек и способ оплаты.
namespace kurs2.models
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<CartItem> PurchasedItems { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CashbackEarned { get; set; }
        public string PaymentMethod { get; set; }
        public Receipt()
        {
            Id = Guid.NewGuid();
            PurchaseDate = DateTime.Now;
            PurchasedItems = new List<CartItem>();
            PaymentMethod = "";
        }
    }
}
