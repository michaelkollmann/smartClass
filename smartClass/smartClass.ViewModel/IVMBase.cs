using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public interface IVMBase
    {
        IMBase Model { get; }
    }
}
