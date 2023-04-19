namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehMantaince")]
    public partial class VehMantaince
    {
        [Key]
        public int vehMaintainceTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? vehMtItem { get; set; }

        [Column(TypeName = "text")]
        public string? vehMtMemo { get; set; }

        public int? vehMtByMile { get; set; }

        public int? vehMtByMileRange { get; set; }

        public int? vehMtByDate { get; set; }

        public int? vehMtByDateRangeDays { get; set; }

        public bool deleted { get; set; } = false;
    }
}
