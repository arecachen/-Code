namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("QRCodeJob")]
    public partial class QRCodeJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QRCodeJob()
        {
            QRCJobShareInfo = new HashSet<QRCJobShareInfo>();
            QRCodeJobReport = new HashSet<QRCodeJobReport>();
        }

        [Key]
        public int QRCJobTID { get; set; }

        public int JobCreateBy { get; set; }

        public long JobCreateDatetime { get; set; }

        public long? JobLastUpdateDatetime { get; set; }

        public int? JobLastUpdateBy { get; set; }

        [Required]
        [StringLength(256)]
        public string? QRCodeJobType { get; set; }

        [Required]
        public string? JobLinkTable { get; set; }

        public string? QRCodePasswrd { get; set; }

        [Required]
        [StringLength(100)]
        public string? JobTaskName { get; set; }

        [StringLength(200)]
        public string? JobTaskNameInternal { get; set; }

        [Column(TypeName = "text")]
        public string? JobDescription { get; set; }

        public int JobReqUserInfo { get; set; }

        public int JobReqDetails { get; set; }

        public int OnlyMeModify { get; set; }

        public int OnlyMeView { get; set; }

        [Column(TypeName = "ntext")]
        public string? AllowModify { get; set; }

        [Column(TypeName = "ntext")]
        public string? AllowView { get; set; }

        public long JobValidDate { get; set; }

        public int LockAtDealing { get; set; }

        [Required]
        public string? JobQRCodeName { get; set; }

        [Required]
        public string? JobQRCodeLongURL { get; set; }

        [Required]
        public string? JobQRCodeShortURL { get; set; }

        [stringLength(15)]
        public string? JobLinkToCarID { get; set; }

        public int? JobLinkToEmployeeID { get; set; }
        public bool deleted { get; set; } = false;
        [Required]
        [StringLength(50)]
        public string? QRCJobStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QRCJobShareInfo> QRCJobShareInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QRCodeJobReport> QRCodeJobReport { get; set; }
    }
}
