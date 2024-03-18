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
        private static int _allRectanglesCount;
        public int id {  get; } 
        public Point2D Center { get; set; }
             
        public double Length 
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

        public static int AllRectanglesCount() { return _allRectanglesCount; }

        public Rectangle(double lenght, double wide, string color, double x, double y)
        {
            Length = lenght;
            Wide = wide;
            Color = color;
            Center = new Point2D(x, y);
            _allRectanglesCount++;
            id = _allRectanglesCount;


        }

        public Rectangle() { } 
    }
}
