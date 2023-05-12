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
        public void Display()
        {
            Console.WriteLine("Info:" + " EmpNo:"+EmpNo +" Name:"+ Name +" Email:"+ Email + " Phone:"+ Phone);
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
    delegate void EventHandler();
    class Program
    {
        event EventHandler AddEmployee;
        public static void ErrorInput()
        {
            Console.WriteLine("Error Input");
        }
        public static void Success()
        {
            Console.WriteLine("Success");
        }
        static void Main(string[] args)
        {
            int kiemtra = 1;

            Console.WriteLine("Enter number of employees:");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Employee[] a = new Employee[number];
            string[] name = new string[number];
            Company[] b = new Company[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter EmpNo");
                int EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name:");
                name[i] = Convert.ToString(Console.ReadLine()); 
                Console.WriteLine("Enter email:");
                string email = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Phone:");
                int phone = Convert.ToInt32(Console.ReadLine());
                a[i] = new Employee(EmpNo, name[i], email, phone);
                b[i] = new Company(name[i]);
            }
           
            for (int i = 0; i <number; i++)
            {
                for (int j = i+1; j <number; j++)
                {
                    if (name[i] == name[j])
                    {
                        kiemtra = 0;
                        Program p = new Program();
                        p.AddEmployee += new EventHandler(ErrorInput);
                        p.AddEmployee();
                    }                
                }
            }

            if(kiemtra==1)
            {
                Program p = new Program();
                p.AddEmployee += new EventHandler(Success);
                p.AddEmployee();
                for (int i = 0; i < number; i++)
                {
                    a[i].Display();
                }
            }
            


            
        }
            


        }
    }

