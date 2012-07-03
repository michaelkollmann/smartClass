using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace smartClass.Model
{
    public class MSchedule
    {
        private string _name;
        private Color _color;
        private List<MLesson> _lessons;
        private List<MAppointment> _appointments;

        public MSchedule()
            : this(new List<MLesson>(), new List<MAppointment>(), new Color(), string.Empty) { }
        public MSchedule(List<MLesson> Lessons, List<MAppointment> Appointments, Color Color, string Name)
        {
            this.Lessons = Lessons;
            this.Appointments = Appointments;
            this.Color = Color;
            this.Name = Name;
        }

        #region Properties
        public List<MLesson> Lessons
        {
            get { return _lessons; }
            set { _lessons = value; }
        }
        public List<MAppointment> Appointments
        {
            get { return _appointments; }
            set { _appointments = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        #endregion
    }
}
