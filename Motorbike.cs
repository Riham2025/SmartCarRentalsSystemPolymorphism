using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCarRentalsSystemPolymorphism
{
    class Motorbike : Vehicle
    {
        public bool RequiresHelmet { get; set; } // Indicates if the motorbike requires a helmet

        public Motorbike(string brand, string model, int year, string licensePlate, bool requiresHelmet) // Constructor
        : base(brand, model, year, licensePlate) // Calls the base class constructor
        {
            RequiresHelmet = requiresHelmet;
        }
    }
}
