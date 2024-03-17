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
        private Point2D Center;
             
        public double Legth 
        { 
            get 
            { 
                return _lenght; 
            } 
            set
            {
                Validator.AssertOnPositiveValue(value);
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
                Validator.AssertOnPositiveValue(value);
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
                if ((int.TryParse(value, out var result1)))
                {
                    throw new ArgumentException();
                }
                if (!(Enum.TryParse(typeof(Colors), value, out var result))) throw new ArgumentException();
                _color = value; 
            }
        }

        public Rectangle(double lenght, double wide, string color, double x, double y)
        {
            Legth = lenght;
            Wide = wide;
            Color = color;
            Center = new Point2D(x, y);
        }

        public Rectangle() { } 
    }
}
