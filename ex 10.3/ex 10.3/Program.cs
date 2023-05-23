using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10._3
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
        static void Main(string[] args)
        {
         List<Employee> employees = new List<Employee>();
         employees.Add(new Employee { EmpId = 1, EmpName = "Hoa", Salary =
            10000, City = "Hanoi" });
         employees.Add(new Employee { EmpId = 2, EmpName = "Cuong", Salary =
         20000, City = "Hanam" });
         employees.Add(new Employee { EmpId = 3, EmpName = "Hieu", Salary =
         30000, City = "Hanoi" });

        foreach (Employee emp in FilterByCity(employees, "Hanoi"))
        {
        Console.WriteLine(emp.ToString());
        }
        }
        public static IEnumerable<Employee> FilterByCity(IEnumerable<Employee>
        employees, string filterStr)
        {
        foreach (Employee emp in employees)
        {
        if (emp.City == filterStr)
        yield return emp;
        }
        }

        }
    }

