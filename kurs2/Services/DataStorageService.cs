using kurs2.models;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

namespace kurs2.Services
{


    public class DataStorageService
    {
        private readonly JsonSerializerOptions _options =
            new JsonSerializerOptions
            {
                WriteIndented = true
            };

        private const string ProductsFile = "Data/product.json";
        private const string CustomerFile = "Data/customer.json";
        private const string HistoryFile = "Data/history.json";

        public void SaveProducts(List<Product> products)
        {
            string json =
                JsonSerializer.Serialize(products, _options);

            File.WriteAllText(ProductsFile, json);
        }

        public List<Product> LoadProducts()
        {
            if (!File.Exists(ProductsFile))
                return new List<Product>();

            string json =
                File.ReadAllText(ProductsFile);

            return JsonSerializer.Deserialize<List<Product>>(json)
                   ?? new List<Product>();
        }

        public void SaveCustomer(Customer customer)
        {
            string json =
                JsonSerializer.Serialize(customer, _options);

            File.WriteAllText(CustomerFile, json);
        }

        public Customer LoadCustomer()
        {
            if (!File.Exists(CustomerFile))
                return new Customer();

            string json =
                File.ReadAllText(CustomerFile);

            return JsonSerializer.Deserialize<Customer>(json)
                   ?? new Customer();
        }

        public void SaveHistory(List<Receipt> receipts)
        {
            string json =
                JsonSerializer.Serialize(receipts, _options);

            File.WriteAllText(HistoryFile, json);
        }

        public List<Receipt> LoadHistory()
        {
            if (!File.Exists(HistoryFile))
                return new List<Receipt>();

            string json =
                File.ReadAllText(HistoryFile);

            return JsonSerializer.Deserialize<List<Receipt>>(json)
                   ?? new List<Receipt>();
        }
    }

}