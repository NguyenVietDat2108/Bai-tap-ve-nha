using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace homework_7._3
{
    class Car
    {
        private string name;
        public
            string color;
        public Car(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
        public void Display()
        {
            Console.WriteLine("Info:"+name+" "+color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            List<Car> car = new List<Car>();
            for(int i=0;i<number;i++)
            {
                Console.WriteLine("Enter car:");
                var name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter color:");
                var color = Convert.ToString(Console.ReadLine());
                car.Add(new Car(name, color));
            }
            for(int i=0;i<number;i++)
            {
                if (car[i].color == "Red")
                {
                    car.Remove(car[i]);
                    number = number - 1;
                    Console.WriteLine(i);
                }
            }
            foreach(Car c in car)
            {
                c.Display();
            }
        }
    }
}
