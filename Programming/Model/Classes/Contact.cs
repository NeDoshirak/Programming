using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о контакте из телефонной книги.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;
        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private int _number;

        /// <summary>
        /// Задаёт и возращает имя контакта. Должно состоять только из букв. 
        /// </summary>
        public string Name 
        { 
            get { return _name; } 
            set 
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            } 
        }

        /// <summary>
        /// Задаёт и возращает фамилию контакта. Должна состоять только из букв. 
        /// </summary>
        public string Surname 
        { 
            get { return _surname; } 
            set 
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value; 
            } 
        }

        /// <summary>
        /// Задаёт и возращает номер контакта. Должен состоять только из цифр, больше нуля. 
        /// </summary>
        public int Number 
        { 
            get { return _number; } 
            set 
            {
                Validator.AssertOnPositiveValue(value);
                _number = value; 
            } 
        }

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Contact">
        /// </summary>
        /// <param name="name">Имя контакта. Должно состоять только из букв. </param>
        /// <param name="surname">Фамилия контакта. Должна состоять только из букв.</param>
        /// <param name="number">Номер контакта. Должен состоять только из цифр, больше нуля.</param>
        public Contact (string name, string surname, int number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
        
        /// <summary>
        /// Пустой конструкто класса.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Проверяет, состоит ли строока только из букв.
        /// </summary>
        /// <param name="value">Исходная строка.</param>
        /// <exception cref="ArgumentException"></exception>
        private static void AssertStringContainsOnlyLetters(string value)
        {
            if (!(value.All(c => Char.IsLetter(c) && c <= 'z'))) throw new ArgumentException(nameof(value));

        }

    }
}
