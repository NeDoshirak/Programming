using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    /// <summary>
    /// Класс для сериализации и десериализации контактов в формате JSON.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу, в котором хранятся контакты.
        /// </summary>
        private string _filePath;

        /// <summary>
        /// Конструктор класса ContactSerializer.
        /// Инициализирует путь к файлу контактов и создает необходимые директории и файл, если они не существуют.
        /// </summary>
        public ContactSerializer()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string contactsDirectory = Path.Combine(documentsPath, "Contacts");
            _filePath = Path.Combine(contactsDirectory, "contacts.json");

            if (!Directory.Exists(contactsDirectory))
            {
                Directory.CreateDirectory(contactsDirectory);
            }

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "{}");
            }
        }

        /// <summary>
        /// Сохраняет контакт в файл в формате JSON.
        /// </summary>
        /// <param name="contact">Контакт, который необходимо сохранить.</param>
        public void SaveContact(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Загружает контакт из файла.
        /// </summary>
        /// <returns>Десериализованный объект Contact.</returns>
        /// <exception cref="FileNotFoundException">Выбрасывается, если файл контактов не найден.</exception>
        public Contact LoadContact()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("Файл контактов не найден.");
            }

            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<Contact>(json);
        }
    }

}
