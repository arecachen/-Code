namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QRCodeJobReport")]
    public partial class QRCodeJobReport
    {
        [Key]
        public int QRCJobReportTID { get; set; }

        public int QRCJobID { get; set; }

        public long JReportDate { get; set; }

        public long? JReportAckDate { get; set; }

        public long? JReportCompleteDate { get; set; }

        public string? JReportUserName { get; set; }

        public string? JReportUserPhone { get; set; }

        public string? JReportUserEmail { get; set; }

        [Column(TypeName = "text")]
        public string? JReportDetails { get; set; }

        [Required]
        public string? JReportNotifyTo { get; set; }

        public long JReportNotifyAt { get; set; }
        public bool deleted { get; set; } = false;
        [Required]
        [StringLength(50)]
        public string? JReportStatus { get; set; }

        public virtual QRCodeJob? QRCodeJob { get; set; }
    }
}
