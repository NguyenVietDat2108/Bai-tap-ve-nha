using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8._5
{
    class Department : IEnumerable
    {
        string[] names = { "Finance", "Human Resource", "Information Technology",
        "Marketing" };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
        class Flower
        {
            string[] names = { "Hong", "Cuc", "Lan", "Ly", "Mai", "Dao" };
            
            public IEnumerable GetFlower()
            {
                for (int i = 0; i < names.Length; i++)
                {
                    yield return names[i];
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Department dep = new Department();

                foreach (string item in dep)
                {
                    Console.WriteLine(item);
                }
                Flower f = new Flower();

                foreach (string item in f.GetFlower())
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

