namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_OrderCarPartnerCarStatement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderCarPartnerCarStatementMainTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PCSDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public int? PCSRecordAmount { get; set; }

        [Key]
        [Column(Order = 3)]
        public int? PCSIntentAmount { get; set; }

        [Column(TypeName = "text")]
        public string? PCSMemo { get; set; }

        public long? PCSSettleDate { get; set; }

        public int? PCSSettleAmount { get; set; }

        [Column(TypeName = "text")]
        public string? PCSSettleMemo { get; set; }

        public int? PCSSettleBy { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderCarPartnerCarStatementItemTID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string? PCSItemDirection { get; set; }

        [Key]
        [Column(Order = 6)]
        public int? PCSItemPrice { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderCarJobID { get; set; }

        public long? rentStartDate { get; set; }

        [StringLength(100)]
        public string? rentArriveLocation { get; set; }

        [StringLength(256)]
        public string? journey { get; set; }

        public int? custID { get; set; }

        [StringLength(15)]
        public string? carID { get; set; }
    }
}
