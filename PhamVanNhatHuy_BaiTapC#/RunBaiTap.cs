using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhamVanNhatHuy_BaiTapC_.BaiTapLinQ;
using PhamVanNhatHuy_BaiTapC_.BaiTapLinQ_JoinMaxSum;
using PhamVanNhatHuy_BaiTapC_.BaiTapLinQ2;

namespace PhamVanNhatHuy_BaiTapC_
{
    public class RunBaiTap
    {
        public static void ChayBaiTapLinQ()
        {
            // Phạm Văn Nhật Huy - 21115053120318
            // Câu 2:
            var cars = Car.Cars;
            // a. Hiển thị các xe có giá trong khoảng 100.000 đến 250.000; 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cau 2:");
            Console.WriteLine("a. Hien thi cac xe co gia tri khoang 100000 den 250000");
            Console.ResetColor();
            var carPriceFiltered = cars.Where(c => c.Price >= 100000 && c.Price <= 250000).ToList();
            foreach (var car in carPriceFiltered) { Console.WriteLine(car); }
            // b. Các xe có năm sản xuất > 1990
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("b. Hien thi cac xe co nam san suat > 1990");
            Console.ResetColor();
            var carYearOfManufactureFiltered = cars.Where(c => c.YearOfManufacture > 1990).ToList();
            foreach (var car in carYearOfManufactureFiltered) { Console.WriteLine(car); }
            // c. Gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("c. Gom cac xe theo hang san xuat, tinh tong gia tri theo nhom");
            Console.ResetColor();

            var carGroup = cars.GroupBy(c => c.CompanyHolding)
                            .Select(cgr => new CarGroup
                            {
                                GroupName = cgr.Key,
                                TotalPrice = cgr.Sum(c => c.Price)
                            });
            foreach (var carGr in carGroup)
            {
                Console.WriteLine($"{carGr.GroupName} - Total price: {carGr.TotalPrice}");
            }

            // Câu 3:
            var trucks = Truck.Trucks;
            // a. Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cau 3:");
            Console.WriteLine("a. Hien thi danh sach Truck theo thu tu nam san xuat moi nhat");
            Console.ResetColor();
            var truckYearOfManufacture = trucks.OrderByDescending(c => c.YearOfManufacture).ToList();
            foreach (var truck in truckYearOfManufacture)
            {
                Console.WriteLine(truck);
            }

            // b. Hiển thị tên cty chủ quản của Truck
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("b. Hien thi ten cong ty chu quan cua truck");
            Console.ResetColor();
            var truckCompanyNameFiltered = from truck in trucks
                                           select new
                                           {
                                               TruckName = truck.Name,
                                               TruckCompanyHolding = truck.CompanyHolding
                                           };
            foreach (var truck in truckCompanyNameFiltered)
            {
                Console.WriteLine($"Truck - Name: {truck.TruckName}, Company: {truck.TruckCompanyHolding}");
            }
        }

        public static void ChayBaiTapLinQJoin()
        {
            var departments = BaiTapLinQ_JoinMaxSum.Department.Departments;
            var employees = BaiTapLinQ_JoinMaxSum.Employee.Employees;

            // Max
            var maxSalary = employees.Max(e => e.Salary);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Max salary: {maxSalary}");
            Console.ResetColor();
            // Min
            var minSalary = employees.Min(e => e.Salary);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Min salary: {minSalary}");
            Console.ResetColor();
            // Average
            var averageSalary = employees.Average(e => e.Salary);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Average salary: {averageSalary}");
            Console.ResetColor();
            // Group Join
            var groupJoin = employees.GroupJoin(
                    departments,
                    emp => emp.DeptId,
                    dept => dept.Id,
                    (emp, dept) => new { emp, dept }
                  );
            // Left join
            var resultLeftJoin = from emp in employees
                                 join dept in departments
                                 on emp.DeptId equals dept.Id
                                 into EmployeeDepartmentGroup
                                 from department in EmployeeDepartmentGroup.DefaultIfEmpty()
                                 select new { emp, department };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Left join");
            Console.ResetColor();
            foreach (var item in resultLeftJoin)
            {
                Console.WriteLine($"{item.emp.Name}, {item?.department.DeptName}");
            }

            // Max age employee
            var minBirthday = employees.Min(e => e.Birthday);
            var employeeHasMaxAge = employees.FirstOrDefault(e => e.Birthday == minBirthday);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Oldest employee: {employeeHasMaxAge}");
            Console.ResetColor();

            // Min age employee
            var maxBirthday = employees.Max(e => e.Birthday);
            var minemployeeHasMinAge = employees.FirstOrDefault(e => e.Birthday == maxBirthday);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Youngest employee: {minemployeeHasMinAge}");
            Console.ResetColor();
        }

