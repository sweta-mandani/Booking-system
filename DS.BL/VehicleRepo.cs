using DA.IBL;
using DS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.BL
{
    class VehicleRepo : IVehicle

    {
        private ServiceEntities2 _db;

        public VehicleRepo(ServiceEntities2 db)
        {
            this._db = db;
        }
        public void Deletevehicle(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetVehicle()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetvehicleById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertvehicle(Vehicle v)
        {
            _db.Vehicles.Add(v);
            _db.SaveChanges();
        }

        

        public void Updatevehicle(Vehicle v)
        {
            throw new NotImplementedException();
        }
    }
}
