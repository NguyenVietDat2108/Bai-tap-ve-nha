using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{

    public class StudentsManagementSystem
    {
        public Dictionary<int, Student> StudentHashtable = new Dictionary<int, Student>();

        public string[] PrintedOutput = new string[33];

        public bool IsRunning { get; set; }
        public void PrintAllStudents()
        {
            for (int i = 0; i < StudentHashtable.Count(); i++)
            {
                PrintedOutput[i] = StudentHashtable[i].Print(1);
                Console.WriteLine("Student {0}:", i + 1, " ");
                StudentHashtable[i].Print();
            }
        }
        public void PrintAllStudents(List<Student> StudentHashtable)
        {
            for (int i = 0; i < StudentHashtable.Count(); i++)
            {
                Console.WriteLine("Student {0}:", i + 1, " ");
                StudentHashtable[i].Print();
            }
        }
        private void AddStudent()
        {
            Student student = InputStudent();
            StudentHashtable.Add(StudentHashtable.Count(), student);
        }
        private Student InputStudent()
        {
            Student student = new Student();
            Console.WriteLine("Input student Id:");
            student.StudID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input student name:");
            student.StudName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input student gender:");
            student.StudGender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input student age:");
            student.StudAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input student class:");
            student.StudClass = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input student mark:");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Input mark {0}:", j + 1);
                int mark = Convert.ToInt32(Console.ReadLine());
                student.MarkList.Add(j, mark);
            }
            return student;
        }
        public void AddStudent(Student student)
        {
            StudentHashtable.Add(StudentHashtable.Count, student);
        }
        public Student SearchStudentById(int enteredId)
        {
            List<Student> student1 = new List<Student>();
            for (int i = 0; i < StudentHashtable.Count(); i++)
            {
                if (StudentHashtable[i].StudID == Convert.ToInt32(enteredId))
                    student1.Add(StudentHashtable[i]);
            }
            student1.Sort((x, y) => string.Compare(x.StudName, y.StudName));
            return student1[0];
        }
        public List<Student> SearchStudentByName(string enteredName)
        {
            List<Student> student1 = new List<Student>();
            for (int i = 0; i < StudentHashtable.Count(); i++)
            {
                if (StudentHashtable[i].StudName == Convert.ToString(enteredName))
                    student1.Add(StudentHashtable[i]);
            }
            student1.Sort((x, y) => string.Compare(x.StudName, y.StudName));
            return student1;
        }
        public List<Student> SearchStudentByClass(string enteredClass)
        {
            List<Student> student1 = new List<Student>();
            for (int i = 0; i < StudentHashtable.Count(); i++)
            {
                if (StudentHashtable[i].StudClass == Convert.ToString(enteredClass))
                    student1.Add(StudentHashtable[i]);
            }
            student1.Sort((x, y) => string.Compare(x.StudName, y.StudName));
            return student1;
        }
        public bool QuitProgram()
        {
            Console.WriteLine("Exit.");
            IsRunning = false;
            return IsRunning;
        }

        public void Run()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("=================================");
            Console.WriteLine("1.Insert new student...");
            Console.WriteLine("2.Display all the student list...");
            Console.WriteLine("3.Calculating average mark...");
            Console.WriteLine("4.Find student...");
            Console.WriteLine("5.Exit.");
            Console.WriteLine("=================================");

            if(1>0)
            {
                Label: Console.WriteLine("Option:");
                int choose = Convert.ToInt32(Console.ReadLine());
                
                if (choose == 1)
                {
                    try 
                    {
                        Console.WriteLine("Enter number of students:");
                        int number= Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < number; i++)
                            AddStudent();
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto Label;
                }
                if (choose == 2) 
                {
                    PrintAllStudents();
                    goto Label;
                }
                if (choose == 3) 
                {
                    for (int i = 0; i < StudentHashtable.Count(); i++)
                    {
                        StudentHashtable[i].PrintAvgMark();
                    }
                        goto Label;
                }
                if (choose == 4) 
                {
                    Console.WriteLine("Choose: Id(1), Name(2), Class(3)");
                    if (Convert.ToInt32(Console.ReadLine()) == 1)
                        Console.WriteLine("Enter:");
                        SearchStudentById(Convert.ToInt32(Console.ReadLine()));
                    if (Convert.ToInt32(Console.ReadLine()) == 2)
                        Console.WriteLine("Enter:");
                       PrintAllStudents( SearchStudentByName(Convert.ToString(Console.ReadLine())));
                    if (Convert.ToInt32(Console.ReadLine()) == 3)
                        Console.WriteLine("Enter:");
                       PrintAllStudents(SearchStudentByClass(Convert.ToString(Console.ReadLine())));
                    goto Label;
                }
                if (choose == 5)
                {
                    QuitProgram();
                }
            }
        }
    }
}
