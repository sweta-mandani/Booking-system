//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerWebapp1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service_Booked
    {
        public int id { get; set; }
        public Nullable<int> appoinmentId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual appoinment appoinment { get; set; }
        public virtual Service1 Service1 { get; set; }
    }
}
