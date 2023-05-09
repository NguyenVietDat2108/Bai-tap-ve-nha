using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name:");
            string DepartmentName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter number of employees:");
            int EmployeeNumber = Convert.ToInt32(Console.ReadLine());
            Department a = new Department(DepartmentName,EmployeeNumber);

            for (int i = 1; i <= EmployeeNumber; i++)
            {
                Console.WriteLine("Enter id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name:");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter age:");
                int age = Convert.ToInt32(Console.ReadLine());
                a.employee[i] = new Employee(id, name, age);
            }

            for (int i = 1; i <= EmployeeNumber; i++)
            {
                Console.WriteLine(a.employee[i].ToString());
                Console.ReadLine();
            }

        }
    }
}
