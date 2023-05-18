using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8._1
{
    class Generic<T>
    {
        public T[] array;
        public int Index { get; set; }
        public Generic(int size)
        {
            array = new T[size + 1];
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void setItem(T value)
        {
            array[Index] = value;
        }
        public void GetIndex(int index)
        {
            this.Index = index;
        }
    }
    class Constructor
    {
        public int Index { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of numbers:");
            int index = Convert.ToInt32(Console.ReadLine());

            Generic<int> intArray = new Generic<int>(index);
            intArray.Index = index;

            for (int i = 0; i < intArray.Index; i++)
            {
                intArray.setItem(i * 5);
            }

            for (int i = 0; i < intArray.Index; i++)
            {
                Console.Write(intArray.getItem(i) + " ");
            }
            Console.ReadLine();
            
        }
    }
}
