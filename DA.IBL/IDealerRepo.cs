

using DA.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.IBL
{
   public interface IDealerRepo
    {
        DealerModel GetDealerById(int id);
        IEnumerable<DealerModel> GetallDealer();
        public int InsertDealer(DealerModel d);
        public int UpdateDealer(DealerModel d);
    }
}
