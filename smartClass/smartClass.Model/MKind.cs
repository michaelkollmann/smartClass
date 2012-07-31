using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartClass.Model
{
    public class MKind : MBase
    {
        private string _name;

        public MKind()
            : this(-1, string.Empty) { }
        public MKind(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
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
