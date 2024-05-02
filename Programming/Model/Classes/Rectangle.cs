using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Rectangle
    {
        private int _height;
        private int _width;
        private string _color;
        private static int _allRectanglesCount;
        public int id {  get; } 
        public Point2D Center { get; set; }
             
        public int Width
        { 
            get 
            { 
                return _width; 
            } 
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        public int Height
        { 
            get 
            { 
                return _height; 
            } 
            set 
            {
                Validator.AssertOnPositiveValue(value);
                _height = value;
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

        public Rectangle(int height, int width, string color, double x, double y)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = new Point2D(x, y);
            _allRectanglesCount++;
            id = _allRectanglesCount;


        }

        public Rectangle() { }

        public override string ToString()
        {
            return $"{id}: X: {Center.X} Y:{Center.Y} H: {_height} W: {_width}";
        }
    }
}
