//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureTravelsVer1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.Bookings = new HashSet<Booking>();
        }

        public Nullable<double> Y = null;
        public int FlightId { get; set; }
        public string FlightCode { get; set; }
        public string FlightName { get; set; }
        public string FlightCarrier { get; set; }
        public int SeatsAvailable { get; set; }
        public int BaseFare { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public System.DateTime departureDateTime { get; set; }
        public System.DateTime arrivalDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
