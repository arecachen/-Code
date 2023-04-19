namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemImage")]
    public partial class SystemImage
    {
        [Key]
        public int systemImageTID { get; set; }

        [Required]
        [StringLength(12)]
        public string? imageCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? imageName { get; set; }

        [Required]
        [StringLength(256)]
        public string? imageFile { get; set; }
        public bool deleted { get; set; } = false;
    }
}
