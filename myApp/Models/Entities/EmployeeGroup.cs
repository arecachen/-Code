namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeGroup")]
    public partial class EmployeeGroup
    {
        [Key]
        public int EmployeeGroupTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? EG_Title { get; set; }

        [Required]
        [StringLength(20)]
        public string? EG_Status { get; set; }

        public bool deleted { get; set; } = false;
    }
}
