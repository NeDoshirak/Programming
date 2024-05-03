using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о авиаперелётах.
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Точка отправления.
        /// </summary>
        private string _departure;

        /// <summary>
        /// Точка прибытия.
        /// </summary>
        private string _destination;

        /// <summary>
        /// Время полёта.
        /// </summary>
        private int _time;

        /// <summary>
        /// Задаёт и возвращает точку отправления.
        /// </summary>
        public string Destination { get { return _destination; } set {  _destination = value; } }
        /// <summary>
        /// Задаёт и возвращает точку прибытия.
        /// </summary>
        public string Departure { get { return _departure; } set { _departure = value; } }

        /// <summary>
        /// Задаёт и возвращает время полёта. Не должно быть отрицательным.
        /// </summary>
        public int Time 
        { 
            get 
            { 
                return _time; 
            } 
            set 
            { 
                Validator.AssertOnPositiveValue(value);
                _time = value; 
            } 
        }

        /// <summary>
        /// Создаёт экзепляр класса. <see cref="Flight">
        /// </summary>
        /// <param name="departure">Точка отправления.</param>
        /// <param name="destination">Точка прибытия.</param>
        /// <param name="time">Время полёта. Не должно быть отрицательным.</param>
        public Flight(string departure, string destination, int time )
        {
            Time = time;
            Departure = departure;
            Destination = destination;
        }
        
        /// <summary>
        /// Пустой конструктор класса.
        /// </summary>
        public Flight() { }
    }
}
