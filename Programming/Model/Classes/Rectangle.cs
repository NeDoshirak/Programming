using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Rectangle
    {
        private double _lenght;
        private double _wide;
        private string _color;

        public double Legth 
        { 
            get 
            { 
                return _lenght; 
            } 
            set
            {
                if (value < 0) throw new ArgumentException();
                _lenght = value;
            }
        }

        public double Wide 
        { 
            get 
            { 
                return _wide; 
            } 
            set 
            {
                if (value < 0) throw new ArgumentException();
                _wide = value;
            } 
        }

        public string Color
        {
            get 
            {
                return _color;
            }
            set 
            { 
                if (!(Enum.TryParse(typeof(Colors), value, out var result))) throw new ArgumentException();
                _color = value; 
            }
        }

        public Rectangle(double lenght, double wide, string color)
        {
            Legth = lenght;
            Wide = wide;
            Color = color;
        }

        public Rectangle() { } 
    }
}
