using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace homework_7._2
{

    class Example
    {
        public static void Main()
        {
            Hashtable days = new Hashtable();

            days.Add(1, "SunDay");
            days.Add(2, "MonDay");
            days.Add(3, "TueDay");
            days.Add(4, "WednesDay");
            days.Add(5, "ThursDay");
            days.Add(6, "FriDay");
            days.Add(7, "SaturDay");

            bool check = false;
            foreach (DictionaryEntry daysvalue in days)
            {
                if (daysvalue.Value == "TueDay")
                {
                    check = true;
                    Console.WriteLine("Found at:" + daysvalue.Key +" "+ daysvalue.Value);
                    break;
                }
                else check = false;
            }
                if(check==false)
                Console.WriteLine("Not found");

            foreach (DictionaryEntry de in days)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}



