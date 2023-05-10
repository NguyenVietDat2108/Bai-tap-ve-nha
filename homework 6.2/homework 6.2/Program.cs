using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6._2
{
    class InvalidMarkException : Exception
    {   
        public InvalidMarkException():base("Wrong number,retry!")
        {
        }
    }
    class Student
    {
        private string id;
        private string name;
        private double theorymark;
        private double labmark;
        public Student(string id, string name, double theorymark, double labmark)
        {
            this.id = id;
            this.name = name;
            this.theorymark = theorymark;
            this.labmark = labmark;
           
        } 
        public void Display()
        {
            Console.WriteLine("Info: " + "Id:" + id + " Name:" + name 
                + " Theorymark:" + theorymark + " Labmark:" + labmark);
        }
    }
    
    class Program
    {    
        static void Main(string[] args)
        {
            double d = new double();
            double e = new double();
            Console.WriteLine("Enter id:");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string c = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter theorymark:");
            try
            {
                
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter labmark:");
                e = Convert.ToDouble(Console.ReadLine());
                if (d < 0 || d > 10 || e < 0 || e > 10)
                {
                    throw new InvalidMarkException();
                }
            }
            catch(InvalidMarkException invalid)
            {
                Console.WriteLine(invalid.Message);
            }
            if (d > 0 && d > 10 && e < 0 && e > 10)
            {
                Student a = new Student(b, c, d, e);
                a.Display();
            }
        }
    }
}
