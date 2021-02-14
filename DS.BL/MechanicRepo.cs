using DA.IBL;
using DA.MODEL;
using DS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.BL
{
   public class MechanicRepo: IMechanicRepo
    { 
    private ServiceEntities2 _db;

    public MechanicRepo(ServiceEntities2 db)
    {
        this._db = db;
    }

        public IEnumerable<MechanicModel> GetallMechanic()
        {
            throw new NotImplementedException();
        }

        public void InsertMechanic(Mechanic m)
    {
        _db.Mechanics.Add(m);
        _db.SaveChanges();
    }

        public void InsertMechanic(MechanicModel m)
        {
            throw new NotImplementedException();
        }

        public void UpdateMechanic(Mechanic m)
    {
        throw new NotImplementedException();
    }

        public void UpdateMechanic(MechanicModel m)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Mechanic> IMechanicRepo.GetallMechanic()
        {
            return _db.Mechanics.ToList();
        }
    }
}
