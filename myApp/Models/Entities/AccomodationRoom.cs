namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccomodationRoom")]
    public partial class AccomodationRoom
    {
        [Key]
        public int AccRoomTID { get; set; }
      
        [Required]
        [StringLength(100)]
        public string? RoomName { get; set; }

        [Required]
        [StringLength(100)]
        public string? RoomType { get; set; }

        public int RoomOrder { get; set; } = 0;

        [Required]
        [StringLength(25)]
        public string? RoomStatus { get; set; }

    }
    public partial class AccomodationRoom
    {
        [Required]
        public int AccomodationMainTID { get; set; }
        //�w�]�Ы�
        public bool isDefault { get; set; } = false;
        public bool deleted { get; set; } = false;
        [ForeignKey("AccomodationMainTID")]
        public AccomodationMain? AccomodationMain { get; set; }
        [NotMapped]
        public string? sRoomType { get { return (RoomType == "Room") ? "�ж�" : "�|ĳ��"; } }
        //[NotMapped]
        //public string? IsDefault { get { return (isDefault) ? "�w�]" : ""; } }
    }
}
