using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для валидации значений
    /// </summary>
    static class ValueValidator
    {
        /// <summary>
        /// Проверка строки на длину
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLength">Максимальная длина строки</param>
        /// <param name="propertyName">Имя свойства, для которого происходит проверка</param>
        public static void AssertStringOnLength(string? value, int maxLength, string propertyName)
        {
            value = value ?? "0";
            if (value.Length > maxLength) throw new ArgumentException(propertyName);
        }

        /// <summary>
        /// Проверка целого значения на диапазон
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="min">Минимальное значение диапазона</param>
        /// <param name="max">Максимальное значение диапазона</param>
        /// <param name="propertyName">Имя свойства, для которого происходит проверка</param>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max)) throw new ArgumentException(propertyName);
        }

        /// <summary>
        /// Проверка вещественного значения на диапазон
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="min">Минимальное значение диапазона</param>
        /// <param name="max">Максимальное значение диапазона</param>
        /// <param name="propertyName">Имя свойства, для которого происходит проверка</param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if ((value < min) || (value > max)) throw new ArgumentException(propertyName);
        }
    }

}
