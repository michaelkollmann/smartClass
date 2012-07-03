using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMClass : VMBase, IVMBase
    {
        private MClass _class;
        private MSchedule _schedule;

        public VMClass(MClass Class, MSchedule Schedule)
        {
            this.Model = Class;
            _schedule = Schedule;
        }

        public IMBase Model
        {
            get
            {
                return _class;
            }
            private set
            {
                if (value.GetType().Equals(typeof(MLesson)))
                {
                    if (_class != value)
                    {
                        _class = value as MClass;
                        RaisePropertyChanged("Model");
                    }
                }
            }
        }
        public string Name
        {
            get { return _class.Name; }
            set
            {
                if (_class.Name != value)
                {
                    _class.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
    }
}
