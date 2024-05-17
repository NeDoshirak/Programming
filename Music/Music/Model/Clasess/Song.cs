using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
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
            /// Жанр песни
            /// </summary>
            private string _genre;

            /// <summary>
            /// Задаёт и возвращает название песни. 
            /// </summary>
            public string Title 
            { 
                get 
                {

                     return _title; 
                } 
                set 
                {
                    Validator.AssertOnLenghtValue(value, 50);
                    _title = value; 
                } 
            }


            /// <summary>
            /// Задаёт и возвращает жанр песни, должен быть элементом перечесления Genre <see cref="Genre"/>
            /// </summary>
            public string Genre { get { return _genre; } set
            {
                if (!(Enum.TryParse(typeof(Genre), value, out var result))) throw new ArgumentException();
                _genre = value;
            } }

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
                    Validator.AssertValueInRange(value,0,7200);
                    _duration = value;
                }
            }

            /// <summary>
            /// Создаёт и возвращает автора песни.
            /// </summary>
            public string Author { get {  return _author; } set { Validator.AssertOnLenghtValue(value, 50); _author = value; } }

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Song"/>
        /// <param name="title">Название песни.</param>
        /// <param name="duration">Продолжительность песни. Не должна быть отрицательной.</param>
        /// <param name="author">Автор песни.</param>
        /// </summary>
        public Song(string title, int duration, string author, string genre)
            {
                Title = title;
                Duration = duration;
                Author = author;
                Genre = genre;
            }
        /// <summary>
        /// Пустой конструктор класса.
        /// </summary>
        public Song() { }

        /// <summary>
        /// Переводит поля класса в строку.
        /// </summary>
        /// <returns>Строка с данными о классе.</returns>
        public override string ToString()
        {
            return $"Исполнитель: {Author} Название: {Title} Длина: {ToMinutes(Duration)}";
        }

        /// <summary>
        /// Переводит секунды в минуты. 
        /// </summary>
        /// <param name="seconds">Длительность песни в секундах.</param>
        /// <returns>Строка, сожержащая длительность песни в минутах.</returns>
        private string ToMinutes(int seconds)
        {
            return $"{seconds / 60}:{seconds - (seconds / 60) * 60}";
        }

    }
}

