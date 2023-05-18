using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8._4
{
    interface ICaluclate<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Div(T a, T b);
        T Mul(T a, T b);
    }
    class Calculate : ICaluclate<double>
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            Console.WriteLine("Nhap so dau:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so cuoi:");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cong:{0}+{1}={2}", a, b, cal.Add(a, b));
            Console.WriteLine("Tru:{0}-{1}={2}", a, b, cal.Sub(a, b));
            Console.WriteLine("Nhan:{0}*{1}={2}", a, b, cal.Mul(a, b));
            Console.WriteLine("Chia:{0}/{1}={2}", a, b, cal.Div(a, b));
        }
    }
}
