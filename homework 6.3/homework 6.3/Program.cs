using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6._3
{    class AmountException : Exception
    {
        public AmountException():base("Problems with salary|bonus")
        {
        }
    }
    class Lecture
    {
        private string name;
        private double salary;
        private double bonus;
        public Lecture(string name,double salary,double bonus)
        {
                this.name = name;
                this.salary = salary;
                this.bonus = bonus;
        }
        public void Display()
        {
             Console.WriteLine( "Info:" + "Name:"+ name +" Salary:" + salary +" Bonus:"+ bonus);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double salary = new double() ;
            double bonus = new double() ;
            Console.WriteLine("Enter name:");
            string name = Convert.ToString(Console.ReadLine());
            try
            {
                Console.WriteLine("Enter salary($):");
                salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter bonus($):");
                bonus = Convert.ToDouble(Console.ReadLine());
                
                if (salary < 60000 | bonus > 10000)
                {
                    throw new AmountException();
                }
            }
            catch (AmountException exception)
            {
                Console.WriteLine(exception.Message);
            }
            if (salary > 60000 && bonus < 10000)
            {
            Lecture a = new Lecture(name, salary, bonus);
            a.Display();
            }
        }
    }
}
