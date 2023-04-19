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
   
        [NotMapped, Display(Name = "�o�Ҥ��")]
        public string? certCreateDate
        {
            get { return ((long?)certCreateDatetime).LongToDateString(); }
            set { certCreateDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "�̫��s��(�Ѩt�Ϊ��������s�ɮɶ�")]
        public string? certUpdateDate
        {
            get { return ((long?)certUpdateDatetime).LongToDateString(); }
            set { certUpdateDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "�ҷӹw�w��s���")]
        public string? certRenewDay
        {
            get { return ((long?)certRenewDate).LongToDateString(); }
            set { certRenewDate = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "���y��ƦC�L��(�q���H�����)�O�_���")]
        public bool isCertImgShow
        {
            get { return (certImgShow > 0); }
            set { certImgShow = (value) ? 1 : 0; }
        }
        [NotMapped, Display(Name = "�O�_�ݭn��s")]
        public bool isCertRequiredUpdate
        {
            get { return (certRequiredUpdate > 0); }
            set { certRequiredUpdate = (value) ? 1 : 0; }
        }
        [NotMapped, Display(Name = "���ɸ��|")]
        public string? imageUrl
        {
            get { return new ProjectConfigFile().uploadAttachment + "\\" + certImgSrc; }
        }
        [NotMapped, Display(Name = "����")]
        public string? ImageStr { get; set; }
        [NotMapped, Display(Name = "�Y��")]
        public string? TempImageStr { get; set; }
        [NotMapped, Display(Name = "���")]
        public string? TempDocStr { get; set; }

        [ForeignKey("certTypeID")]
        public EmployeeCertType? EmployeeCertType { get; set; }
        public bool deleted { get; set; } = false;
    }
}
