using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter phone's number");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());

            var employee = new
            {
                Name = name,
                Phone = phone,
                Age = age,
            };

            Console.WriteLine("Info:" + employee.Name + " " + employee.Phone + " " + employee.Age);

            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };

        }
    }
}
