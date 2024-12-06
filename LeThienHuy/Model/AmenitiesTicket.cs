namespace LeThienHuy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AmenitiesTicket
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AmenityID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TicketID { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual Amenity Amenity { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
