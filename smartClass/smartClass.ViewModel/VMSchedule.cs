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

        public VMSchedule(MSchedule Schedule)
        {
            this.Schedule = Schedule;
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
