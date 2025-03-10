using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Основная ViewModel для управления контактами.
    /// </summary>
    public class MainVM : ObservableObject
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _contact = new Contact();

        /// <summary>
        /// Сериализатор для работы с контактами.
        /// </summary>
        private static ContactSerializer _contactSerializer = new ContactSerializer();

        /// <summary>
        /// Команда для сохранения контакта.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команда для загрузки контакта.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Задает или возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                SetProperty(_contact.Name, value, _contact, (u, n) => u.Name = n);
            }
        }

        /// <summary>
        /// Задает или возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }
            set
            {
                SetProperty(_contact.PhoneNumber, value, _contact, (u, n) => u.PhoneNumber = n);
            }
        }

        /// <summary>
        /// Задает или возвращает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                SetProperty(_contact.Email, value, _contact, (u, n) => u.Email = n);
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса MainVM.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            _contactSerializer = new ContactSerializer();

            // Инициализация команды сохранения контакта
            SaveCommand = new RelayCommand(() => _contactSerializer.SaveContact(_contact));

            // Инициализация команды загрузки контакта
            LoadCommand = new RelayCommand(() =>
            {
                Contact contact = _contactSerializer.LoadContact();

                _contact = contact;
                Name = contact.Name;
                PhoneNumber = contact.PhoneNumber;
                Email = contact.Email;
            });
        }
    }
}
