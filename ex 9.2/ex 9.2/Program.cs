using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9._2
{
    public static class ExtensionString
    {
        public static int CountWord(string str)
        {
            return (str.Split(new char[] { ' ' } )).Length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something:");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Number of words:" + ExtensionString.CountWord(str));
        }
    }
}
