using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10._1
{
    class String
    {
        public static void Connect(string a,string b )
        {
            Console.WriteLine("Connect:"+a + b);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter string1:");
            string a1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter string2:");
            string b1 = Convert.ToString(Console.ReadLine());

            Func<int, int, int> sumNumber = String.Add;
            Action<string, string> joinstring = String.Connect;

            Console.WriteLine("Sum:"+sumNumber(a,b));
            String.Connect(a1, b1);
            
        }
    }
}
