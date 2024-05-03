using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Класс для хранения данных о кольце.
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Центр кольца. <see cref="Point2D">
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Внутренний радиус кольца. Не должен быть отрицательным.
        /// </summary>
        private double _radiusInternal;

        /// <summary>
        /// Внешний радиус кольца. Не должен быть отрицательным.
        /// </summary>
        private double _radiusExternal;

        /// <summary>
        /// Площадь кольца. Вычисляемое.
        /// </summary>
        public double Area
        {
            get
            {
                return GetCircleArea(_radiusExternal) - GetCircleArea(_radiusInternal);
            }
        }
        /// <summary>
        /// Задаёт и возвращает центр кольца. <see cref="Point2D">
        /// </summary>
        public Point2D Center { get { return _center; } set { _center = value; } }

        /// <summary>
        /// Задаёт и возвращает внутренний радиус кольца. Не должен быть отрицательным и должен быть меньше внешнего.
        /// </summary>
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
        /// <summary>
        /// Задаёт и возвращает внешний радиус кольца. Не должен быть отрицательным и должен быть больш внутреннего.  
        /// </summary>
        public double RadiusExternal
        {
            get { return _radiusExternal; }
            set
            {
                if (value < _radiusInternal) throw new ArgumentException(nameof(value));
                _radiusExternal = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Ring">
        /// </summary>
        /// <param name="center">Центр кольца. <see cref="Point2D"></param>
        /// <param name="radiusInternal">Внутренний радиус кольца. Не должен быть отрицательным и должен быть меньше внешнего.</param>
        /// <param name="radiusExternal">Внешний радиус кольца. Не должен быть отрицательным и должен быть больш внутреннего.</param>
        public Ring(Point2D center, int radiusInternal, int radiusExternal)
        {
            Center = center;
            RadiusInternal = radiusInternal;
            RadiusExternal = radiusExternal;
        }
        /// <summary>
        /// Пустой конструк класса.
        /// </summary>
        public Ring() { }

        /// <summary>
        /// Возврашает площадь круга.
        /// </summary>
        /// <param name="radius">Радиус круга. Не должен быть отрицательным.</param>
        /// <returns>Площадь круга.</returns>
        private double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
