using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Collections_and_Generics
{
    class General<T>
    {
        T[] a;
        int count;
        public General(int n)
        {
            a = new T[n];
            count = 0;
        }
        public void Add(T value)
        {
            if (count<a.Length)
            {
                a[count] = value;
                count++;
            }
        }
        public void Display()
        {
            foreach(var v in a)
            {
                Console.WriteLine(v);
            }
        }
        

    }
    class Ultility
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T tg = a;
            a = b;
            b = tg;
        }
        public void Display<T>(ref T a,ref T b)
        {
            Console.WriteLine("Swap:" + a +" "+ b);
        }
    }
    public interface IMath<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
    }
    class Number:IMath<int>
    {public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            General<int> general = new General<int>(3);
            general.Add(5);
            general.Add(7);
            general.Add(2);
            general.Display();

            General<string> names = new General<string>(3);
            names.Add("Hoa");
            names.Add("Dung");
            names.Add("Hanh");
            names.Display();

            Ultility u = new Ultility();
            int x = 30,y = 5;
            u.Swap(ref x, ref y);
            u.Display(ref x, ref y);
            string st1 = "Chung", st2 = "Hoan";
            u.Swap(ref st1, ref st2);
            u.Display(ref st1, ref st2);

            List<string> countries = new List<string>();
            countries.Add("Vietnamese");
            countries.Add("France");
            countries.Add("Canada");
            countries.Add("India");
            ReadOnlyCollection<string> countriesReadOnly = new ReadOnlyCollection<string>(countries);
            Console.WriteLine("Values stored in the read only collection:");
            foreach (string str in countriesReadOnly)
            {
                Console.WriteLine(str);
            }

            List<int> numbers0 = new List<int>();
            numbers0.Add(10);
            numbers0.Add(3);
            numbers0.Add(5);
            foreach(int n in numbers0)
            {
                Console.WriteLine(n);
            }

            Dictionary<int, string> dep = new Dictionary<int, string>();
            dep.Add(101, "Accounting");
            dep.Add(102, "Human Resource");
            dep.Add(103, "Information Technology");
            dep.Add(104, "System");
            foreach (var key in dep.Keys)
            {
                Console.WriteLine(key + ":" + dep[key]);
            }

            SortedList<string, int> numbers = new SortedList<string, int>();
            numbers.Add("Three", 3);
            numbers["One"] = 1;
            numbers.Add("Two", 2);
            numbers.Add("Four", 4);
            numbers.Add("Ten", 10);
            foreach(string key in numbers.Keys)
            {
                Console.WriteLine(key+":"+numbers[key]);
            }
            
            List<string> animal = new List<string>() { "Cho", "Meo", "Ga", "Lon" };
            
            Dictionary<string, int> flowers = new Dictionary<string, int>() 
            {
                {"Hoa Lan",20000 },{"Hoa Hong",24000},{"Hoa Ly",23000}
            };
            List<Employee> list = new List<Employee>()
            {
                new Employee{Id=1,Name="Tran Manh",Address="HaNoi"},
                new Employee{Id=2,Name="Tri Dung",Address="Ha Noi"},
                new Employee{Id=3,Name="ThienPhi",Address="HaGiang"}
            };

        }
    }
}
