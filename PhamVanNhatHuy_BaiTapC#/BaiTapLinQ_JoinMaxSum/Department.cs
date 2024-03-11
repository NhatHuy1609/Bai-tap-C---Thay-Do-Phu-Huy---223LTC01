using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_BaiTapC_.BaiTapLinQ_JoinMaxSum
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }


        public Department()
        {

        }
        public Department(int id, string deptName)
        {
            this.Id = id;
            this.DeptName = deptName;
        }

        public static IList<Department> Departments
        {
            get
            {
                return new List<Department>
                {
                    new Department { Id = 1, DeptName = "Department A" },
                    new Department { Id = 2, DeptName = "Department B" },
                };
            }
        }

        public override string ToString()
        {
            return $"Department: Id: {Id} - Name: {DeptName}";
        }
    }
}

