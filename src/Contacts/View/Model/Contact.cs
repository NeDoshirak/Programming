using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт с именем, номером телефона и электронной почтой.
    /// </summary>
    public class Contact : ObservableObject, ICloneable, IDataErrorInfo
    {
        /// <summary>
        /// Поле для хранения имени контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле для хранения номера телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Поле для хранения электронной почты контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Задает или возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Задает или возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        /// <summary>
        /// Задает или возвращает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        // IDataErrorInfo implementation
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Name):
                        if (string.IsNullOrWhiteSpace(Name))
                            return "Name is required.";
                        if (Name.Length > 100)
                            return "Name cannot be longer than 100 characters.";
                        break;

                    case nameof(PhoneNumber):
                        if (string.IsNullOrWhiteSpace(PhoneNumber))
                            return "Phone number is required.";
                        if (PhoneNumber.Length > 100)
                            return "Phone number cannot be longer than 100 characters.";
                        if (!Regex.IsMatch(PhoneNumber, @"^[\d\+\-\(\)\s]+$"))
                            return "Phone number can only contain digits, +, -, (, ) and spaces.";
                        break;

                    case nameof(Email):
                        if (string.IsNullOrWhiteSpace(Email))
                            return "Email is required.";
                        if (Email.Length > 100)
                            return "Email cannot be longer than 100 characters.";
                        if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            return "Invalid email format.";
                        break;
                }
                return null;
            }
        }

        public string Error => null;

        /// <summary>
        /// Инициализирует новый экземпляр класса Contact с указанными именем, номером телефона и электронной почтой.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Номер телефона контакта.</param>
        /// <param name="email">Электронная почта контакта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Contact без параметров.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Создает копию текущего контакта.
        /// </summary>
        /// <returns> Копия объекта Contact.</returns>
        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }
    }
}
