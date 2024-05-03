using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о точке в простанстве.
    /// </summary>
    internal class Point2D
    {
        /// <summary>
        /// Координата х для точки
        /// </summary>
        private double _x;

        /// <summary>
        /// Координата у для точки
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задаёт координату х. Должна быть неотрицательной. 
        /// </summary>
        public double X
        {
            get { return _x; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт координату у. Должна быть неотрицательной. 
        /// </summary>
        public double Y
        {
            get { return _y; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x"> Координата х. Должна быть неотрицательной.</param>
        /// <param name="y"> Rоординату у. Должна быть неотрицательной.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
