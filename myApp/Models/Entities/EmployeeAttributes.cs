namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeeAttributes
    {
        [Key]
        public int EmployeeAttributesTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? EA_Title { get; set; }

        [Required]
        [StringLength(20)]
        public string? EA_Status { get; set; }

        public bool deleted { get; set; } = false;
    }
}
