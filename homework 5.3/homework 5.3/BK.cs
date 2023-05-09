using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dongvat
{
    namespace AnCo 
    {
        class Bo
        {
            int id;
            string name;
            double weight;

            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }
        }
        class Trau 
        {
            int id;
            string name;
            double weight;
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }
        }
        class De 
        {
            int id;
            string name;
            double weight;
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }
        }
    }
    namespace AnThit 
    {
        class CaSau 
        {
            int id;
            string name;
            double weight;
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }
        }
        class Ho 
        {
            int id;
            string name;
            double weight;
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }
        }
        class SuTu 
        {
            int id;
            string name;
            double weight;
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }
        }
    }
    namespace AnTap 
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            AnCo.Bo a = new AnCo.Bo();
            Console.WriteLine("Id:");
            a.ID= Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Name:");
            a.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Weight");
            a.Weight = Convert.ToDouble(Console.ReadLine());

            AnCo.Trau b = new AnCo.Trau();
            Console.WriteLine("Id:");
            b.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            b.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Weight:");
            b.Weight = Convert.ToDouble(Console.ReadLine());

            AnCo.De c = new AnCo.De();
            Console.WriteLine("Id:");
            c.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            c.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Weight:");
            c.Weight = Convert.ToDouble(Console.ReadLine());

            AnThit.CaSau d = new AnThit.CaSau();
            Console.WriteLine("Id:");
            d.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            d.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Weight:");
            d.Weight = Convert.ToDouble(Console.ReadLine());

            AnThit.Ho e = new AnThit.Ho(); Console.WriteLine("Id:");
            e.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            e.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Weight:");
            e.Weight = Convert.ToDouble(Console.ReadLine());

            AnThit.SuTu f = new AnThit.SuTu(); Console.WriteLine("Id:");
            f.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            f.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Weight:");
            f.Weight = Convert.ToDouble(Console.ReadLine());
        }
    }
}
