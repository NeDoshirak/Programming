using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        private string _filePath;

        public ContactSerializer()
        {
            string documentsPath = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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

        public void SaveContact(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public Contact LoadContact()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("Файл контактов не найден.");
            }

            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<Contact>(json) ;
        }
    }

}
