using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{   /// <summary>
    /// Хранит данные о прямоугольнике и методы для работы с ним. 
    /// </summary>
    internal class Rectangle
    {
        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина прямоугольника. 
        /// </summary>
        private int _width;

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Общее количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Уникальный индефикатор прямоуголька.
        /// </summary>
        public int id { get; }

        /// <summary>
        /// Координаты точки центра прямоугольника. 
        /// </summary>
        public Point2D Center { get; set; }


        /// <summary>
        /// Возвращает и задаёт ширину. Не должно быть отрицательным.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт высоту. Не должно быть отрицательным.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника. Должно быть объектом перечисления Colors. <see cref="Colors">
        /// </summary>
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (int.TryParse(value, out var result1))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse(typeof(Colors), value, out var result)) throw new ArgumentException();
                _color = value;
            }
        }
        /// <summary>
        /// Метод для получения общего количества прямоугольников.
        /// </summary>
        /// <returns>Колтчество прямоугольников.</returns>
        public static int AllRectanglesCount() { return _allRectanglesCount; }

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Rectangle">
        /// </summary>
        /// <param name="height">Высота. Не должна быть отрицательной.</param>
        /// <param name="width">Ширина. Не должна быть отрицательной.</param>
        /// <param name="color">Цвет прямоугольника. Должно быть объектом перечисления Colors.</param>
        /// <param name="x">Координата x. <see cref="Point2D"></param>
        /// <param name="y">Координата y. <see cref="Point2D"></param>
        public Rectangle(int height, int width, string color, double x, double y)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = new Point2D(x, y);
            _allRectanglesCount++;
            id = _allRectanglesCount;


        }

        /// <summary>
        /// Пустой конструктор класса. <see cref="Rectangle">
        /// </summary>
        public Rectangle() { }

        /// <summary>
        /// Преобразует данные о прямоугольнике в строку.
        /// </summary>
        /// <returns>Строка с данными о прямоугольнике.<see cref="Rectangle"> </returns>
        public override string ToString()
        {
            return $"{id}: X: {Center.X} Y:{Center.Y} H: {_height} W: {_width}";
        }
    }
}
