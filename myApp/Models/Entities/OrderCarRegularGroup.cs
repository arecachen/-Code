namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarRegularGroup")]
    public partial class OrderCarRegularGroup
    {
        [Key]
        public int OrderCarRegularGroupTID { get; set; }

        [Required]
        [StringLength(60)]
        public string? Grp_Title { get; set; }

        [Required]
        [StringLength(20)]
        public string? Grp_Status { get; set; }

        public int Grp_Order { get; set; }

        public bool deleted { get; set; } = false;
    }
}
