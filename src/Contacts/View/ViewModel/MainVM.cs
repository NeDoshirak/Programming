using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
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
        private Contact _selectedContact;

        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>()
        {
            new Contact("Егор","номер","почта"),
            new Contact("Ваня","номер","почта"),
            new Contact("Дима","номер","почта")
        };

        public Contact SelectedContact
        {
            get { return _selectedContact ?? new Contact(); }
            set { SetProperty(ref _selectedContact, value); }
        }

        public MainVM()
        {
        }
    }
}
