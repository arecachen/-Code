namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NTPAccomodationRoom")]
    public partial class NTPAccomodationRoom
    {
        [Key]
        public int NTPAccRoomTID { get; set; }

        public int? NTPAccMainID { get; set; }

        [Required]
        [StringLength(50)]
        public string? AccRoom { get; set; }

        public int? RoomPrice { get; set; }

        public int? RoomNetPrice { get; set; }

        public int RoomCount { get; set; }

        public int? AccRoomID { get; set; }
        public bool deleted { get; set; } = false;
        [ForeignKey("NTPAccMainID")]
        public virtual NTPAccomodationMain NTPAccomodationMain { get; set; }
    }
}
