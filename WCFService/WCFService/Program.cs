using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            Bkap.ProductServiceClient client = new Bkap.ProductServiceClient();
            Bkap.Product[] products = client.GetProducts();

            Console.WriteLine("Danh sach san pham:");
            foreach (var p in products)
            {
                Console.WriteLine(p.Id + ":" + p.Name + ":" + p.Price);
            }

            Bkap.Product p2 = client.GetProduct(2);

            Console.WriteLine("San pham co ma 2:");
            Console.WriteLine(p2.Id + ":" + p2.Name + ":" + p2.Price);
        }
    }
}
