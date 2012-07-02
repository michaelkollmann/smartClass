using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartClass.Model
{
    public class MClass : IBase
    {
        private int _id;
        private string _name;

        public MClass()
            : this(Name : string.Empty, ID : -1) { }
        public MClass(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
