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

        /// <summary>
        /// Событие при обновлении любого поля объекта <see cref="Address"/>.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Индекс адреса (почтовый код).
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                // Проверка длины индекса.
                if (Convert.ToString(value).Length != 6)
                {
                    throw new ArgumentException("index");
                }
                _index = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Страна, в которой находится адрес.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "country");
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Город, в котором находится адрес.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "city");
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Улица, на которой находится адрес.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "street");
                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Здание, в котором находится адрес.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "building");
                _building = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Квартира, в которой находится адрес.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "apartment");
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Конструктор для инициализации адреса с параметрами.
        /// </summary>
        /// <param name="index">Индекс адреса (почтовый код).</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Здание.</param>
        /// <param name="apartment">Квартира.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Пустой конструктор для инициализации адреса без параметров.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Создает глубокую копию текущего адреса.
        /// </summary>
        /// <returns>Копия текущего адреса.</returns>
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

        /// <summary>
        /// Сравнивает текущий экземпляр <see cref="Address"/> с другим экземпляром.
        /// </summary>
        /// <param name="other">Другой экземпляр адреса для сравнения.</param>
        /// <returns>True, если адреса равны; иначе - False.</returns>
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

            // Сравнение всех полей адреса.
            return this.Index == other.Index &&
                   this.Country == other.Country &&
                   this.City == other.City &&
                   this.Street == other.Street &&
                   this.Building == other.Building &&
                   this.Apartment == other.Apartment;
        }
    }

}
