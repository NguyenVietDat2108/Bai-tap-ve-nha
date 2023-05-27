using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using a= System.Threading;

namespace ex_10._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQuan sat ket qua lap truyen thong");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i = {0} executed by thread with ID {1}", i, a.Thread.CurrentThread.ManagedThreadId);
                a.Thread.Sleep(200);
            }
            Console.WriteLine("\nQuan sat ket qua lap song song");

            a.Tasks.Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i = {0} executed by thread with ID {1}",
                i, a.Thread.CurrentThread.ManagedThreadId);
                a.Thread.Sleep(200);
            });
        }
    }
    }

