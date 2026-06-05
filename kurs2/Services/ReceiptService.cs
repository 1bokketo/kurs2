using kurs2.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//генерация чека и сохранение его в файл
namespace kurs2.Services
{
    public class ReceiptService
    {
        public Receipt CreateReceipt(
            List<CartItem> items,
            decimal totalAmount,
            decimal cashback,
            string paymentMethod)
        {
            Receipt receipt = new Receipt();

            receipt.PurchaseDate = DateTime.Now;
            receipt.PurchasedItems = items;
            receipt.TotalAmount = totalAmount;
            receipt.CashbackEarned = cashback;
            receipt.PaymentMethod = paymentMethod;

            return receipt;
        }

        public void SaveReceiptToFile(Receipt receipt)
        {
            if (!Directory.Exists("Receipts"))
            {
                Directory.CreateDirectory("Receipts");
            }

            string fileName =
                "Receipts\\Receipt_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                ".txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("ЧЕК");
                writer.WriteLine("-------------------");
                writer.WriteLine("Дата: " + receipt.PurchaseDate);
                writer.WriteLine("Оплата: " + receipt.PaymentMethod);
                writer.WriteLine("Сумма: " + receipt.TotalAmount);
                writer.WriteLine("Кэшбек: " + receipt.CashbackEarned);
            }
        }
    }
}
