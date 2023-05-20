using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_method
{
    class Thread
    {

        public Thread(Action p)
        {
            P = p;
        }

        public Action P { get; set; }

        public void Start()
        {
            
            Console.WriteLine("Start"+P);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(delegate ()
              {
                  Console.WriteLine("Thread 1 running!");
              }
            );
            th1.Start();

            Func<string, int> cw = delegate (string str)
              {
                  return str.Split(new char[] { ' ' }).Length;
              };
            Console.WriteLine(cw("I love csharp"));
        }
    }
}
