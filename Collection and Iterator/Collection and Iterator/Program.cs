using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_and_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");
            PrintValues(myAL);

            ArrayList arr = new ArrayList();
            arr.Add("Xin chao");
            arr.Add(10);
            arr.Insert(1, true);
            string[] names = { "Long", "Hai", "Dung" };
            arr.AddRange(names);
            arr.Remove("Xin chao");
            arr.Remove(1);
            arr.RemoveRange(1, 3);
            arr.Clear();
            IEnumerator items = arr.GetEnumerator();
            while(items.MoveNext())
            {
                Console.WriteLine(items.Current);
            }
            ArrayList tree = new ArrayList() { "Tung", "Cuc", "Truc", "Mai" };
            tree.Sort();
            tree.Sort(new CaseInsensitiveComparer());
            if(tree.Contains("Cuc"))
            {
                int pos = tree.IndexOf("Cuc");
                tree.RemoveAt(pos);
            }
            Hashtable pb = new Hashtable();
            pb.Add("HR", "Human Resources");
            pb.Add("IT", "Information Technology");
            pb["MK"] = "Makerting";
            foreach(var key in pb.Keys)
            {
                Console.WriteLine(key + ":" + pb[key]);
            }

            SortedList staff = new SortedList();
            staff.Add("Long", "Administyrator");
            staff.Add("Hung", "Human Resources");
            staff.Add("Thuy", "Finance");
            staff.Add("Dung", "Marketing");
            staff.Add("Thang", "Manager");
            Console.WriteLine("Danh sach nhan vien sap xep theo ten:");
            for(int i=0;i<staff.Count;i++)
            {
                Console.WriteLine("Key:" + staff.GetKey(i) + "/ Value:" + staff.GetByIndex(i));
            }
            if(!staff.ContainsKey("Hoang"))
            {
                staff.Add("Hoang", "Support");
            }
            foreach(var item in staff.Keys)
            {
                Console.WriteLine(staff[item]);
            }
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}

