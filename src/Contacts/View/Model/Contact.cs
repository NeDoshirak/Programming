namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт с именем, номером телефона и электронной почтой.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Задает или возвращает имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Задает или возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Задает или возвращает электронную почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Конструктор для создания объекта Contact с указанными именем, номером телефона и электронной почтой.
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
        /// Конструктор по умолчанию для создания объекта Contact без параметров.
        /// </summary>
        public Contact() { }
    }
}
