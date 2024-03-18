using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Ring
    {
        private Point2D _center;
        private double _radiusInternal;
        private double _radiusExternal;
        public double Area { 
            get 
            { 
                return GetCircleArea(_radiusExternal) - GetCircleArea(_radiusInternal);
            } 
        }
        
        public Point2D Center { get { return _center; } set { _center = value; } }

        public double RadiusInternal 
        {
            get { return _radiusInternal; } 
            set 
            {
                Validator.AssertOnPositiveValue(value);
                if (value > _radiusExternal) throw new ArgumentException(nameof(value));
                _radiusInternal = value; 
            } 
        }

        public double RadiusExternal 
        {
            get { return _radiusExternal; }
            set
            {
                if (value < _radiusInternal) throw new ArgumentException(nameof(value));
                _radiusExternal = value;
            }
        }

        public Ring(Point2D center, int radiusInternal, int radiusExternal)
        {
            Center = center;
            RadiusInternal = radiusInternal;
            RadiusExternal = radiusExternal;
        }

        public Ring() { }

        private double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2); 
        }
    }
}
