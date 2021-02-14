using DS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.IBL
{
    public interface IAppoinment
    {
        IEnumerable<appoinment> Appoinments { get; }
    }
}
