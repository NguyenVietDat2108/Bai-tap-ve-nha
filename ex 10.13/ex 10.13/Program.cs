using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10._13
{
    class Program
    {
        static dynamic DynamicMethod(dynamic param)
        {
            if (param is int)
            {
                Console.WriteLine("Tham so dong kieu int co gia tri {0}",param);
                return param;
            }
            else if (param is string)
            {
                Console.WriteLine("Tham so dong kieu string co gia tri {0}",param);
                return param;
            }
            else
            {
                Console.WriteLine("Tham so dong kieu khong ro co gia tri {0}", param);
            return param;
            }
        }
        static void Main(string[] args)
        {
            dynamic dynaVar1 = DynamicMethod(3);
            dynamic dynaVar2 = DynamicMethod("Hello World");
            dynamic dynaVar3 = DynamicMethod(12.5);
            Console.WriteLine("\nCac gia tri nha duoc:\n{0} \n{1} \n{2}",
            dynaVar1, dynaVar2, dynaVar3);
        }
    }
}
