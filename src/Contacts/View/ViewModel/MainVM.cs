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
    public class MainVM : INotifyPropertyChanged
    {
        private Contact _contact = new Contact();
        private static ContactSerializer _contactSerializer = new ContactSerializer();
        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }

        public string Name
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                _contact.Name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }
            set
            {
                _contact.PhoneNumber = value;
                NotifyPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                _contact.Email = value;
                NotifyPropertyChanged(nameof(Email));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainVM()
        {
            _contact = new Contact();
            _contactSerializer = new ContactSerializer();

            SaveCommand = new RelayCommand(() => _contactSerializer.SaveContact(_contact));
            LoadCommand = new RelayCommand(() =>
                                            {
                                                Contact contact = _contactSerializer.LoadContact();
                                                Name = contact.Name;
                                                PhoneNumber = contact.PhoneNumber;
                                                Email = contact.Email;
                                            });
        }
    }
}
