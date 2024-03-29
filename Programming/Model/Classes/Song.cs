﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Song
    {
        private string _title;
        private int _duration;
        private string _author;

        public string Title { get { return _title; } set {  _title = value; } }

        public int Duration 
        { 
            get 
            { 
                return _duration;
            } 
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        public string Author { get { return _author; } set { _author = value; } }

        public Song (string title, int duration, string author)
        {
            Title = title;
            Duration = duration;
            Author = author;
        }

        public Song() { }
    }
}
