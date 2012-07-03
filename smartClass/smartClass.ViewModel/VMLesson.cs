using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMLesson : VMBase, IVMBase
    {
        private MLesson _lesson;
        private MSchedule _schedule;

        public VMLesson(MLesson Lesson, MSchedule Schedule)
        {
            this.Model = Lesson;
            _schedule = Schedule;
        }

        public IMBase Model
        {
            get
            {
                return _lesson;
            }
            private set
            {
                if (value.GetType().Equals(typeof(MLesson)))
                {
                    if (_lesson != value)
                    {
                        _lesson = value as MLesson;
                        RaisePropertyChanged("Model");
                    }
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
