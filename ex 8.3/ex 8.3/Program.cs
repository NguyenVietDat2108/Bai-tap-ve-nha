using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8_3
{
    public class GenericClass<T> where T : class
    {
        public T Message;
        public void Display(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
        public string Name { get; set; }
        public string Location { get; set; }

    }
    class Employee
        {
            public string Name { get; set; }
            public string Location { get; set; }
        }



    class Program
    {
        static void Main()
        {
            GenericClass<string> stringClass = new GenericClass<string>();
            Console.WriteLine("Write something:");
            stringClass.Message = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Write something:");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Write something:");
            string b = Convert.ToString(Console.ReadLine());
            stringClass.Display(a,b);

            Console.WriteLine("Enter number of employees:");
            int number = Convert.ToInt32(Console.ReadLine());
            GenericClass<Employee>[]Employees = new GenericClass<Employee>[number];

            for(int i=0; i<number; i++)
            { 
                Console.WriteLine("Enter name:");
                var name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter location:");
                var location = Convert.ToString(Console.ReadLine());
            Employees[i].Name = name;
            Employees[i].Location = location;
            }
            foreach (var em in Employees)
            {
                Console.WriteLine("Name:" + em.Name + " Location:" + em.Location);
            }


        }
    }
}
