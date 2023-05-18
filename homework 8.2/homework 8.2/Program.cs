using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8._2
{
    class Program
    {
        public object GenericMethod<T>(T a,T b)
        {
            (a, b) = (b, a);
            return (a, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter element 1:");
            var a = Console.ReadLine();
            Console.WriteLine("Enter element 2:");
            var b = Console.ReadLine();
            
            Program p = new Program();
            Console.WriteLine("Swap:" +p.GenericMethod(a, b));
            Console.ReadLine();

        }
    }
}
