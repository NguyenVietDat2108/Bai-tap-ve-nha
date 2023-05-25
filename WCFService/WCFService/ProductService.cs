using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    public class ProductService : IProductService
    {
        List<Product> products = new List<Product>();
        public ProductService()
        {
            products.Add(new Product()
            {
                Id = 1,
                Name = "Galaxy Tab 5",
                Price= 1300000, 
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Sony Z5",
                Price = 1800000,
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "LG V10",
                Price = 1600000,
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Samsung S4",
                Price = 1100000,
            });
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public Product GetProduct(int productId)
        {
            return products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
