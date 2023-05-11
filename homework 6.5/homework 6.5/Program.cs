using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6._5
{
    class Employee
    {
        internal int EmpNo;
        internal string Name;
        internal string Email;
        internal int Phone;
        public Employee(int EmpNo, string Name, string Email, int Phone)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
        }
    }
    class Company
    { 
        internal string Name;
        public Company(string Name)
        {
           this.Name = Name;
        }
    }
    delegate void Simultaneously();
    class Program
    {
        event Simultaneously Add;
        public static void ErrorInput()
        {
            Console.WriteLine("Error Input");
        }
        public static void Sucess()
        {
            Console.WriteLine("Sucess");
        }
        static void Main(string[] args)
        {
            int kiemtra = 1;

            Console.WriteLine("Enter number of employees:");
            int number = Convert.ToInt32(Console.ReadLine());
            Employee[] a = new Employee[number];
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("Enter name:");
            }
            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    if (a[i] == a[j])
                    {
                        kiemtra = 0;
                        ErrorInput();
                    }                
                }
            }

            if(kiemtra==1)
            {
                Sucess();
            }

            
        }
            


        }
    }

