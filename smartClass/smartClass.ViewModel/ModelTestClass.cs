using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class ModelTestClass
    {
        private MSchedule _schedule;

        public ModelTestClass()
        {
            _schedule = new MSchedule();
            
            MLesson lesson1 = new MLesson();
            MLesson lesson2 = new MLesson();
            MLesson lesson3 = new MLesson();
            
            MAppointment appointment1 = new MAppointment() { Lesson = lesson1 };
            MAppointment appointment2 = new MAppointment() { Lesson = lesson2 };
            MAppointment appointment3 = new MAppointment() { Lesson = lesson3 };

            _schedule.Add(appointment1);
            _schedule.Add(appointment2);
            _schedule.Add(appointment3);

            _schedule.Add(lesson1);
            _schedule.Add(lesson2);
            _schedule.Add(lesson3);

            foreach (MLesson lesson in _schedule)
            {
                
            }
        }
    }
}
