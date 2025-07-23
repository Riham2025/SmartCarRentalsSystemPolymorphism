using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCarRentalsSystemPolymorphism
{
    public class Car : Vehicle
    {
        public bool IsLuxury { get; set; } // Indicates if the car is a luxury model

        public Car(string brand, string model, int year, string licensePlate, bool isLuxury)
            : base(brand, model, year, licensePlate)
        {
            IsLuxury = isLuxury;
        }

        public override double CalculateRentalCost(int days) // Override the base method to calculate rental cost for cars
        {
            double rate = IsLuxury ? 80 : 60;
            double cost = rate * days;
            return days > 7 ? cost * 0.9 : cost; // 10% discount if more than 7 days
        }

        public override double CalculateRentalCost(int days, bool withDriver) // Override the overloaded method to include driver cost
        {
            return base.CalculateRentalCost(days, withDriver);
        }
    }
}
