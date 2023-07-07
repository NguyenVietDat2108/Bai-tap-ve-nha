using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVietDat
{
    public class Student
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
            return (Mark1 + Mark2 + Mark3) / 3;
        }
    }
    class TestStudent : Student
    {

        public static void InputInfo(List<Student> student)
        {
            Console.WriteLine("Enter number of students:");
            int n = Convert.ToInt32(Console.ReadLine());
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Student student1 = new Student();
                    Console.WriteLine("Enter id:");
                    student1.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name:");
                    student1.Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter gender:");
                    student1.Gender = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter age:");
                    student1.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date of birth:");
                    student1.DateofBirth = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter class:");
                    student1.Class = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter mark1:");
                    student1.Mark1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter mark2:");
                    student1.Mark2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter mark3:");
                    student1.Mark3 = Convert.ToInt32(Console.ReadLine());


                    if
                       (
                       student1.Id != Convert.ToInt32(("")) &&
                       student1.Name != "" &&
                       student1.Gender != "" &&
                       student1.Age != Convert.ToInt32(("")) &&
                       student1.DateofBirth != null &&
                       student1.Class != "" &&
                       student1.Mark1 != Convert.ToInt32(("")) &&
                       student1.Mark2 != Convert.ToInt32(("")) &&
                       student1.Mark3 != Convert.ToInt32(("")) &&
                       student1.Mark1 >= 0 && student1.Mark1 <= 100 &&
                       student1.Mark1 >= 0 && student1.Mark1 <= 100 &&
                       student1.Mark1 >= 0 && student1.Mark1 <= 100
                       )
                    {
                        student.Add(student1);
                    }

                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Display(List<Student> student)
        {
            foreach (var a in student)
            {
                Console.WriteLine("Id:" + a.Id + " " + "Name:" + a.Name + " " + "Gender:" + a.Gender +
                    " " + "Age:" + a.Age + " " + "DateofBirth:" + a.DateofBirth.ToString("dd/MM/yyyy") + " " + "Class:" + a.Class + " " +
                        "Mark1:" + a.Mark1 + " " +
                        "Mark2:" + a.Mark2 + " " +
                        "Mark3:" + a.Mark3);
            }
        }
        public static void FindName(List<Student> student)
        {
            Console.WriteLine("Enter name:");
            string name = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < student.Count; i++)
            {
                if (name == Convert.ToString(student[i].Name))
                {
                    Console.WriteLine
                        (
                        "Id:" + student[i].Id + " " +
                        "Name:" + student[i].Name + " " +
                        "Gender:" + student[i].Gender + " " +
                        "Age:" + student[i].Age + " " +
                        "DateofBirth:" + student[i].DateofBirth.ToString("dd/MM/yyyy") + " " +
                        "Class:" + student[i].Class + " " +
                        "Mark1:" + student[i].Mark1 + " " +
                        "Mark2:" + student[i].Mark2 + " " +
                        "Mark3:" + student[i].Mark3
                        );
                    break;
                }
            }
        }
        public static void ChangeInfo(List<Student> student)
        {
            Console.WriteLine("Choose what you want to change:Id/Name/Gender/Age/DateofBirth/Class/Mark1/Mark2/Mark3:");
            string change = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter old one:");
            var oldkey = Console.ReadLine();
            Console.WriteLine("Enter new one:");
            var newkey = Console.ReadLine();
            if (change == "Id")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToInt32(oldkey) == Convert.ToInt32(student[i].Id))
                    {
                        student[i].Id = Convert.ToInt32(newkey);
                        break;
                    }
                }
            }
            if (change == "Name")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToString(oldkey) == Convert.ToString(student[i].Name))
                    {
                        student[i].Name = Convert.ToString(newkey);
                        break;
                    }
                }
            }
            if (change == "Gender")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToString(oldkey) == Convert.ToString(student[i].Gender))
                    {
                        student[i].Gender = Convert.ToString(newkey);
                        break;
                    }
                }
            }
            if (change == "Age")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToInt32(oldkey) == Convert.ToInt32(student[i].Age))
                    {
                        student[i].Age = Convert.ToInt32(newkey);
                        break;
                    }
                }
            }
            if (change == "DateofBirth")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToDateTime(oldkey) == Convert.ToDateTime(student[i].DateofBirth))
                    {
                        student[i].DateofBirth = Convert.ToDateTime(newkey);
                        break;
                    }
                }
            }
            if (change == "Class")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToString(oldkey) == Convert.ToString(student[i].Class))
                    {
                        student[i].Class = Convert.ToString(newkey);
                        break;
                    }
                }
            }
            if (change == "Mark1")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToInt32(oldkey) == Convert.ToInt32(student[i].Mark1))
                    {
                        student[i].Mark1 = Convert.ToInt32(newkey);
                        break;
                    }
                }
            }
            if (change == "Mark2")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToInt32(oldkey) == Convert.ToInt32(student[i].Mark2))
                    {
                        student[i].Mark2 = Convert.ToInt32(newkey);
                        break;
                    }
                }
            }
            if (change == "Mark3")
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (Convert.ToInt32(oldkey) == Convert.ToInt32(student[i].Mark3))
                    {
                        student[i].Mark3 = Convert.ToInt32(newkey);
                        break;
                    }
                }
            }

        }
        public static void RemoveId(List<Student> student)
        {
            Console.WriteLine("Enter id wants to remove:");
            int id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < student.Count; i++)
            {
                if (id == Convert.ToInt32(student[i].Id))
                {
                    student.Remove(student[id]);
                    break;
                }
            }
        }
        public static void MarkOrder(List<Student> student)
        {
            Student student1 = new Student();
            for (int i = 0; i < student.Count; i++)
            {
                for (int j = i; j < student.Count - 1; j++)
                {
                    if (student[j + 1].Mark_AVG() < student[j].Mark_AVG())
                    {
                        student1 = student[j + 1];
                        student[j + 1] = student[j];
                        student[j] = student1;
                    }
                }
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
            //Console.WriteLine("7.Change the student's information.");

            List<Student> liststudent = new List<Student>();

            if (1 > 0)
            {
            Label: Console.WriteLine("Option:");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    TestStudent.InputInfo(liststudent);
                    goto Label;
                }
                if (option == 2)
                {
                    TestStudent.MarkOrder(liststudent);
                    goto Label;
                }
                if (option == 3)
                {
                    TestStudent.Display(liststudent);
                    goto Label;
                }
                if (option == 4)
                {
                    TestStudent.FindName(liststudent);
                    goto Label;
                }
                if (option == 5)
                {
                    TestStudent.RemoveId(liststudent);
                    goto Label;
                }
                if (option == 6)
                {
                    Console.WriteLine("Exit program");
                }
                //if (option == 7)
                //{
                    //TestStudent.ChangeInfo(liststudent);
                    //goto Label;
                //}
            }


        }
    }
}