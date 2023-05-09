using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_5._2
{
    class Employee
    {
        protected int id;
        protected string name;
        protected int age;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Employee(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"ID{Id},Name{Name},Age{Age}";
        }
    }

    class Department
    {
        public string name;
        public Employee[] employee;
        public Department(string  name,int n)
        {
            this.name = name;
            employee = new Employee[n];
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                name = value;
            }
        }
        public Employee this[int index]
        {
            get
            {
                if (index < 0 || index > employee.Length - 1)
                    return null;
                return employee[index];
            }
            set
            {
                if (index < 0 || index > employee.Length - 1)
                    throw new ArgumentOutOfRangeException();
                employee[index] = value;
            }
        }
    }
}
