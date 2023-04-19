namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarPartnerCarStatementMain")]
    public partial class OrderCarPartnerCarStatementMain
    {
        [Key]
        public int OrderCarPartnerCarStatementMainTID { get; set; }

        public long PCSDate { get; set; }

        public int? PCSRecordAmount { get; set; }

        public int? PCSIntentAmount { get; set; }

        [Column(TypeName = "text")]
        public string? PCSMemo { get; set; }

        public long? PCSSettleDate { get; set; }

        public int? PCSSettleAmount { get; set; }

        [Column(TypeName = "text")]
        public string? PCSSettleMemo { get; set; }

        public int? PCSSettleBy { get; set; }

        public int? PCSCreateBy { get; set; }

        public virtual AccessAccount? AccessAccount { get; set; }

        public bool deleted { get; set; } = false;
    }
}
