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
    
    public partial class appoinment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public appoinment()
        {
            this.Service_Booked = new HashSet<Service_Booked>();
            this.ServiceProviders = new HashSet<ServiceProvider>();
        }
    
        public int id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Customercontact { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public string VehicleId { get; set; }
        public Nullable<int> MechanicId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Mechanic Mechanic { get; set; }
        public virtual Service1 Service1 { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service_Booked> Service_Booked { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}
