using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kurs2.models;


//бизнес-логика магазина 
namespace kurs2.Services
{
    
        public class ProductService
        {
            private List<Product> _products;
            public ProductService(List<Product> products)
            {
                _products = products;
            }

            public List<Product> GetProducts()
            {
                return _products;
            }
            public Product FindById(Guid id)
            {
                return _products.FirstOrDefault(x => x.Id == id);
            }
            public void DecreaseStock(Guid productId, int quantity)
            {
                Product product = FindById(productId);

                if (product != null)
                {
                    product.StockQuantity -= quantity;
                }
            }
        }
    }

