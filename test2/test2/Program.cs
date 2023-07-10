using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
   public  interface IStudent
    {
        int StudID { get; set; }
        string StudName { get; set; }
        string StudGender { get; set; }
        int StudAge { get; set; }
        string StudClass { get; set; }
        float StudAvgMark { get; }
        void Print();
    }
    class Student: IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get { return Student.CalAvg(MarkList); } }
        public void Print()
        {
            Console.WriteLine("ID:" + StudID +"  "+ 
                "Name:" + StudName + "  " + 
                "Gender" + StudGender + "  " + 
                "Age:" + StudAge + "  "+
                "Class:" + StudClass + "  " +
                "Avg mark:" + StudAvgMark);
        }
        public Dictionary<int, float> MarkList = new Dictionary<int, float>(3);
        public float this[int index]
        {
            get => MarkList[index];
            set => MarkList[index] = value;
        }
        public static float CalAvg(Dictionary<int, float> MarkList)
        {
            return (MarkList[0] + MarkList[1] + MarkList[2]) / 3;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("=================================");
            Console.WriteLine("1.Insert new student...");
            Console.WriteLine("2.Display all the student list...");
            Console.WriteLine("3.Calculating average mark...");
            Console.WriteLine("4.Find student...");
            Console.WriteLine("5.Exit.");
            Console.WriteLine("=================================");

            Dictionary<int, Student> student = new Dictionary<int, Student>();

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
                    {
                        Student student1 = new Student();
                        Console.WriteLine("Input student Id:");
                        student1.StudID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input student name:");
                        student1.StudName = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Input student gender:");
                        student1.StudGender = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Input student age:");
                        student1.StudAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input student class:");
                        student1.StudClass = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Input student mark:");
                        for (int j = 0; j <3; j++) 
                        { 
                            Console.WriteLine("Input mark {0}:",j+1);
                            int mark = Convert.ToInt32(Console.ReadLine());
                            student1.MarkList.Add(j,mark);
                        }
                            student.Add( i+student.Count(), student1);
                        }
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    goto Label;
                }
                if (choose == 2) 
                { 
                    for(int i=0;i<student.Count();i++)
                    {
                        Console.WriteLine("Student {0}:", i+1 , " ");
                        student[i].Print();
                    }
                    goto Label;
                }
                if (choose == 3) 
                {
                    for (int i = 0; i < student.Count(); i++)
                    {
                        Console.WriteLine("Student {0}:" , i+1 , " ");
                        student[i].Print();
                    }
                    goto Label;
                }
                if (choose == 4) 
                {
                    List<Student> student1 = new List<Student>();
                    List<Student> student2 = new List<Student>();
                    for (int i = 0; i < student.Count(); i++)
                    {
                        int dem = 0;
                        for(int j=0;j< student.Count();j++)
                        {
                            if (student[i].StudID == student[j].StudID)
                                dem = dem + 1;
                            if (student[i].StudName == student[j].StudName)
                                dem = dem + 1;
                            if (student[i].StudClass == student[j].StudClass)
                                dem = dem + 1;
                        }
                        if (dem== 2) student1.Add(student[i]);
                        if (dem >= 2) student2.Add(student[i]);
                    }
                    student1.Sort((x, y) => string.Compare(x.StudName, y.StudName));
                    student2.Sort((x, y) => string.Compare(x.StudName, y.StudName));
                    for (int i=0;i<student1.Count();i++)
                    {
                        student[i].Print();
                    }
                    for (int i = 0; i < student2.Count(); i++)
                    {
                        student[i].Print();
                    }
                    goto Label;
                }
                if(choose==5)
                {
                    Console.WriteLine("Exit.");
                }
            }
        }
    }
}
