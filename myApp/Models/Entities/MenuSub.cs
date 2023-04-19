namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuSub")]
    public partial class MenuSub
    {
        [Key]
        public int menuSubTID { get; set; }

        public int menuMainID { get; set; }

        [Required]
        [StringLength(20)]
        public string? subName { get; set; }

        [Required]
        [StringLength(20)]
        public string? subType { get; set; }

        [Required]
        [StringLength(256)]
        public string? subLink { get; set; }

        public int subNewWindow { get; set; }

        [StringLength(256)]
        public string? subProp { get; set; }

        public int? subOrder { get; set; }

        [Required]
        [StringLength(20)]
        public string? subStatus { get; set; }

        public int upperSub { get; set; }

        public virtual MenuMain? MenuMain { get; set; }

        public bool deleted { get; set; } = false;
    }
}
