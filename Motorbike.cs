﻿using System;
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

        public override double CalculateRentalCost(int days)
        { // Override the base method to calculate rental cost for motorbikes
            double cost = 40 * days;
            return days > 7 ? cost * 0.9 : cost;
        }

        public override string ToString() // override ToString method to provide a string representation of the motorbike
        {
            return $"{base.ToString()} | Motorbike | Helmet Required: {(RequiresHelmet ? "Yes" : "No")}";
        }

         

    }
}
