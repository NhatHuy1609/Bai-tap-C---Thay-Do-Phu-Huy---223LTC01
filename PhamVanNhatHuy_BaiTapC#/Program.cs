// See https://aka.ms/new-console-template for more information
using PhamVanNhatHuy_BaiTapC_.BaiTapLinQ;

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

Console.ReadKey();