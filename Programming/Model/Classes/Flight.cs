using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Flight
    {
        private string _departure;
        private string _destination;
        private int _time;

        public string Destination { get { return _destination; } set {  _destination = value; } }
        public string Departure { get { return _departure; } set { _departure = value; } }
        public int Time 
        { 
            get 
            { 
                return _time; 
            } 
            set 
            { 
                Validator.AssertOnPositiveValue(value);
                _time = value; 
            } 
        }

        public Flight(string departure, string destination, int time )
        {
            Time = time;
            Departure = departure;
            Destination = destination;
        }

        public Flight() { }
    }
}
