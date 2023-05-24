using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                HRMContainer hrm = new HRMContainer();
                Department dep1 = new Department()
                {
                    DepId = "D01",
                    DepName = "Phong Hanh Chinh" };
                Department dep2 = new Department()
                {
                    DepId = "D02",
                    DepName = "Phong Nhan Su" };
                Department dep3 = new Department()
                {
                    DepId = "D03",
                    DepName = "Phong Ky Thuat" };
                }
            Department dep4 = new Department()
            {
                DepId = "D04",
                DepName = "Phong Marketing" };
            hrm.Departments.Add(dep1);
            hrm.Departments.Add(dep2);
            hrm.Departments.Add(dep3);
            hrm.Departments.Add(dep4);

            Employee emp1 = new Employee()
            {
                EmId = "E01",
                FirstName = "Tran Van",
                LastName = "Tuan",
                Email = "tuan@gmail.com",
                Phone = "0977689877",
                Sex = true,
                BirthDay = new DateTime(1990, 1, 20),
                DepId = "D01"
            };
            Employee emp2 = new Employee()
            {
                EmId = "E02",
                FirstName = "Hoang Van",
                LastName = "Hoa",
                Email = "hoa@gmail.com",
                Phone = "0977689877",
                Sex = true,
                BirthDay = new DateTime(1990, 1, 20),
                DepId = "D01"
            };
            Employee emp3 = new Employee()
            {
                EmId = "E03",
                FirstName = "Le Van",
                LastName = "Hai",
                Email = "hai@gmail.com",
                Phone = "0977689877",
                Sex = true,
                BirthDay = new DateTime(1990, 1, 20),
                DepId = "D02"
            };
            Employee emp4 = new Employee()
            {
                EmId = "E04",
                FirstName = "Nguyen Van",
                LastName = "Long",
                Email = "long@gmail.com",
                Phone = "0977689877",
                Sex = true,
                BirthDay = new DateTime(1990, 1, 20),
                DepId = "D02"
            };
            Employee emp5 = new Employee()
            {
                EmId = "E05",
                FirstName = "Ho Van",
                LastName = "Hanh",
                Email = "hanh@gmail.com",
                Phone = "0977689877",
                Sex = true,
                BirthDay = new DateTime(1990, 1, 20),
                DepId = "D02"
            };

            hrm.Employees.Add(emp1);
            hrm.Employees.Add(emp2);
            hrm.Employees.Add(emp3);
            hrm.Employees.Add(emp4);
            hrm.Employees.Add(emp5);

            hrm.SaveChanges();

            var listE = from e in hrm.Employees select e;
            Console.WriteLine("Hien thi danh sach nhan vien:");
            foreach (var item in listE)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + "- Phong:"
                + item.Department.DepName);
            }

            var listH = from e in hrm.Employees
                        where e.LastName.StartsWith("H")
                        select e;
            Console.WriteLine("Hien thi danh sach nhan vien co ten bat dau bang chu H: ");
            
            foreach (var item in listH)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            var listA = hrm.Employees.Where(x => x.LastName.Contains("a"));
            Console.WriteLine("Hien thi danh sach nhan vien co ten chua chu a:");
            
            foreach (var item in listA)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            var list3 = hrm.Employees.Take(3);
            Console.WriteLine("Hien thi danh sach 3 nhan vien dau tien:");
            foreach (var item in list3)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
