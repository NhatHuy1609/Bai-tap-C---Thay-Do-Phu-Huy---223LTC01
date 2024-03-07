using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_BaiTapC_.BaiTapLinQ
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }
        public string BodyType { get; set; }
        public static IList<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { Name = "Toyota Camry", CompanyHolding = "Toyota", Color = "Red", Price = 250000, YearOfManufacture = 2020, Seats = 5, BodyType = "Sedan" },
                    new Car { Name = "Honda CR-V", CompanyHolding = "Honda", Color = "Blue", Price = 300000, YearOfManufacture = 2019, Seats = 5, BodyType = "SUV" },
                    new Car { Name = "Ford Explorer", CompanyHolding = "Ford", Color = "Black", Price = 350000, YearOfManufacture = 2018, Seats = 7, BodyType = "Minivan" },
                    new Car { Name = "Chevrolet Corvette", CompanyHolding = "Chevrolet", Color = "White", Price = 140000, YearOfManufacture = 2017, Seats = 5, BodyType = "Coupe" },
                    new Car { Name = "BMW 4 Series Convertible", CompanyHolding = "BMW", Color = "Silver", Price = 145000, YearOfManufacture = 2016, Seats = 4, BodyType = "Convertible" }
                };
            }
        }

        public Car() { }

        public Car(string name, string companyHolding, string color, decimal price, int yearOfManufacture, int seats, string bodyType)
                : base(name, companyHolding, color, price, yearOfManufacture)
        {
            this.Seats = seats;
            this.BodyType = bodyType;
        }

        public override string ToString()
        {
            return $"Car: {Name}, Company Holding: {CompanyHolding}, Color: {Color}, Price: {Price}, Year Of Manufacture: {YearOfManufacture}, Seats: {Seats}, Body Type: {BodyType}";
        }
    }

    public class CarGroup
    {
        public string GroupName { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
