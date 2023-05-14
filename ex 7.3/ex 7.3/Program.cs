using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7._3
{
    class Student:IComparable<Student>
    {
        private string Name;
        public double AveragePoint;
        private double MathPoint;
        private double EnglishPoint;
        private double LiteraturePoint;
        public Student(string Name, double MathPoint, double EnglishPoint, double LiteraturePoint)
        {
            this.Name = Name;
            this.MathPoint = MathPoint;
            this.EnglishPoint = EnglishPoint;
            this.LiteraturePoint = LiteraturePoint;
            AveragePoint=(MathPoint+EnglishPoint+LiteraturePoint)/3;
        }
        public int CompareTo(Student other)
        {
            return this.AveragePoint.CompareTo(other.AveragePoint);
        }
        public void Display ()
        {
            Console.WriteLine("Info:" + Name + " " + 
                MathPoint + " "+EnglishPoint +" "+ LiteraturePoint + " " + AveragePoint );
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students:");
            int number = Convert.ToInt32(Console.ReadLine());

            List<Student>student=new List<Student>();
            for(int i=0;i<number;i++)
            {
                Console.WriteLine("Enter name:");
                var name= Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter MathPoint:");
                var MathPoint = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter EnglishPoint:");
                var EnglishPoint = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter LiteraturePoint:");
                var LiteraturePoint = Convert.ToDouble(Console.ReadLine());
                student.Add(new Student(name, MathPoint, EnglishPoint, LiteraturePoint));
            }

            double max = student[0].AveragePoint;
            Student stmax = student[0];
            foreach (var st in student)
            {
                if (st.AveragePoint > max)
                {
                    max = st.AveragePoint;
                    stmax = st;
                }
            }

            Console.WriteLine("Sinh vien co diem cao nhat la:");
            stmax.Display();
            
            student.Sort();
            for (int i = 0; i < number; i++)
            {
                student[i].Display();
            }



        }
    }
}
