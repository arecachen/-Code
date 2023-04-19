namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_EmployeeCertStatus
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int employeeTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string? empName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string? empMainContact { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string? empSecondContact { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string? empDuty { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string? empGrade { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(15)]
        public string? EmpStatus { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int employeeOwnCertTID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int certTypeID { get; set; }

        [StringLength(50)]
        public string? certName { get; set; }

        [StringLength(10)]
        public string? CertTypeStatus { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int certRequiredUpdate { get; set; }

        public long? certRenewDate { get; set; }

        [StringLength(256)]
        public string? certImgSrc { get; set; }

        [StringLength(256)]
        public string? cerDoc { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(10)]
        public string? CertStatus { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int certAlertDay { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }
    }
}
