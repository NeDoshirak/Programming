using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для генерации уникальных идентификаторов
    /// </summary>
    internal static class IdGenerator
    {
        /// <remarks>
        /// Текущий идентификатор, увеличивается при каждом вызове GetNextId
        /// </remarks>
        private static int _currentId = 0;

        /// <summary>
        /// Получение следующего уникального идентификатора
        /// </summary>
        public static int GetNextId
        {
            get { return _currentId++; }
        }
    }

}
