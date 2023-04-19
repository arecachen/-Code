namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_CashFlowList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FinCashFlowMainTID { get; set; }

        public long? FinCFDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string? dicValue { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string? dicText { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string? FinAccItemCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string? FinAccItemName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string? FinAccItemDirection { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string? FinCFContent { get; set; }

        [Key]
        [Column(Order = 7)]
        public int? FinCFAmount { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string? FinCFCashType { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string? FinCFStatus { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FinCreateBy { get; set; }

        public long? FinCreateDate { get; set; }

        public int? FinLastModifyBy { get; set; }

        public long? FinLastModifyDate { get; set; }

        public int? FinDeletedBy { get; set; }

        public long? FinDeletedDate { get; set; }
    }
}
