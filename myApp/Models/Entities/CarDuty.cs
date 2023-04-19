namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarDuty")]
    public partial class CarDuty
    {
        [Key]
        public int CarDutyTID { get; set; }

        [Required]
        [StringLength(256)]
        public string? DutyName { get; set; }

        public int DutyOrder { get; set; }

        [Required]
        [StringLength(50)]
        public string? DutyStatus { get; set; }

        public bool deleted { get; set; } = false;
    }
}
