namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarFinedDeduction")]
    public partial class CarFinedDeduction
    {
        [Key]
        public int CarFinedDeductionTID { get; set; }

        [Required]
        [StringLength(100)]
        public string? cfdTitle { get; set; }

        [Required]
        [StringLength(10)]
        public string? cfdOrder { get; set; }

        [Required]
        [StringLength(20)]
        public string? cfdStatus { get; set; }    
        public bool deleted { get; set; } = false;
    }
}
