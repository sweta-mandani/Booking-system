using DA.MODEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.IBL
{
    public interface IMechanicRepo
    {
        IEnumerable<MechanicModel> GetallMechanic();
        public void InsertMechanic(MechanicModel m);
        public void UpdateMechanic(MechanicModel m);
    }
}
