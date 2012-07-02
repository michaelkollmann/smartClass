using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace smartClass.Model
{
    public class MSchedule : IList<MLesson>, IList<MAppointment>
    {
        private IList<MLesson> _lessonlist = new List<MLesson>();
        private IList<MAppointment> _appointmentlist = new List<MAppointment>();
        private string _name;
        private Color _color;

        #region Properties
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

        #region IList<MLesson>
        public int IndexOf(MLesson item)
        {
            return _lessonlist.IndexOf(item);
        }

        public void Insert(int index, MLesson item)
        {
            _lessonlist.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _lessonlist.RemoveAt(index);
        }

        public MLesson this[int index]
        {
            get
            {
                return _lessonlist[index];
            }
            set
            {
                _lessonlist[index] = value;
            }
        }

        public void Add(MLesson item)
        {
            _lessonlist.Add(item);
        }

        public void Clear()
        {
            _lessonlist.Clear();
        }

        public bool Contains(MLesson item)
        {
            return _lessonlist.Contains(item);
        }

        public void CopyTo(MLesson[] array, int arrayIndex)
        {
            _lessonlist.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _lessonlist.Count; }
        }

        public bool IsReadOnly
        {
            get { return _lessonlist.IsReadOnly; }
        }

        public bool Remove(MLesson item)
        {
            return _lessonlist.Remove(item);
        }

        public IEnumerator<MLesson> GetEnumerator()
        {
            return _lessonlist.GetEnumerator();
        }

        IEnumerator<MLesson> IEnumerable<MLesson>.GetEnumerator()
        {
            return _lessonlist.GetEnumerator();
        }
        #endregion

        #region IList<MAppointment>
        public int IndexOf(MAppointment item)
        {
            return _appointmentlist.IndexOf(item);
        }

        public void Insert(int index, MAppointment item)
        {
            _appointmentlist.Insert(index, item);
        }

        MAppointment IList<MAppointment>.this[int index]
        {
            get
            {
                return _appointmentlist[index];
            }
            set
            {
                _appointmentlist[index] = value;
            }
        }

        public void Add(MAppointment item)
        {
            _appointmentlist.Add(item);
        }

        public bool Contains(MAppointment item)
        {
            return _appointmentlist.Contains(item);
        }

        public void CopyTo(MAppointment[] array, int arrayIndex)
        {
            _appointmentlist.CopyTo(array, arrayIndex);
        }

        public bool Remove(MAppointment item)
        {
            return _appointmentlist.Remove(item);
        }

        IEnumerator<MAppointment> IEnumerable<MAppointment>.GetEnumerator()
        {
            return _appointmentlist.GetEnumerator();
        }
        #endregion
    }
}
