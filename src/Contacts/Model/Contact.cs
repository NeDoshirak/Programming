using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        /// Максимальная длина имени контакта.
        /// </summary>
        private const int MaxNameLength = 100;

        /// <summary>
        /// Максимальная длина номера телефона.
        /// </summary>
        private const int MaxPhoneNumberLength = 100;

        /// <summary>
        /// Максимальная длина электронной почты.
        /// </summary>
        private const int MaxEmailLength = 100;

        /// <summary>
        /// Регулярное выражение для маски ввода номера телефона.
        /// </summary>
        public static readonly Regex PhoneNumberMask = new Regex(@"^[0-9+() -]*$");

        /// <summary>
        /// Регулярное выражение для проверки корректности номера телефона.
        /// </summary>
        public static readonly Regex PhoneNumberRegex =
            new Regex(@"^\+?(\d{1,3})?[-. (]*(\d{1,4})[-. )]*(\d{1,4})[-. ]*(\d{1,9})$");

        /// <summary>
        /// Регулярное выражение для проверки корректности электронной почты.
        /// </summary>
        public static readonly Regex EmailRegex =
            new Regex(@"^[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+$");

        /// <summary>
        /// Поле для хранения ошибок.
        /// </summary>
        private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();

        /// <summary>
        /// Задает или возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                ValidateProperty(nameof(Name), value);
                SetProperty(ref _name, value); 
            }
        }

        /// <summary>
        /// Задает или возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                ValidateProperty(nameof(PhoneNumber), value);
                SetProperty(ref _phoneNumber, value); 
            }
        }

        /// <summary>
        /// Задает или возвращает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set {
                ValidateProperty(nameof(Email), value);
                SetProperty(ref _email, value); 
            }
        }

        /// <summary>
        /// Индексатор для валидации свойств объекта (реализация IDataErrorInfo).
        /// Выполняет проверки для указанного свойства и возвращает сообщение об ошибке или null, если ошибок нет.
        /// </summary>
        /// <param name="columnName">Имя проверяемого свойства</param>
        /// <returns>Сообщение об ошибке или null, если свойство валидно</returns>
        public string this[string columnName] => _errors.TryGetValue(columnName, out var error) ? error : null;


        private void ValidateProperty(string propertyName, string value)
        {
            string error = null;

            switch (propertyName)
            {
                case nameof(Name):
                    if (string.IsNullOrWhiteSpace(value))
                        error = "Имя не может быть пустым.";
                    else if (value.Length > 100)
                        error = "Имя не должно превышать 100 символов.";
                    break;

                case nameof(Number):
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        error = "Номер телефона не может быть пустым.";
                    }
                    else
                    {
                        if (!PhoneNumberMask.IsMatch(value))
                            error = "Номер телефона содержит недопустимые символы.";
                        else if (value.Length > MaxPhoneNumberLength)
                            error = "Номер телефона не должен превышать 100 символов.";
                        else if (!PhoneNumberRegex.IsMatch(value))
                            error = "Номер телефона имеет неверный формат. Пример: +7 (123) 456-7890";
                    }
                    break;

                case nameof(Email):
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        error = "Email не может быть пустым.";
                    }
                    else
                    {
                        if (value.Length > MaxEmailLength)
                            error = "Email не должен превышать 100 символов.";
                        else if (!EmailRegex.IsMatch(value))
                            error = "Email имеет неверный формат. Пример: example@domain.com";
                    }
                    break;
            }

            if (error != null)
                _errors[propertyName] = error;
            else
                _errors.Remove(propertyName);
        }

        /// <summary>
        /// Реализация свойства Error интерфейса IDataErrorInfo.
        /// Всегда возвращает null, что означает отсутствие ошибок на уровне объекта.
        /// </summary>
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
