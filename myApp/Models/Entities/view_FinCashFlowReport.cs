namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_FinCashFlowReport
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FinCashFlowMainTID { get; set; }

        public long? FinCFDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string? FinCSRelatedCompany { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string? FinAccItemCodeUX { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string? FinCFContent { get; set; }

        [Key]
        [Column(Order = 4)]
        public int? FinCFAmount { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string? FinCFCashType { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string? FinCFStatus { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FinCreateBy { get; set; }

        public long? FinCreateDate { get; set; }

        public int? FinLastModifyBy { get; set; }

        public long? FinLastModifyDate { get; set; }

        public int? FinDeletedBy { get; set; }

        public long? FinDeletedDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string? FinAccItemName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string? FinAccItemCode { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string? FinAccName { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string? FinAccCode { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FinAccountCodeMainTID { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FinAccountCodeItemTID { get; set; }

        [StringLength(10)]
        public string? FinAccItemStatus { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(30)]
        public string? dicValue { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(30)]
        public string? dicText { get; set; }

        public int? FinAccItemIsHeader { get; set; }
    }
}
