namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccomodationWithRoom")]
    public partial class AccomodationWithRoom
    {
        [Key]
        public int AccomodationRoomTID { get; set; }

        public int AccomodationID { get; set; }

        public int AccRoomID { get; set; }

        [StringLength(25)]
        public string? AccWithRoomStatus { get; set; }
        //[ForeignKey("AccomodationID")]
        //public virtual AccomodationMain AccomodationMain { get; set; }
        //[ForeignKey("AccRoomID")]
        //public virtual AccomodationRoom AccomodationRoom { get; set; }
         
        public bool deleted { get; set; } = false;
        public bool isDefault { get; set; } = false;
    }
}
