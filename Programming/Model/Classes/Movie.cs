using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о фильме. 
    /// </summary>
    internal class Movie
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _title;

        /// <summary>
        /// Продолжительность фильма.
        /// </summary>
        private int _duration;
        
        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Создаёт и возвращает название фильма.
        /// </summary>
        public string Title { get { return _title; } set { _title = value; } }

        /// <summary>
        /// Создаёт и возвращает продолжительность фильма. Не должна быть отрицательной.
        /// </summary>
        public int Duration { get { return _duration; } 
            set 
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            } 
        }

        /// <summary>
        /// Создаёт и возвращает год выпуска фильма. Находится в интервале от 1900 дл 2024.
        /// </summary>
        public int Year { get { return _year; } 
            set 
            { 
                Validator.AssertValueInRange(value,1900,2024);
                _year = value; 
            } 
        }

        /// <summary>
        /// Создаёт и возвращает жанр фильма. Должен пренадлежать типу Genre. <see cref="Genre">
        /// </summary>
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (!(Enum.TryParse(typeof(Genre), value, out var result))) throw new ArgumentException();
                _genre = value;
            }
        }

        /// <summary>
        /// Создаёт и возвращает рейтинг фильма. Лежит в интервале от 1 до 10.
        /// </summary>
        public int Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value,0,10);
                _rating = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Movie">
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="duration">Продолжительность фильма. Не должна быть отрицательной.</param>
        /// <param name="year">Год выпуска фильма. Находится в интервале от 1900 дл 2024.</param>
        /// <param name="genre">Жанр фильма. Должен пренадлежать типу Genre. <see cref="Genre"></param>
        /// <param name="rating">Рейтинг фильма. Лежит в интервале от 1 до 10.</param>
        public Movie (string title, int duration,  int year, string genre, int rating)
        {
            Title = title;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Пустой конструктор класса.
        /// </summary>
        public Movie() { }
    }
}
