using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMKind : ViewModelBase
    {
        private MKind _kind;

        public VMKind(MKind Kind)
        {
            this.Kind = Kind;
        }

        public string Name
        {
            get { return _kind.Name; }
            set
            {
                if (_kind.Name != value)
                {
                    _kind.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        public MKind Kind
        {
            get { return _kind; }
            private set
            {
                if (_kind != value)
                {
                    _kind = value;
                    RaisePropertyChanged("Kind");
                }
            }
        }
    }
}
