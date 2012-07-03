using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using smartClass.Model;
using Windows.UI;

namespace smartClass.ViewModel
{
    public class VMSchedule : VMBase
    {
        private MSchedule _schedule;
        private ListToModel _appointments;

        public VMSchedule()
            : this(new MSchedule()) { }
        public VMSchedule(MSchedule Schedule)
        {
            this.Schedule = Schedule;
            _appointments = new ListToModel(Schedule.Appointments, typeof(VMAppointment), Schedule);
            _appointments.Add(new VMAppointment(new MAppointment(), Schedule));
            _appointments.Remove(_appointments[2]);
        }

        public MSchedule Schedule
        {
            get { return _schedule; }
            private set
            {
                if (_schedule != value)
                {
                    _schedule = value;
                    RaisePropertyChanged("Schedule");
                }
            }
        }
        public string Name
        {
            get { return _schedule.Name; }
            set
            {
                if (_schedule.Name != value)
                {
                    _schedule.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        public Color Color
        {
            get { return _schedule.Color; }
            set
            {
                if (_schedule.Color != value)
                {
                    _schedule.Color = value;
                    RaisePropertyChanged("Color");
                }
            }
        }
    }
}
