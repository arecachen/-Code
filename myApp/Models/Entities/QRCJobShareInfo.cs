namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QRCJobShareInfo")]
    public partial class QRCJobShareInfo
    {
        [Key]
        public int QRCJobShareInfoTID { get; set; }

        public int QCJobID { get; set; }

        [Required]
        [StringLength(200)]
        public string? ShareName { get; set; }

        [Required]
        [StringLength(50)]
        public string? ShareType { get; set; }

        public string? FileFace { get; set; }

        [Required]
        public string? FileNameSource { get; set; }

        [Required]
        public string? FileNameSystem { get; set; }

        [StringLength(10)]
        public string? FileNameExt { get; set; }

        [StringLength(256)]
        public string? FileAttr { get; set; }

        [Required]
        [StringLength(50)]
        public string? FileStatus { get; set; }
        public bool deleted { get; set; } = false;
        public virtual QRCodeJob? QRCodeJob { get; set; }
    }
}
