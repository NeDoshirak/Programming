using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    using System;
    using System.Collections.ObjectModel;
    using System.IO;
    using Newtonsoft.Json;

    public class ContactSerializer
    {
        private readonly string _filePath;

        public ContactSerializer()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string contactsDirectory = Path.Combine(documentsPath, "Contacts");
            _filePath = Path.Combine(contactsDirectory, "contacts.json");

            if (!Directory.Exists(contactsDirectory))
            {
                Directory.CreateDirectory(contactsDirectory);
            }
        }

        public void SaveContacts(ObservableCollection<Contact> contacts)
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public ObservableCollection<Contact> LoadContacts()
        {
            if (!File.Exists(_filePath))
            {
                return new ObservableCollection<Contact>();
            }

            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json) ?? new ObservableCollection<Contact>();
        }
    }
}

