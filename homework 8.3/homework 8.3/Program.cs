using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8._3
{
    class ProductEnumerable<T>
    {
        public T name;
        public T id;
        public T price;
        public ProductEnumerable(T name, T id,T price)
        {
            this.name = name;
            this.id = id;
            this.price = price;
        }
        public void SetProduct(ProductEnumerable<T>[] product)
        {
            foreach(var a in product)
            {
                Console.WriteLine(a.name+" "+a.id+" "+a.price);
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Number of products:");
            int number = Convert.ToInt32(Console.ReadLine());

            ProductEnumerable<string>[] product = new ProductEnumerable<string>[number];
            for(int i=0;i<number;i++)
            {
                Console.WriteLine("Product's name:");
                var name= Convert.ToString(Console.ReadLine());
                Console.WriteLine("Product's id:");
                var id = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Product's price:");
                var price= Convert.ToString(Console.ReadLine());
                product[i] = new ProductEnumerable<string>(name, id, price);
                product[i].SetProduct(product);
            }
            
        }
    }
}
