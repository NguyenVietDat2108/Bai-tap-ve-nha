using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8._2
{
    public class MathEx
    {
        
        public static T Max<T>(T first, params T[] values) where T : IComparable
        {
            T maximum = first;
            foreach (T item in values)
            {
                if (item.CompareTo(maximum) > 0)
                {
                    maximum = item;
                }
            }
            return maximum;
        }
        
        public static T Min<T>(T first, params T[] values) where T : IComparable
        {
            T minimum = first;
            foreach (T item in values)
            {
                if (item.CompareTo(minimum) < 0)
                {
                    minimum = item;
                }
            }
            return minimum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gia tri lon nhat:" 
                + MathEx.Max<int>(7, 490, 56, 890, 45));
            Console.WriteLine("Gia tri nho nhat: "
                +MathEx.Min<string>("NewYork","LonDon","HaNoi" ,"Paris"));
        }
    }
}
