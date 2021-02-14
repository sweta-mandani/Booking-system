using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.MODEL
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