        public static void ChayBaiTapLinQ2()
        {
            var departments = BaiTapLinQ2.Department.Departments;
            var positions = BaiTapLinQ2.Position.Postions;
            var employees = BaiTapLinQ2.Employee.Employees;

            var searchDict = new Dictionary<string, string>();
            searchDict.Add("Tu khoa", "");
            searchDict.Add("Tuoi tu", "");
            searchDict.Add("Den tuoi", "");
            searchDict.Add("Vi tri", "");
            searchDict.Add("Phong ban", "");

            var check = true;
            while (check)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=== Tim kiem nhan vien ===");
                Console.ResetColor();

                foreach (KeyValuePair<string, string> searchItem in searchDict)
                {
                    Console.Write($"{searchItem.Key}: ");
                    searchDict[searchItem.Key] = Console.ReadLine();
                }

                var tuKhoa = searchDict["Tu khoa"].ToLower();
                var tuoiTu = Int32.Parse(searchDict["Tuoi tu"]);
                var denTuoi = Int32.Parse(searchDict["Den tuoi"]);
                var viTri = searchDict["Vi tri"].ToLower();
                var phongBan = searchDict["Phong ban"].ToLower();

                // Join table employees, departments, positions
                var employeeInfo = (from ep in employees
                                    join dp in departments on ep.DeptId equals dp.Id
                                    join pos in positions on ep.PosId equals pos.Id
                                    orderby ep.Id
                                    select new
                                    {
                                        eId = ep.Id,
                                        eName = ep.Name.ToLower(),
                                        eDescription = ep.Description.ToLower(),
                                        eAge = DateTime.Now.Year - ep.DateOfBirth.Year,
                                        dDescription = dp.Description.ToLower(),
                                        dName = dp.DeptName.ToLower(),
                                        pName = pos.PosName.ToLower(),
                                        pDescription = pos.Description.ToLower()
                                    }).ToList();
                // Filter employees based on searchDict
                var employeeInfoFiltered = employeeInfo.Where(ep =>
                                            ep.eName.Equals(tuKhoa) ||
                                            ep.eDescription.Equals(tuKhoa) ||
                                            ep.dDescription.Equals(tuKhoa) ||
                                            ep.pDescription.Equals(tuKhoa) ||
                                            ep.dName.Equals(phongBan) ||
                                            ep.pName.Equals(viTri) ||
                                            (ep.eAge >= tuoiTu && ep.eAge <= denTuoi)
                                        ).ToList();

                // Select employee that we need
                var employeeResult = from emp
                                     in employees
                                     where (from e in employeeInfoFiltered select e.eId).Contains(emp.Id)
                                     select emp;

                Console.WriteLine("Thong tin ve department");
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (var dep in departments) Console.WriteLine(dep);
                Console.ResetColor();
                Console.WriteLine("Thong tin ve position");
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (var pos in positions) Console.WriteLine(pos);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=== Ket qua sau khi tim kiem ===");
                Console.ResetColor();
                foreach (var emp in employeeResult) Console.WriteLine(emp);

                Console.ResetColor();
                Console.WriteLine("Nhan 0 de ket thuc");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.KeyChar == '0') check = false;
            }
        }
    }
}
