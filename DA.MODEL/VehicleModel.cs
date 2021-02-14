using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.MODEL
{
    public class VehicleModel
    {
        public string License_Plate { get; set; }
        public string Chassis_No { get; set; }
        public string OwerName { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> MechanicId { get; set; }
    }
}
