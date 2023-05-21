using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9._4
{
    partial class Employee
    { public int phone;
        public int id;
        public string name;
        public Employee(string name,int id,int phone)
        {
            this.name = name;
            this.id = id;
            this.phone = phone;
        }
    }
    partial class Employee
    {
        public void Display()
        {
            Console.WriteLine("Info:" + name +" "+ id +" "+ phone);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter phone's number");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = new Employee(name,id,phone);
            emp.Display();
        }
    }
}
