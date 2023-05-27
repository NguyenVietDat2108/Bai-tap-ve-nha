using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
         static void Main(string[] args)
        {
            string[] words = { "viec", "tuy", "nho", "khong", "lam", "khong",
                               "xong", "duong", "tuy", "ngan", "khong", "di", "khong", "den" };

            Console.WriteLine("Truy van thong thuong nhan du lieu cham");

            IEnumerable<string> resultNormal = from w in words
                                               select w.ToUpper();
            foreach (var r in resultNormal)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine("\nTruy van song song nhan du lieu nhanh");

            //It only makes sense when we're dealing with LINQ to Objects, where we're dealing with 
            //data to memory.
            IEnumerable<string> resultParallel = from wp in words.AsParallel()
                                                 select wp.ToUpper();
            foreach (var r in resultParallel)
            {
                Console.Write(r + " ");
            }
        }
        }
    }


