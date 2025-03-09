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
    public class SaveCommand : ICommand
    {
        private ContactSerializer _serializer;
        private Contact _contact;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _serializer.SaveContact(_contact);
        }

        public SaveCommand(ContactSerializer serializer, Contact contact)
        {
            _serializer = serializer;
            _contact = contact;
        }
    }
}
