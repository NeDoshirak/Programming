using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours { get { return _hours; } 
            set 
            {
                Validator.AssertValueInRange(value, 0, 23);
                _hours = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60);
                _minutes = value;
            }
        }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60);
                _seconds = value;
            }
        }

        public Time( int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time() { }
    }
}
