using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, double> points = new SortedList<string, double>();

            Console.WriteLine("Enter number of students:");
            int number = Convert.ToInt32(Console.ReadLine());

            string[] student = new string[number];
            double[] grade = new double[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter student:");
                student[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter grade:");
                grade[i] = Convert.ToDouble(Console.ReadLine());
                
            }

           for (int i = 0; i < number; i++)
            {
                    points.Add(student[i], grade[i]);
            }
           
            foreach (string a in student)
            {
                Console.WriteLine("Name:"+a);
                Console.ReadLine();
            }
            foreach( double a in grade)
            {
                Console.WriteLine("Grade:" + a);
                Console.ReadLine();
            }
        }
    }
}
