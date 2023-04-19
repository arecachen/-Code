namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestruantMain")]
    public partial class RestruantMain
    {
        [Key]
        public int RestruantMainTID { get; set; }

        [Required]
        public string? RestTitle { get; set; }

        [StringLength(200)]
        public string? RestAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string? RestCity { get; set; }

        [StringLength(100)]
        public string? RestCountry { get; set; }

        [StringLength(100)]
        public string? RestContactName { get; set; }

        [StringLength(50)]
        public string? RestContactNumber { get; set; }

        [StringLength(256)]
        public string? RestEmail { get; set; }

        [StringLength(256)]
        public string? RestURL { get; set; }

        [StringLength(25)]
        public string? RestStatus { get; set; }

        [Display(Name = "�m������")]
        public int? dist { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? distName { get; set; }
        [ForeignKey("dist")]
        public TaiwanDist TaiwanDist { get; set; }
    }
    public class RestruantFile
    {
        [Key]
        public int id { get; set; }
        public int restruantMainTID { get; set; }
        public string? restruantScr { get; set; }
        public bool deleted { get; set; } = false;
    }
}
