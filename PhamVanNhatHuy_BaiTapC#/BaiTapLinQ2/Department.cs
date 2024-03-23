using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_BaiTapC_.BaiTapLinQ2
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string Description { get; set; }

        public Department() { }

        public Department(int id, string name, string description)
        {
            this.Id = id;
            this.DeptName = name;
            this.Description = description;
        }

        public static IList<Department> Departments
        {
            get
            {
                return new List<Department>
                {
                    new Department { Id = 1, DeptName = "A", Description = "Phong ban A tai tang 2 cua toa LandMark" },
                    new Department { Id = 2, DeptName = "B", Description = "Phong ban B tai tang 2 cua toa LandMark" },
                    new Department { Id = 3, DeptName = "C", Description = "Phong ban C tai tang 2 cua toa nha LandMark" }
                };
            }
        }

        public override string ToString()
        {
            return $"Id: {Id} - Department name: {DeptName} - Description: {Description}";
        }
    }
}
