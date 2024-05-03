using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Контролирует пересечения геометрических объектов
    /// </summary>
    internal class CollisionManager
    {
        /// <summary>
        /// Контролирует пересечение прямоугольников.
        /// </summary>
        /// <param name="rectangle1"> Первый прямоугольник. Должен являться типом Rectangle.<see cref="Rectangle"></param>
        /// <param name="rectangle2">Второй прямоугольник. Должен являться типом Rectangle.<see cref="Rectangle"></param>
        /// <returns>Возвращает True, если прямоугольники пересекаются, False, если нет.</returns>
        static public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double halfLatitude = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
            double differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double halfLength = Math.Abs(rectangle1.Height + rectangle2.Height) / 2;
            return differenceX < halfLatitude && differenceY < halfLength;
        }

        /// <summary>
        /// Контролирует пересечение колец.
        /// </summary>
        /// <param name="rectangle1"> Первое кольцо. Должено являться типом Ring.<see cref="Ring"></param>
        /// <param name="rectangle2">Второй прямоугольник. Должено являться типом Ring.<see cref="Ring"></param>
        /// <returns>Возвращает True, если кольца пересекаются, False, если нет.</returns>
        static public bool IsCollision(Ring ring1, Ring ring2)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) + Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2));
            double sumOfExternalRadii = ring1.RadiusExternal + ring2.RadiusExternal;
            return hypotenuse < sumOfExternalRadii;
        }
    }
}
