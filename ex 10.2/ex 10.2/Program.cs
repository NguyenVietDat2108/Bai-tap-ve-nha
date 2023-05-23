using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10._2
{
    delegate int MyDelegate1(int x);
    delegate int MyDelegate2(int x, int y);
    class Program
    {
        public static int Calculate(MyDelegate2 Add, int x, int y)
        {
            int s = Add(x, y);
            return s;
        }
        static void Main(string[] args)
        {
            MyDelegate1 cube = x => x * x * x;
            MyDelegate1 sum = x =>
            {
                int s = 0;
                for (int i = 1; i <= x; i++)
                {
                    s += i;
                }
                return s;
            };
            Func<int, int> p = (int x) =>
            {
                return x * x;
            };

            Console.WriteLine("Binh phuong cua 10 la:{0}", p(10));
            Console.WriteLine("Lap phung cua 3 la {0}", cube(3));
            Console.WriteLine("Tong tu 1 den 10 la {0}", sum(10));

            int total = Calculate((no1, no2) => no1 + no2, 6, 7);
            Console.WriteLine("Tong 6+7={0}", total);

        }
    }
}
