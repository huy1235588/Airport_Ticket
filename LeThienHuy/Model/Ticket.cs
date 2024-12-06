namespace LeThienHuy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            AmenitiesTickets = new HashSet<AmenitiesTicket>();
        }

        public int ID { get; set; }

        public int UserID { get; set; }

        public int ScheduleID { get; set; }

        public int CabinTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        [Required]
        [StringLength(14)]
        public string Phone { get; set; }

        [Required]
        [StringLength(9)]
        public string PassportNumber { get; set; }

        public int PassportCountryID { get; set; }

        [Required]
        [StringLength(6)]
        public string BookingReference { get; set; }

        public bool Confirmed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AmenitiesTicket> AmenitiesTickets { get; set; }

        public virtual CabinType CabinType { get; set; }

        public virtual Schedule Schedule { get; set; }

        public virtual User User { get; set; }
    }
}
