namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarPartnerCarStatementItem")]
    public partial class OrderCarPartnerCarStatementItem
    {
        [Key]
        public int OrderCarPartnerCarStatementItemTID { get; set; }

        public int OrderCarPartnerCarStatementMainID { get; set; }

        public int OrderCarJobID { get; set; }

        [Required]
        [StringLength(50)]
        public string? PartnerInfoType { get; set; }

        [Required]
        [StringLength(50)]
        public string? PCSItemDirection { get; set; }

        public int? PCSItemPrice { get; set; }

        public virtual OrderCarJob? OrderCarJob { get; set; }

        public bool deleted { get; set; } = false;
    }
}
