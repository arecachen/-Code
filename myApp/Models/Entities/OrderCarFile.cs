namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarFile")]
    public partial class OrderCarFile
    {
        [Key]
        public int OrderCarFileTID { get; set; }

        [Required]
        [StringLength(256)]
        public string? RelName { get; set; }

        [Required]
        [StringLength(256)]
        public string? SysName { get; set; }

        public int OrderCarID { get; set; }

        public bool deleted { get; set; } = false;
    }
}
