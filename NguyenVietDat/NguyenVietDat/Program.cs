using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NguyenVietDat
{
    class Student
    {
        public int Id;
        public string Name;
        public string Gender;
        public int Age;
        public DateTime DateofBirth;
        public string Class;
        public double Mark1;
        public double Mark2;
        public double Mark3;

        public double Mark_AVG()
        {
            return (Mark1 + Mark2 + Mark3 / 3);
        }
    }
    class TestStudent:Student
    {
        ArrayList[] student = new ArrayList[]();
        public void InputInfo()
        {
            Console.WriteLine("Enter number of students:");
            int n = Convert.ToInt32(Console.ReadLine());
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter id:");
                    Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name:");
                    Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter gender:");
                    Gender = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter age:");
                    Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date of birth:");
                    DateofBirth = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter class:");
                    Class = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter mark1:");
                    Mark1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter mark2:");
                    Mark2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter mark3:");
                    Mark3 = Convert.ToInt32(Console.ReadLine());
                    student[i].Add(Id);
                    student[i].Add(Name);
                    student[i].Add(Gender);
                    student[i].Add(Age);
                    student[i].Add(DateofBirth);
                    student[i].Add(Class);
                    student[i].Add(Mark1);
                    student[i].Add(Mark2);
                    student[i].Add(Mark3);
                    student[i].Add(Mark_AVG());
                }
            }
            catch
            {
            }
        }
        public void Display()
        {
            foreach(var a in student)
            {
                Console.WriteLine(a);
            }
        }
        public void FindName()
        {
            Console.WriteLine("Enter name:");
            if (Convert.ToString(Console.ReadLine()) == Name)
                Console.WriteLine(Id + Name + Gender + Age + DateofBirth.Date + Class);
        }
        public void ChangeInfo()
        {
            Console.WriteLine("Choose what you want to change:");

        }
        public void RemoveId()
        {
            Console.WriteLine("Enter id wants to remove:");
            if (Convert.ToInt32(Console.ReadLine()) == Id)
                student[Id].Clear();
        }
        public void MarkOrder()
        {
            for(int i=0;i< student[i].Count; i++)
            {
                if (student[i](Mark_AVG()) < student[i - 1](Mark_AVG()))
                 (student[i](Mark_AVG()), student[i - 1](Mark_AVG())) = (student[i - 1](Mark_AVG()), student[i](Mark_AVG()));

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Input information (input details for a student).");
            Console.WriteLine("2.Sorting student asccending by average mark.");
            Console.WriteLine("3.Display all the student.");
            Console.WriteLine("4.Search Student by Name");
            Console.WriteLine("5.Delete Student by student ID.");
            Console.WriteLine("6.Exit program.");

            Console.WriteLine("Option:");
            int a = Convert.ToInt32(Console.ReadLine());

            TestStudent student = new TestStudent() ;
            switch(a)
            {
                case 1:
                    student.InputInfo();
                    break;
                case 2:
                    student.MarkOrder();
                    break;
                case 3:
                    student.Display();
                    break;
                case 4:
                    student.FindName();
                    break;
                case 5:
                    student.RemoveId();
                    break;
                case 6:
                    Console.WriteLine("Exit program");
                    break;
            }
        }
    }
}
