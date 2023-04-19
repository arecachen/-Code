namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarGroup")]
    public partial class CarGroup
    {
        [Key]
        public int CarGroupTID { get; set; }

        [Required]
        [StringLength(256)]
        public string? GroupName { get; set; }

        public int GroupOrder { get; set; }

        [Required]
        [StringLength(50)]
        public string? GroupStatus { get; set; }
    }
}
