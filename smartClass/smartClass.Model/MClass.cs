using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartClass.Model
{
    public class MClass : MBase
    {
        private string _name;

        public MClass()
            : this(-1, string.Empty) { }
        public MClass(int ID, string Name)
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
        #endregion
    }
}
