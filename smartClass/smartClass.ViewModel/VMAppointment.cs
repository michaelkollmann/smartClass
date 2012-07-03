using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMAppointment : VMBase, IVMBase
    {
        private MAppointment _appointment;
        private MSchedule _schedule;

        public VMAppointment(MAppointment Appointment, MSchedule Schedule)
        {
            this.Model = Appointment;
            _schedule = Schedule;
        }

        public IMBase Model
        {
            get
            {
                return _appointment;
            }
            private set
            {
                if (value.GetType().Equals(typeof(MAppointment)))
                {
                    if (_appointment != value)
                    {
                        _appointment = value as MAppointment;
                        RaisePropertyChanged("Model");
                    }
                }
            }
        }
        public VMLesson Lesson
        {
            get { return new VMLesson(_appointment.Lesson, _schedule); }
            private set
            {
                if (_appointment.Lesson != value.Model)
                {
                    _appointment.Lesson = value.Model as MLesson;
                    RaisePropertyChanged("Lesson");
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
        public VMKind Kind
        {
            get { return new VMKind(_appointment.Kind); }
            private set
            {
                _appointment.Kind = value.Model as MKind;
                RaisePropertyChanged("Kind");
            }
        }

    }
}
