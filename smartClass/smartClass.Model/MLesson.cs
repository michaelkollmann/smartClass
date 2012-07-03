using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartClass.Model
{
    public class MLesson : IMBase
    {
        private MClass _class;
        private int _id;
        private DayOfWeek _day;
        private TimeSpan _from;
        private TimeSpan _to;
        private string _room;

        public MLesson()
            : this(new MClass(), -1, DayOfWeek.Monday, TimeSpan.FromTicks(0), TimeSpan.FromTicks(0), string.Empty) { }
        public MLesson(MClass Class, int ID, DayOfWeek Day, TimeSpan From, TimeSpan To, string Room)
        {
            this.Class = Class;
            this.ID = ID;
            this.Day = Day;
            this.From = From;
            this.To = To;
            this.Room = Room;
        }

        #region Properties
        public MClass Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public DayOfWeek Day
        {
            get { return _day; }
            set { _day = value; }
        }
        public TimeSpan From
        {
            get { return _from; }
            set { _from = value; }
        }
        public TimeSpan To
        {
            get { return _to; }
            set { _to = value; }
        }
        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

    }
}
