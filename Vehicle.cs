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
    }
}
