namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttractionMain")]
    public partial class AttractionMain
    {
        [Key]
        public int AttractionMainTID { get; set; }

        [Required]
        public string? AttrTitle { get; set; }

        [StringLength(200)]
        public string? AttrAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string? AttrCity { get; set; }

        [StringLength(100)]
        public string? AttrCountry { get; set; }

        [StringLength(100)]
        public string? AttrContactName { get; set; }

        [StringLength(50)]
        public string? AttrContactNumber { get; set; }

        [StringLength(256)]
        public string? AttrEmail { get; set; }

        [StringLength(256)]
        public string? AttrURL { get; set; }

        [StringLength(25)]
        public string? AttrStatus { get; set; }
   
        [Display(Name = "�m������")]
        public int? dist { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? distName { get; set; }
        [ForeignKey("dist")]
        public TaiwanDist TaiwanDist { get; set; }
    }
    public class AttractionFile
    {
        [Key]
        public int id { get; set; }
        public int attractionMainTID { get; set; }
        public string? attractionScr { get; set; }
        public bool deleted { get; set; } = false;
    }
}
