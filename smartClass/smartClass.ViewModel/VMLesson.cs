using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMLesson : ViewModelBase
    {
        //TODO: ObservableCollection<VMAppointment> einfügen
        private MLesson _lesson;

        public VMLesson(MLesson Lesson)
        {
            this.Lesson = Lesson;
        }

        public MLesson Lesson
        {
            get { return _lesson; }
            private set
            {
                if (_lesson != value)
                {
                    _lesson= value;
                    RaisePropertyChanged("Lesson");
                }
            }
        }        
        public VMClass Class
        {
            get { return new VMClass(_lesson.Class); }
            private set
            {
                if (_lesson.Class != value.Class)
                {
                    _lesson.Class = value.Class;
                    RaisePropertyChanged("Class");
                }
            }
        }
        public string Room
        {
            get { return _lesson.Room; }
            set
            {
                if (_lesson.Room != value)
                {
                    _lesson.Room = value;
                    RaisePropertyChanged("Room");
                }
            }
        }
        public DayOfWeek Day
        {
            get { return _lesson.Day; }
            set
            {
                if (_lesson.Day != value)
                {
                    _lesson.Day = value;
                    RaisePropertyChanged("Day");
                }
            }
        }
        public TimeSpan From
        {
            get { return _lesson.From; }
            set
            {
                if (_lesson.From != value)
                {
                    _lesson.From = value;
                    RaisePropertyChanged("From");
                }
            }
        }
        public TimeSpan To
        {
            get { return _lesson.To; }
            set
            {
                if (_lesson.To != value)
                {
                    _lesson.To = value;
                    RaisePropertyChanged("To");
                }
            }
        }
    }
}
