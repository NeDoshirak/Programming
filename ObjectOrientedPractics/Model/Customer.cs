using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        public readonly int Id = IdGenerator.GetNextId;

        private string _fullname;
        private string _address;

        public string Fullname 
        {
            get { return _fullname; }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, "fullname");
                _fullname = value; 
            } 
        }

        public string Address { 
            get { return _address; } 
            set 
            {
                ValueValidator.AssertStringOnLength(value, 500, "address");
            } 
        }

        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
        }

        public Customer() { }
    }
}
