using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_BaiTapC_.BaiTapLinQ_JoinMaxSum
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
        public int DeptId { get; set; }
        public static IList<Employee> Employees
        {
            get
            {
                return new List<Employee>
                {
                    new Employee { Id = 1, Name = "Nhat Huy", Age = 21, Salary = 20000, Birthday = new DateTime(2003, 09, 16), DeptId = 1 },
                    new Employee { Id = 1, Name = "Duc Quang", Age = 21, Salary = 25000, Birthday = new DateTime(2003, 04, 15), DeptId = 2 },
                    new Employee { Id = 1, Name = "Dinh Nhat", Age = 21, Salary = 30000, Birthday = new DateTime(2003, 01, 02), DeptId = 1 },
                    new Employee { Id = 1, Name = "Hong Anh", Age = 21, Salary = 40000, Birthday = new DateTime(2003, 03, 12), DeptId = 2},
                };
            }
        }

        public Employee() { }

        public Employee(int id, string name, int age, decimal salary, DateTime birthday, int deptId)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.Birthday = birthday;
            this.DeptId = deptId;
        }

        public override string ToString()
        {
            return $"Employee: Id:{Id} - Name:{Name} - Age:{Age} - Salary:{Salary} - Birthday:{Birthday} - DeptId: {DeptId}";
        }
    }
}

