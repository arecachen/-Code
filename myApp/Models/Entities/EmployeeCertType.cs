namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeCertType")]
    public partial class EmployeeCertType
    {
        [Key]
        public int empCertTID { get; set; }

        [StringLength(50)]
        public string? certName { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [StringLength(10)]
        public string? status { get; set; }

        public int certAlertDay { get; set; }

        public bool deleted { get; set; } = false;
    }
}
