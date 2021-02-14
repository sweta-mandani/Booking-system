using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.MODEL
{
   public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public Nullable<int> DealerId { get; set; }
        public string Password { get; set; }

    }
}
