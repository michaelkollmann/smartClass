﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class VMKind : VMBase, IVMBase
    {
        private MKind _kind;

        public VMKind(MKind Kind)
        {
            this.Model = Kind;
        }

        public IMBase Model
        {
            get
            {
                return _kind;
            }
            private set
            {
                if (value.GetType().Equals(typeof(MKind)))
                {
                    if (_kind != value)
                    {
                        _kind = value as MKind;
                        RaisePropertyChanged("Model");
                    }
                }
            }
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
    }
}
