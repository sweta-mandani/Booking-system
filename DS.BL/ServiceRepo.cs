using DA.IBL;
using DS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.BL
{
    public class ServiceRepo: IServiceRepo
    
    {
        private ServiceEntities2 _db;

        public ServiceRepo(ServiceEntities2 db)
        {
            this._db = db;
        }

        public void DeleteService(Service1 s)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service1> GetallService()
        {
            throw new NotImplementedException();
        }

        public void InsertService(Service1 s)
        {
            _db.Service1.Add(s);
            _db.SaveChanges();
        }

        public void UpdateService(Service1 s)
        {
            throw new NotImplementedException();
        }


    }
}
