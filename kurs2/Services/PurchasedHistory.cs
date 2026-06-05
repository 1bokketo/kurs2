using kurs2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs2.Services
{
    public class PurchaseHistory
    {
        private List<Receipt> _receipts;
        public PurchaseHistory()
        {
            _receipts = new List<Receipt>();
        }
        public void AddReceipt(Receipt receipt)
        {
            _receipts.Add(receipt);
        }

        public List<Receipt> GetAllReceipts()
        {
            return _receipts;
        }

        public void ClearHistory()
        {
            _receipts.Clear();
        }
    }
}
