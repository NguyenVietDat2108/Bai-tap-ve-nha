using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ex_7._1
{
    class Product
    {
        private string name;
        private double cost;
        private int onhand;
        public Product(string name, double cost, int onhand)
        {
            this.name = name;
            this.cost = cost;
            this.onhand = onhand;
        }
        public override string ToString()
        {
           return "Name:"+name.ToString()+" Cost: "+cost.ToString()+" On hand:"+onhand.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList product = new ArrayList();
            product.Add(new Product("A", 6.9, 7));
            product.Add(new Product("B", 4.3, 6));
            product.Add(new Product("C", 2.6, 5));
            product.Add(new Product("D", 3.9, 6));

            Console.WriteLine("Info");
            foreach (Product i in product)
            {
                Console.WriteLine(" " + i);
            }
        }
        }

        }
    

