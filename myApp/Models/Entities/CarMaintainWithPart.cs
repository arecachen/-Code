namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarMaintainWithPart")]
    public partial class CarMaintainWithPart
    {
        [Key]
        public int carMaintainWithPartTID { get; set; }

        public int carMaintainID { get; set; }

        public int carPartItemID { get; set; }

        [Required]
        [StringLength(12)]
        public string? partStatus { get; set; }

        [StringLength(256)]
        public string? partFaultyDesc { get; set; }

        public int partResolve { get; set; }

        public int? partCost { get; set; }

        public decimal? nextCheckMile { get; set; }

        public long? nextCheckDate { get; set; }

        public virtual CarMaintaince? CarMaintaince { get; set; }

        public virtual CarPartItem? CarPartItem { get; set; }

        public bool deleted { get; set; } = false;
    }
}
