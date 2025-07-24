using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCarRentalsSystemPolymorphism
{
    public static class Validator
    {
        //  Validates a positive integer
        public static bool IsPositiveInt(string input, out int value)
        {
            return int.TryParse(input, out value) && value > 0;
        }
    }
}
