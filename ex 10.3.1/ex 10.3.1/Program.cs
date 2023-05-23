using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10._3._1
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
          return String.Format("{0} {1} {2} {3}", EmpId, EmpName, Salary,City);
        }
    }
    class Program
    {
        public delegate bool EmpDelegate(Employee emp);
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                EmpId = 1,
                EmpName = "Hoa",
                Salary =
            10000,
                City = "Hanoi"
            });
            employees.Add(new Employee
            {
                EmpId = 2,
                EmpName = "Cuong",
                Salary =
            20000,
                City = "Hanam"
            });
            employees.Add(new Employee
            {
                EmpId = 3,
                EmpName = "Hieu",
                Salary =
            30000,
                City = "Hanoi"
            });
            Console.WriteLine("Lọc theo City:");
            foreach (Employee emp in Filter(employees, emp => emp.City ==
            "Hanoi"))
            {
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("\nLọc theo Salary:");
            foreach (Employee emp in Filter(employees, emp => emp.Salary >=
            20000))
            {
                Console.WriteLine(emp.ToString());
            }
        }
        public static IEnumerable<Employee> Filter(IEnumerable<Employee>
        employees, EmpDelegate check)
        {
            foreach (Employee emp in employees)
            {
                if (check(emp) == true)
                    yield return emp;
            }
        }
    }
    }

