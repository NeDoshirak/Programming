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
    public class MainVM : ObservableObject
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
                SetProperty(_contact.Name, value, _contact, (u, n) => u.Name = n);
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
                SetProperty(_contact.PhoneNumber, value, _contact, (u, n) => u.PhoneNumber = n);
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
                SetProperty(_contact.Email, value, _contact, (u, n) => u.Email = n);
            }
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
