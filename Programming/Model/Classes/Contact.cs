using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Contact
    {
        private string _name;
        private string _surname;
        private int _number;

        public string Name { get { return _name; } set {  _name = value; } }

        public string Surname { get { return _surname; } set { _surname = value; } }

        public int Number 
        { 
            get { return _number; } 
            set 
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _number = value; 
            } 
        }
        public Contact (string name, string surname, int number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public Contact() { }

    }
}
