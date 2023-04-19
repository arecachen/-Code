namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarJobMain")]
    public partial class OrderCarJobMain
    {
        [Key]
        public int OrderCarJobMainTID { get; set; }

        public long CarJobDate { get; set; }

        [Column(TypeName = "ntext")]
        public string? CarJobMemo { get; set; }

        [Required]
        [StringLength(20)]
        public string? CarJobStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string? CarJobFinalBy { get; set; }

        public long CarJobFinalDate { get; set; }

        public bool deleted { get; set; } = false;
    }
}
