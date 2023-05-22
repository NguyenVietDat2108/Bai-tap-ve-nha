using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Func<int,string> checkprime=delegate (int number1)
            {
                int a = 1;
                string b = "La so nguyen to";
                for(int i=2; i<number1; i++)
                {
                    if (number < 2) 
                    {
                        a=0; break;
                    }
                    
                    if(number1%i==0)
                    {
                        a =0;break;
                    }
                }
                if (a == 0)
                    b = "Khong phai so nguyen to";
                return b;
            };
            Console.WriteLine(checkprime(number)) ;

            Console.WriteLine("Enter number1:");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            int m= Convert.ToInt32(Console.ReadLine());

            Func<int,int, int> sum = delegate (int number1,int number2)
            {
                return (number1 + number2) / 2 * (number2 - number1 + 1);
            };
            Console.WriteLine("Sum from n to m:"+sum(n,m));
        }
    }
}
