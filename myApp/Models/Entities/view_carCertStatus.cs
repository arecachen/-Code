namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_carCertStatus
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string? CarID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string? empName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string? CarStatus { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carCertificateTID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int certTypeID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string? carCertName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string? CerTypeStatus { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int certRequiredUpdate { get; set; }

        public long? certRenewDate { get; set; }

        [StringLength(256)]
        public string? certImgSrc { get; set; }

        [StringLength(256)]
        public string? cerDoc { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string? CertStatus { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carCertAlertDay { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }
    }
}
