using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Subject
    {
        private string _title;
        private string _studyForm;
        private int _mark;

        public string Title { get { return _title; } set {  _title = value; } }

        public int Mark 
        { 
            get { return _mark; }
            set 
            {
                if ((value < 0) && (value > 5)) throw ArgumentException();
                _mark = value; 
            }
        }

        public string StudyForm 
        { 
            get { return _studyForm; } 
            set 
            {
                if (!(Enum.TryParse(typeof(StudyForm), value, out var result))) throw new ArgumentException();
                _studyForm = value; 
            } 
        }
        
        public Subject (string title, string studyForm, int mark)
        {
            Title = title;
            StudyForm = studyForm;
            Mark = mark;
        }
    }
}
