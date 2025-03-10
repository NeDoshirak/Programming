using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact : ObservableObject
    {
        private string _name;

        private string _phoneNumber;

        private string _email;

        public string Name 
        { 
            get { return _name; } 
            set { SetProperty(ref _name, value); } 
        }

        public string PhoneNumber 
        { 
            get { return _phoneNumber; } 
            set { SetProperty(ref _phoneNumber, value); } 
        } 

        public string Email 
        { 
            get { return _email; } 
            set { SetProperty(ref _email, value); } 
        }

        public Contact(string name, string phoneNumber, string email)
        { 
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Contact() { }
    }
}
