namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarFinedCategory")]
    public partial class CarFinedCategory
    {
        [Key]
        [StringLength(25)]
        public string? CarFinedCategoryTID { get; set; }

        [Required]
        [StringLength(100)]
        public string? cfcTitle { get; set; }

        [Required]
        [StringLength(10)]
        public string? cfcOrder { get; set; }

        [Required]
        [StringLength(20)]
        public string? cfcStatus { get; set; }
   
        public bool deleted { get; set; } = false;
    }
}
