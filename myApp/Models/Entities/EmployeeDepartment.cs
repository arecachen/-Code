namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeDepartment")]
    public partial class EmployeeDepartment
    {
        [Key]
        public int EmployeeDepartmentTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? ED_Title { get; set; }

        [Required]
        [StringLength(20)]
        public string? ED_Status { get; set; }

        public bool deleted { get; set; } = false;
    }
}
