using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит методы для валидации значений.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Проверка числа на неотрицательность. 
        /// </summary>
        /// <param name="value">Проверяемое число типа int.</param>
        /// <exception cref="ArgumentException">Число является отрицательным.</exception>
        public static void AssertOnPositiveValue(int value)
        {
            if (value <= 0) throw new ArgumentException(nameof(value));
        }

        /// <summary>
        /// Проверка числа на неотрицательность.
        /// </summary>
        /// <param name="value">Проверяемое число типа double.</param>
        /// <exception cref="ArgumentException">Число является отрицательным.</exception>
        public static void AssertOnPositiveValue(double value) 
        {
            if (value <= 0) throw new ArgumentException(nameof(value));
        }

        /// <summary>
        /// Проверяет число на принадлежность к интревалу.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Минимальное значение в интервале.</param>
        /// <param name="max">Максимальное значение в интервале.</param>
        /// <exception cref="ArgumentException">Число не принадлежит интервалу.</exception>
        public static void AssertValueInRange(int value, int min, int max) 
        {
            if ((value < min) || (value > max)) throw new ArgumentException(nameof(value));
        }

    }
}
