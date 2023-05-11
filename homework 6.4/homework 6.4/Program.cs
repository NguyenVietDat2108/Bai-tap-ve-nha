using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6._4
{
    delegate void IntAction(int a);
    class TestDelegate
    {
        public static void PrintInt(int a)
        {
            Console.WriteLine("Print interger:" + a);
        }
        public static void Peform(IntAction act,int[]arr)
        {
            Console.WriteLine("")
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntAction act;
            act(42);
        }
    }
}
