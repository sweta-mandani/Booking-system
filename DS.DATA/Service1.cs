//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DS.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service1()
        {
            this.appoinments = new HashSet<appoinment>();
            this.Service_Booked = new HashSet<Service_Booked>();
            this.ServiceProviders = new HashSet<ServiceProvider>();
        }
    
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appoinment> appoinments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service_Booked> Service_Booked { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}
