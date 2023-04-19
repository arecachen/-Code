namespace hsintongERP2022.Models
{
    using Altways;
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarCertificate")]
    public partial class CarCertificate
    {
        [Key]
        public int carCertificateTID { get; set; }

        [Required]
        [StringLength(15)]
        public string? carID { get; set; }

        public int certTypeID { get; set; }

        [StringLength(15)]
        public string? certID { get; set; }

        [StringLength(256)]
        public string? certImgSrc { get; set; }

        public int? certImgShow { get; set; }

        [StringLength(256)]
        public string? cerDoc { get; set; }

        public int certRequiredUpdate { get; set; }

        public long certCreateDatetime { get; set; }

        public long? certUpdateDatetime { get; set; }

        public long? certRenewDate { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }

        public virtual CarCertType? CarCertType { get; set; }

        public virtual CarMain? CarMain { get; set; }
  
        Model_hsintong db = new Model_hsintong();
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? sCertCreateDate
        {
            get { return ((long?)certCreateDatetime).LongToDateString(); }
            set { certCreateDatetime = value.ToDateLong(); }
        }
        [NotMapped]
        public string? sCertUpdateDate
        {
            get { return ((long?)certUpdateDatetime).LongToDateString(); }
            set { certUpdateDatetime = value.ToDateLong(); }
        }

        [NotMapped]
        public string? sCertRenewDate
        {
            get { return ((long?)certRenewDate).LongToDateString(); }
            set { certRenewDate = value.ToDateLong(); }
        }
        [NotMapped]
        public string? certType
        {
            get { return db.CarCertType.Find(certTypeID).Ensure(x => x.carCertName); }
        }
        [NotMapped, Display(Name = "ï¿½Yï¿½ï¿½")]
        public string? TempImageStr { get; set; }
        [NotMapped, Display(Name = "ï¿½ï¿½ï¿?")]
        public string? TempDocStr { get; set; }
        [NotMapped]
        public bool IsCertRequiredUpdate
        {
            get { return certRequiredUpdate > 0; }
            set { certRequiredUpdate = (value) ? 1 : 0; }
        }

    }
}
