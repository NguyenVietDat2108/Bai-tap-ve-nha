using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10._8
{
    class Program
    {
            static void Print()
            {
                Console.WriteLine("Thuc thi nhiem vu");
            }
            static void Main(string[] args)
            {
            Task t1 = new Task(new Action(Print));

            t1.Start();

            Task t2 = Task.Run(() => Print());

            t1.Wait();
            t2.Wait();

            Console.WriteLine("Thead main thuc thi xong");
        }
    }
}

