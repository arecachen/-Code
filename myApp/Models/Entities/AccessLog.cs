namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessLog")]
    public partial class AccessLog
    {
        [Key]
        public int logTID { get; set; }

        public long logDatetime { get; set; }

        public int logAccID { get; set; }

        [Required]
        [StringLength(20)]
        public string? logAction { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string? logDesc { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }
  
        public bool deleted { get; set; } = false;
    }
}
