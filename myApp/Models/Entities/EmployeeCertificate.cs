namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using hsintongERP2022.util;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("EmployeeCertificate")]    
    public partial class EmployeeCertificate
    {
        [Key]
        public int employeeOwnCertTID { get; set; }

        public int empID { get; set; }
        [ForeignKey("empID")]
        public virtual EmployeeMain? EmployeeMain { get; set; }

        public int certTypeID { get; set; }

        [Required]
        [StringLength(30)]
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
        //Error Self referencing loop detected for type System.data.entity occurs.
        //[ForeignKey("empID")]
        //[DataMember]
        //public virtual EmployeeMain EmployeeMain { get; set; }
   
        [NotMapped, Display(Name = "發證日期")]
        public string? certCreateDate
        {
            get { return ((long?)certCreateDatetime).LongToDateString(); }
            set { certCreateDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "最後更新日(由系統直接撈取存檔時間")]
        public string? certUpdateDate
        {
            get { return ((long?)certUpdateDatetime).LongToDateString(); }
            set { certUpdateDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "證照預定更新日期")]
        public string? certRenewDay
        {
            get { return ((long?)certRenewDate).LongToDateString(); }
            set { certRenewDate = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "於車籍資料列印時(訂單隨車資料)是否顯示")]
        public bool isCertImgShow
        {
            get { return (certImgShow > 0); }
            set { certImgShow = (value) ? 1 : 0; }
        }
        [NotMapped, Display(Name = "是否需要更新")]
        public bool isCertRequiredUpdate
        {
            get { return (certRequiredUpdate > 0); }
            set { certRequiredUpdate = (value) ? 1 : 0; }
        }
        [NotMapped, Display(Name = "圖檔路徑")]
        public string? imageUrl
        {
            get { return new ProjectConfigFile().uploadAttachment + "\\" + certImgSrc; }
        }
        [NotMapped, Display(Name = "圖檔")]
        public string? ImageStr { get; set; }
        [NotMapped, Display(Name = "縮圖")]
        public string? TempImageStr { get; set; }
        [NotMapped, Display(Name = "文件")]
        public string? TempDocStr { get; set; }

        [ForeignKey("certTypeID")]
        public EmployeeCertType? EmployeeCertType { get; set; }
        public bool deleted { get; set; } = false;
    }
}
