using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хрант данные об учебном предмете.
    /// </summary>
    internal class Subject
    {
        /// <summary>
        /// Название предмета.
        /// </summary>
        private string _title;
        /// <summary>
        /// Форма обучения на предмете.
        /// </summary>
        private string _studyForm;

        /// <summary>
        /// Оценка полученна на предмете.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Задаёт и возвращает название предмета.
        /// </summary>
        public string Title { get { return _title; } set {  _title = value; } }

        /// <summary>
        /// Задаёт и возвращает оценку по предмету. Она должна принадлежать интервалу от 1 до 5.
        /// </summary>
        public int Mark 
        { 
            get { return _mark; }
            set 
            {
                Validator.AssertValueInRange(value, 1, 5);
                _mark = value; 
            }
        }
        /// <summary>
        /// Задаёт возвращает форму обучения на предмете. Должна пренадлежать типу StudyForm. <see cref="StudyForm"></see>
        /// </summary>
        public string StudyForm 
        { 
            get { return _studyForm; } 
            set 
            {
                if (!(Enum.TryParse(typeof(StudyForm), value, out var result))) throw new ArgumentException();
                _studyForm = value; 
            } 
        }

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Subject"/>
        /// </summary>
        /// <param name="title">Название предмета.</param>
        /// <param name="studyForm">Форма обучения на предмете. Должна пренадлежать типу StudyForm. <see cref="StudyForm"></see></param>
        /// <param name="mark">Оценка по предмету. Она должна принадлежать интервалу от 1 до 5.</param>
        public Subject (string title, string studyForm, int mark)
        {
            Title = title;
            StudyForm = studyForm;
            Mark = mark;
        }
        
        /// <summary>
        /// Пустой конструктор класса.
        /// </summary>
        public Subject () { }
    }
}
