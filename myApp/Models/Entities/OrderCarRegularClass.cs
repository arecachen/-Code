namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarRegularClass")]
    public partial class OrderCarRegularClass
    {
        [Key]
        public int OrderCarRegularClassTID { get; set; }

        [Required]
        [StringLength(60)]
        public string? Cls_Title { get; set; }

        [Required]
        [StringLength(20)]
        public string? Cls_Status { get; set; }

        public int Cls_Order { get; set; }

        public bool deleted { get; set; } = false;
    }
}
