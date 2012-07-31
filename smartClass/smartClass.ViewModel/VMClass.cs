using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMClass : VMBase
    {
        private MClass _class;

        public VMClass(MClass Class)
        {
            this.Model = Class;
        }

        public MClass Model
        {
            get
            {
                return _class;
            }
            private set
            {
                if (_class != value)
                {
                    _class = value as MClass;
                    RaisePropertyChanged("Model");
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
