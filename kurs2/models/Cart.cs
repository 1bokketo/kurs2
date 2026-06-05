using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace kurs2.models
{

    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddItem(CartItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(CartItem item)
        {
            Items.Remove(item);
        }

        public decimal CalculateTotal()
        {
            return Items.Sum(x => x.TotalPrice);
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}
