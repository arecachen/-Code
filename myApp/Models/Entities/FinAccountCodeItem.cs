namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinAccountCodeItem")]
    public partial class FinAccountCodeItem
    {
        [Key]
        public int FinAccountCodeItemTID { get; set; }

        public int FinAccountCodeMainID { get; set; }

        [Required]
        [StringLength(20)]
        public string? FinAccItemCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? FinAccItemName { get; set; }

        [Required]
        [StringLength(20)]
        public string? FinAccItemDirection { get; set; }

        public int? FinAccItemIsHeader { get; set; }

        public int FinAccUpperItem { get; set; }

        [StringLength(10)]
        public string? FinAccItemStatus { get; set; }

        public int FinAccItemOrder { get; set; }

        public virtual FinAccountCodeMain? FinAccountCodeMain { get; set; }

        public bool deleted { get; set; } = false;
    }
}
