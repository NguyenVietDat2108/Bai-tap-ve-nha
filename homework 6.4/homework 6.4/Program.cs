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
        public static void Perform(IntAction act,int[]arr)
        {
            foreach( var a in arr)
            {
                act(a);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntAction act= TestDelegate.PrintInt;
            act(42);
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            TestDelegate.Perform(TestDelegate.PrintInt, arr);

        }
    }
}
