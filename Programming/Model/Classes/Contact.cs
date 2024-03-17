using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Contact
    {
        private string _name;
        private string _surname;
        private int _number;

        public string Name 
        { 
            get { return _name; } 
            set 
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            } 
        }

        public string Surname 
        { 
            get { return _surname; } 
            set 
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value; 
            } 
        }

        public int Number 
        { 
            get { return _number; } 
            set 
            {
                Validator.AssertOnPositiveValue(value);
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

        private static void AssertStringContainsOnlyLetters(string value)
        {
            if (!(value.All(c => Char.IsLetter(c) && c <= 'z'))) throw new ArgumentException(nameof(value));

        }

    }
}
