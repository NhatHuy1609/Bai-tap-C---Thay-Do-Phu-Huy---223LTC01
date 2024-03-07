using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_BaiTapC_.BaiTapLinQ
{
    public class Truck : Vehicle
    {
        public double PayloadCapacity { get; set; }
        public string CabType { get; set; }
        public static IList<Truck> Trucks
        {
            get
            {
                return new List<Truck>()
                {
                    new Truck { Name = "Volvo FH16", CompanyHolding = "Volvo Trucks", Color = "Blue", Price = 80000, YearOfManufacture = 2020, PayloadCapacity = 25.5, CabType = "Sleeper Cab" },
                    new Truck { Name = "Scania R730", CompanyHolding = "Scania", Color = "Red", Price = 75000, YearOfManufacture = 2019, PayloadCapacity = 22.3, CabType = "Day Cab" },
                    new Truck { Name = "Mercedes-Benz Actros", CompanyHolding = "Mercedes-Benz", Color = "White", Price = 85000, YearOfManufacture = 2018, PayloadCapacity = 24.8, CabType = "High Cab" },
                    new Truck { Name = "MAN TGX", CompanyHolding = "MAN Truck & Bus", Color = "Yellow", Price = 78000, YearOfManufacture = 2017, PayloadCapacity = 23.1, CabType = "Medium Cab" },
                    new Truck { Name = "DAF XF", CompanyHolding = "DAF Trucks", Color = "Green", Price = 79000, YearOfManufacture = 2016, PayloadCapacity = 21.9, CabType = "Space Cab" }
                };
            }
        }

        public Truck() { }

        public Truck(string name, string companyHolding, string color, decimal price, int yearOfManufacture, double payloadCapacity, string cabType)
                : base(name, companyHolding, color, price, yearOfManufacture)
        {
            this.PayloadCapacity = payloadCapacity;
            this.CabType = cabType;
        }

        public override string ToString()
        {
            return $"Truck: {Name}, Company Holding: {CompanyHolding}, Color: {Color}, Price: {Price}, Year Of Manufacture: {YearOfManufacture}, Payload Capacity: {PayloadCapacity}, Cab Type: {CabType}";
        }
    }
}
