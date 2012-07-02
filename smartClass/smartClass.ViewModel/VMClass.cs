using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMClass : ViewModelBase
    {
        private MClass _class;

        public VMClass(MClass Class)
        {
            this.Class = Class;
        }

        public MClass Class
        {
            get { return _class; }
            private set
            {
                if (_class != value)
                {
                    _class = value;
                    RaisePropertyChanged("Class");
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
