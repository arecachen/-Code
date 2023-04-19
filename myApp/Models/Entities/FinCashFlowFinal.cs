namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinCashFlowFinal")]
    public partial class FinCashFlowFinal
    {
        [Key]
        public int FinCashFlowFinalTID { get; set; }

        [Required]
        [StringLength(50)]
        public string FinCompany { get; set; }

        public long FinFinalCash { get; set; }

        public long FinSettleDate { get; set; }

        public long FinCreateDate { get; set; }

        public long FinFinalCash_Non { get; set; }

        public bool deleted { get; set; } = false;
    }
}
