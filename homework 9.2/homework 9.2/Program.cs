using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_9._2
{
    class Program
    {
        public static class ExtensionMethod<T>
        {
            public static void Checkdifference(List<string> a,int number)
            {
                for(int i=0;i<number;i++)
                {
                    for(int j=i+1;j<number;j++)
                    {
                        if (a[j] == a[i])
                        {
                            a.RemoveAt(j);
                            number = number - 1;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int number = Convert.ToInt32(Console.ReadLine());

            List <string> list = new List<string>();
            for(int i=0;i<number;i++)
            {
                Console.WriteLine("Enter name:");
                list.Add(Convert.ToString(Console.ReadLine()));
            }

            ExtensionMethod<string>.Checkdifference(list,number);

            foreach(var a in list)
            {
                Console.WriteLine(a);
            }
        }
    }
}
