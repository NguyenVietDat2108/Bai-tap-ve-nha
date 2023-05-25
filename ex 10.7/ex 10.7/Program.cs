using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex_10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(Bkap.Print));
            //chạy thread
            th.Start();
            while (true)
                Console.Write(" Thread Main ");
        }
    }
    class Bkap
    {
        public static void Print()
        {
            while (true)
                Console.Write(" Thread Bkap ");

        }
    }
}
