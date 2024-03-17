using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Movie
    {
        private string _title;
        private int _duration;
        private int _year;
        private string _genre;
        private int _rating;

        public string Title { get { return _title; } set { _title = value; } }

        public int Duration { get { return _duration; } 
            set 
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            } 
        }

        public int Year { get { return _year; } 
            set 
            { 
                Validator.AssertValueInRange(value,1900,2024);
                _year = value; 
            } 
        }

        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (!(Enum.TryParse(typeof(Genre), value, out var result))) throw new ArgumentException();
                _genre = value;
            }
        }

        public int Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value,0,10);
                _rating = value;
            }
        }

        public Movie (string title, int duration,  int year, string genre, int rating)
        {
            Title = title;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        public Movie() { }
    }
}
