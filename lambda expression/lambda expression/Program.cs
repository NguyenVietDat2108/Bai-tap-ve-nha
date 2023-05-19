using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,bool> fnormal = delegate (int n) { return n >= 0; };
            Func<int, bool> fshort = (int n) => { return n > 0; };
            Func<int, bool> fveryshort = n => n > 0;
            Console.WriteLine("Enter an interger:");
                int x = Convert.ToInt32(Console.ReadLine());
            if(fveryshort(x))
            {
                Console.WriteLine("X la so duong");
            }
            else
            {
                Console.WriteLine("X la so am");
            }

            Func<string, string> selector = str => str.ToUpper();

            string[] words = { "orange", "apple", "Article", "elephant" };
            IEnumerable<String> aWords = words.Select(selector);

            foreach (String word in aWords)
                Console.WriteLine(word);
            
        }
    }
}
