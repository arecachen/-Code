namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusTable")]
    public partial class StatusTable
    {
        [Key]
        public int statusTID { get; set; }

        [Required]
        [StringLength(25)]
        public string? statusGroup { get; set; }

        [Required]
        [StringLength(25)]
        public string? statusValue { get; set; }
        public bool deleted { get; set; } = false;
        [Required]
        [StringLength(25)]
        public string? statusText { get; set; }

        public int statusOrder { get; set; }
    }
}
