using ObjectOrientedPractics.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address : ICloneable, IEquatable<Address>
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        public int Index { get { return _index; } 
            set 
            { 
                if (Convert.ToString(value).Length != 6)
                {
                    throw new ArgumentException("index");
                }
                _index = value; 
            } 
        }

        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "country");
                _country = value;
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "city");
                _city = value;
            }
        }

        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "street");
                _street = value;
            }
        }

        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "building");
                _building = value;
            }
        }

        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "apartment");
                _apartment = value;
            }
        }

        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        public Address() { }

        public object Clone()
        {
            return new Address(
                this.Index,
                this.Country,
                this.City,
                this.Street,
                this.Building,
                this.Apartment);
        }

        public bool Equals(Address other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            var result = this.Index == other.Index;
            result &= this.Country == other.Country;
            result &= this.City == other.City;
            result &= this.Street == other.Street;
            result &= this.Building == other.Building;
            result &= this.Apartment == other.Apartment;

            return result;
        }
    }
}
