using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a=new string[3];
            Object[] numbers = (Object[])a;
            try
            {
                try
                {
                    try
                    {
                        Console.WriteLine("Print number:");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a[d]);
                    }

                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                
                Console.WriteLine("Enter number1:");
                object number1 = Console.ReadLine();
                Console.WriteLine("Enter number2:");
                object number2 = Console.ReadLine();
                Console.WriteLine("Enter number3:");
                object number3 = Convert.ToInt32(Console.ReadLine());

                a[0] = (string)number1;
                a[1] = (string)number2;
                a[2] = (string)number3; 
                }

                catch (InvalidCastException c)
                {
                  Console.WriteLine(c.Message);
                }
            
            Console.WriteLine("New number in new array:");
            Object number = (Object)Convert.ToInt32(Console.ReadLine());
            numbers[2] = number;
            }

            catch(ArrayTypeMismatchException f)
            {
            Console.WriteLine(f.Message);
            }
            

        }
    }
}
