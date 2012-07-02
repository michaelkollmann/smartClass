using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMAppointment : VMBase
    {
        private MAppointment _appointment;

        public MAppointment Appointment
        {
            get { return _appointment; }
            private set
            {
                if (_appointment != value)
                {
                    _appointment = value;
                    RaisePropertyChanged("Appointment");
                }
            }
        }
        public VMLesson Lesson
        {
            get { return new VMLesson(_appointment.Lesson); }
            private set
            {
                if (_appointment.Lesson != value.Lesson)
                {
                    _appointment.Lesson = value.Lesson;
                    RaisePropertyChanged("Lesson");
                }
            }
        }
        public VMKind Kind
        {
            get { return new VMKind(_appointment.Kind); }
            private set
            {
                if (_appointment.Kind != value.Kind)
                {
                    _appointment.Kind = value.Kind;
                    RaisePropertyChanged("Kind");
                }
            }
        }
        public string Note
        {
            get { return _appointment.Note; }
            set
            {
                if (_appointment.Note != value)
                {
                    _appointment.Note = value;
                    RaisePropertyChanged("Note");
                }
            }
        }
        public DateTime Date
        {
            get { return _appointment.Date; }
            set
            {
                if (_appointment.Date != value)
                {
                    _appointment.Date = value;
                    RaisePropertyChanged("Date");
                }
            }
        }
        public bool IsDone
        {
            get { return _appointment.IsDone; }
            set
            {
                if (_appointment.IsDone != value)
                {
                    _appointment.IsDone = value;
                    RaisePropertyChanged("IsDone");
                }
            }
        }
    }
}
