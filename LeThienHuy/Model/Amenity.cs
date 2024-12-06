namespace LeThienHuy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Amenity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Amenity()
        {
            AmenitiesTickets = new HashSet<AmenitiesTicket>();
            CabinTypes = new HashSet<CabinType>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Service { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AmenitiesTicket> AmenitiesTickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CabinType> CabinTypes { get; set; }
    }
}
