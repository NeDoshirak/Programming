using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Класс для создания случайных прямоугольников.
    /// </summary>
    internal class RectangleFactory
    {
        /// <summary>
        /// Переменная для генерации случайных чисел.
        /// </summary>
        static Random rnd = new Random();

        /// <summary>
        /// Метод для создания случайного прямоугольника.
        /// </summary>
        /// <returns>Прямоугольник. <see cref="Rectangle"> </returns>
        static public Rectangle Randomize()
        {
            return new Rectangle(rnd.Next(1, 100), rnd.Next(1, 100), "Green", rnd.Next(1, 406), rnd.Next(1, 363));
        }
    }
}
