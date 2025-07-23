using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCarRentalsSystemPolymorphism
{
    // Base class for all vehicles
    class Vehicle
    {
        // Shared properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }

        // Constructor
        public Vehicle(string brand, string model, int year, string licensePlate)
        {
            Brand = brand;
            Model = model;
            Year = year;
            LicensePlate = licensePlate;

            // Year validation
            if (DateTime.Now.Year - Year > 10)
            {
                Console.WriteLine($" Warning: {Brand} {Model} is more than 10 years old.");
            }

        }

        // Virtual method for rental cost
        public virtual double CalculateRentalCost(int days)
        {
            return 0; // base implementation returns 0
        }


    }
}
