using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.MODEL
{
    public class AppoinmentModel
    {
        public int id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Customercontact { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public string VehicleId { get; set; }
        public Nullable<int> MechanicId { get; set; }
    }
}
