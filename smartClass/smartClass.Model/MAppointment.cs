using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartClass.Model
{
    public class MAppointment : IBase
    {
        private MLesson _lesson;
        private MKind _kind;
        private int _id;
        private DateTime _date;
        private string _note;
        private bool _isdone;

        public MAppointment()
            : this(new MLesson(), new MKind(), -1, DateTime.Now, string.Empty, false) { }
        public MAppointment(MLesson Lesson, MKind Kind, int ID, DateTime Date, string Note, bool IsDone)
        {
            this.Lesson = Lesson;
            this.Kind = Kind;
            this.ID = ID;
            this.Date = Date;
            this.Note = Note;
            this.IsDone = IsDone;
        }

        #region Properties
        public MLesson Lesson
        {
            get { return _lesson; }
            set { _lesson = value; }
        }
        public MKind Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
        public bool IsDone
        {
            get { return _isdone; }
            set { _isdone = value; }
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        #endregion
    }
}
