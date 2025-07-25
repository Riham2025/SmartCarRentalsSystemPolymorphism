﻿using System;
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

        //  Validates yes/no input
        public static bool IsYesOrNo(string input)
        {
            input = input.Trim().ToLower();
            return input == "yes" || input == "no";
        }

        //  Validates vehicle index (1-based)
        public static bool IsValidVehicleIndex(string input, int max, out int index)
        {
            return int.TryParse(input, out index) && index >= 1 && index <= max;
        }
    }
}
