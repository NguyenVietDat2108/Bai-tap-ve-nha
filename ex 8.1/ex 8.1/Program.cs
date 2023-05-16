using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex_8._1
{
    class Student<T>
    {
        T[] data;
        int position;
        public Student(int n)
        {
            data = new T[n];
            position = 0;
        }
        
        public void Add(T item)
        {
            if (position < data.Length)
            {
                data[position] = item;
                position++;
            }
        }
        
        public void Remove(T item)
        {
            int index = Array.IndexOf<T>(data, item, 0);
            if (index < position && index >= 0)
            {
                for (int i = index; i < position - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                position--;
            }
            else
            {
                Console.WriteLine("\'" + item + "\' not found");
            }
        }
        //phương thức hiển thị các phần tử
        public void Display()
        {
            for (int i = 0; i < position; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        Student<string> students = new Student<string>(10);
        students.Add("Thinh");
        students.Add("Dung");
        students.Add("Hai");
        //hiển thị
        Console.WriteLine("Noi dung collection:");
        students.Display();
        //xóa phần tử
        students.Remove("Dung");
        //hiển thị
        Console.WriteLine("Noi dung collection sau khi xoa:");
        students.Display();
    }
    }

