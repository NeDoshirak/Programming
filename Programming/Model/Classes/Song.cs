using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Название песни.
        /// </summary>
        private string _title;

        /// <summary>
        /// Продолжительность песни.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Автор песни.
        /// </summary>
        private string _author;

        /// <summary>
        /// Задаёт и возвращает название песни. 
        /// </summary>
        public string Title { get { return _title; } set {  _title = value; } }

        /// <summary>
        /// Задаёт и возвращает продолжительность песни. Не должна быть отрицательной.
        /// </summary>
        public int Duration 
        { 
            get 
            { 
                return _duration;
            } 
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Создаёт и возвращает автора песни.
        /// </summary>
        public string Author { get { return _author; } set { _author = value; } }

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Song"/>
        /// </summary>
        /// <param name="title">Название песни.</param>
        /// <param name="duration">Продолжительность песни. Не должна быть отрицательной.</param>
        /// <param name="author">Автор песни.</param>
        public Song (string title, int duration, string author)
        {
            Title = title;
            Duration = duration;
            Author = author;
        }
        /// <summary>
        /// Пустой конструктор класса.
        /// </summary>
        public Song() { }
    }
}
