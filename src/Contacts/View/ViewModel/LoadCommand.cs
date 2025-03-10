using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        private ContactSerializer _serializer;
        private Action<Contact> _setContact;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var contact = _serializer.LoadContact();
            _setContact(contact);
        }

        public LoadCommand(ContactSerializer serializer, Action<Contact> setContact)
        {
            _serializer = serializer;
            _setContact = setContact;
        }
    }
}
