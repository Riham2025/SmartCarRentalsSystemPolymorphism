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
    }
}
