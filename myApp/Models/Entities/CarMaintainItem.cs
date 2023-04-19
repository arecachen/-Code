namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarMaintainItem")]
    public partial class CarMaintainItem
    {
        [Key]
        public int carMaintainItemTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? itemName { get; set; }

        [StringLength(256)]
        public string? itemMemo { get; set; }

        public int itemShowOnReport { get; set; }

        [Required]
        [StringLength(12)]
        public string? itemStatus { get; set; }

        public bool deleted { get; set; } = false;
    }
}
