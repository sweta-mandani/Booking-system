using DA.MODEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.IBL
{
   public interface IServiceRepo
    {
        IEnumerable<ServiceModel> GetallService();
        public void InsertService(ServiceModel s);
        public void UpdateService(ServiceModel s);
        public void DeleteService(ServiceModel s);
    }
}
