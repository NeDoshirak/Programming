using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal static class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength) throw new ArgumentException(propertyName);
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max)) throw new ArgumentException(propertyName);
        }

        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if ((value < min) || (value > max)) throw new ArgumentException(propertyName);
        }
    }
}
