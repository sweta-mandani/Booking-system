
using DA.MODEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.IBL
{
   public interface IVehicle
    {
        IEnumerable<VehicleModel> GetVehicle();
        VehicleModel GetvehicleById(int id);
        void Insertvehicle(VehicleModel v);
        void Updatevehicle(VehicleModel v);
        void Deletevehicle(int id);
        

    }
}
