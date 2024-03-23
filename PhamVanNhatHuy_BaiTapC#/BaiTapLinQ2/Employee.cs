using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_BaiTapC_.BaiTapLinQ2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DeptId { get; set; }
        public int PosId { get; set; }

        public Employee() { }

        public Employee(int id, string name, string description, DateTime dateOfBirth, int deptId, int posId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.DateOfBirth = dateOfBirth;
            this.DeptId = deptId;
            this.PosId = posId;
        }

        public static IList<Employee> Employees
        {
            get
            {
                return new List<Employee>
                {
                    new Employee { Id = 1, Name = "Nhat Huy", Description = "Ho ten day du: Pham Van Nhat Huy", DateOfBirth = new DateTime(2003, 2, 23), DeptId = 1, PosId = 1 },
                    new Employee { Id = 2, Name = "Quang Huy", Description = "Ho ten day du: Trang Quang Huy", DateOfBirth = new DateTime(2003, 1, 31), DeptId = 2, PosId = 2 },
                    new Employee { Id = 3, Name = "Dinh Nhat", Description = "Ho ten day du: Truong Dinh Nhat", DateOfBirth = new DateTime(2003, 5, 20), DeptId = 3, PosId = 3 }
                };
            }
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return $"Id: {Id} - {Name} - {Description} - {DateOfBirth} - Department's Id: {DeptId} - Position's Id: {PosId}";
        }
    }
}
