using System;
using System.Collections.Generic;

namespace test2
{
    public class Student: IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get { return Student.CalAvg(MarkList); } }

        public void Print()
        {
            Console.WriteLine("ID:" + StudID + "  " +
                "Name:" + StudName + "  " +
                "Gender" + StudGender + "  " +
                "Age:" + StudAge + "  " +
                "Class:" + StudClass 
                );
        }
        public string Print(int a)
        {
            return("ID:" + StudID + "  " +
                "Name:" + StudName + "  " +
                "Gender" + StudGender + "  " +
                "Age:" + StudAge + "  " +
                "Class:" + StudClass
                );
        }
        public void PrintAvgMark()
        {
            Console.WriteLine("Avg mark:" + StudAvgMark);
        }
        public Dictionary<int, float> MarkList = new Dictionary<int, float>(3);

        public Student(int studID, string studName, string studGender, int studAge, string studClass)
        {
            StudID = studID;
            StudName = studName;
            StudGender = studGender;
            StudAge = studAge;
            StudClass = studClass;
        }

        public Student()
        {
        }

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
}
