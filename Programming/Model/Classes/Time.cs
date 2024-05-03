using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;
        
        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Задаёт и возвращает часы. Они должны принадлежать интервалу от 0 до 23.
        /// </summary>
        public int Hours { get { return _hours; } 
            set 
            {
                Validator.AssertValueInRange(value, 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает минуты. Они должны принадлежать интервалу от 0 до 60.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60);
                _minutes = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает секунды. Они должны принадлежать интервалу от 0 до 60.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60);
                _seconds = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Time">
        /// </summary>
        /// <param name="hours">Часы. Они должны принадлежать интервалу от 0 до 23.</param>
        /// <param name="minutes">Минуты. Они должны принадлежать интервалу от 0 до 60.</param>
        /// <param name="seconds">Секунды. Они должны принадлежать интервалу от 0 до 60.</param>
        public Time( int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Пустой конструктор класса.
        /// </summary>
        public Time() { }
    }
}
