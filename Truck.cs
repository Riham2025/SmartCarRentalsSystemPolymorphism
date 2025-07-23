using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCarRentalsSystemPolymorphism
{
    class Truck : Vehicle
    {

        public double MaxLoadKg { get; set; } // Maximum load capacity in kilograms

        public Truck(string brand, string model, int year, string licensePlate, double maxLoadKg)
            : base(brand, model, year, licensePlate)
        {
            MaxLoadKg = maxLoadKg;
        }

        public override double CalculateRentalCost(int days) // Override the base method to calculate rental cost for trucks
       
        {
            double cost = 100 * days;
            return days > 7 ? cost * 0.9 : cost;
        }

        // Overloaded: cargo weight
        public double CalculateRentalCost(int days, double cargoWeight)
        {
            if (cargoWeight > MaxLoadKg)
            {
                Console.WriteLine(" Cargo exceeds max load!");
                return -1;
            }

            return CalculateRentalCost(days);
        }

        public override string ToString() // override ToString method to provide a string representation of the truck
        {
            return $"{base.ToString()} | Truck | Max Load: {MaxLoadKg}kg";
        }

    }
}
