using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9._1
{
    delegate void Calculate(double x1, double x2);
    delegate void ShowMessage(string msg);
    class Program
    {
        public static void Add(double x1,double x2)
        {
            Console.WriteLine("Sum:" +(x1 + x2));
        }
        static void Main(string[] args)
        {
            
            Calculate cal = delegate (double x, double y)
             {
                 Console.WriteLine("Phuong thuc nac danh: x={0},y={1}", x, y);
             };
            cal(10, 5);
            
            Calculate cal1 = new Calculate(Add);
            cal1(10, 30);
            
            ShowMessage sm = delegate (string msg)
              {
                  Console.WriteLine("Delegate 1:" + msg);
              };

            sm += delegate (string msg)
              {
                  Console.WriteLine("Delegate 2:" + msg);
              };
            sm("GG!");
            Console.ReadLine();
        }
    }
}
