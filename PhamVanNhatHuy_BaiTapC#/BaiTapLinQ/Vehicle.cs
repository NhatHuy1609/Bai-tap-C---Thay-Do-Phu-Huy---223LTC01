using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_BaiTapC_.BaiTapLinQ
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string CompanyHolding { get; set; }
        public int YearOfManufacture { get; set; }

        public Vehicle() { }

        public Vehicle(string name, string companyHolding, string color, decimal price, int yearOfManufacture) 
        {
            this.Name = name;
            this.CompanyHolding = companyHolding;
            this.Color = color;
            this.Price = price;
            this.YearOfManufacture = yearOfManufacture;
        }
    }
}
