using System;
using System.Collections.Generic;

namespace _Project.Scripts.NumberHelper
{
    public static class NumberNotation 
    {
        private static Dictionary<double, string> prefixes = new()
        {
            {3, "K"},
            {6, "M"},
            {9, "B"},
            {12, "T"},
            {15, "Qa"},
            {18, "Qi"},
        };

        public static string NotateNumber(double number)
        {
            var exp = System.Math.Floor(System.Math.Log10(number));
            var thirdExp =  3 * System.Math.Floor(exp / 3);

            if (number >= 1000)
                return (number / Math.Pow(10, thirdExp)).ToString("F2") + prefixes[thirdExp];
            return number.ToString("F2");
        }
        
    }
}


