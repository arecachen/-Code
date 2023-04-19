namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinCashFlowMain")]
    public partial class FinCashFlowMain
    {
        [Key]
        public int FinCashFlowMainTID { get; set; }

        public long? FinCFDate { get; set; }

        [Required]
        [StringLength(50)]
        public string? FinCSRelatedCompany { get; set; }

        [Required]
        [StringLength(20)]
        public string? FinAccItemCodeUX { get; set; }

        [Required]
        [StringLength(100)]
        public string? FinCFContent { get; set; }

        public int? FinCFAmount { get; set; }

        [Required]
        [StringLength(30)]
        public string? FinCFCashType { get; set; }

        [Required]
        [StringLength(20)]
        public string? FinCFStatus { get; set; }

        public int FinCreateBy { get; set; }

        public long? FinCreateDate { get; set; }

        public int? FinLastModifyBy { get; set; }

        public long? FinLastModifyDate { get; set; }

        public int? FinDeletedBy { get; set; }

        public long? FinDeletedDate { get; set; }

        public virtual AccessAccount? AccessAccount { get; set; }

        public virtual AccessAccount? AccessAccount1 { get; set; }

        public bool deleted { get; set; } = false;
    }
}
