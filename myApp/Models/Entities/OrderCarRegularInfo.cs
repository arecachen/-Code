namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarRegularInfo")]
    public partial class OrderCarRegularInfo
    {
        [Key]
        public int OrderCarRegularInfoTID { get; set; }

        public int OrderCarRegularID { get; set; }

        [StringLength(100)]
        public string? rentWorkTitle { get; set; }

        [Required]
        [StringLength(10)]
        public string? CarType { get; set; }

        public long rentStartDate { get; set; }

        public long rentEndDate { get; set; }

        public int? rentArriveHour { get; set; }

        public int? rentArriveMinute { get; set; }

        [StringLength(256)]
        public string? journey { get; set; }

        [Required]
        [StringLength(30)]
        public string? CycleType { get; set; }

        public int CycleCount { get; set; }

        [Required]
        [StringLength(256)]
        public string? BaseDate { get; set; }

        [Required]
        [StringLength(20)]
        public string? status { get; set; }

        [Column(TypeName = "text")]
        public string? Memo { get; set; }

        [StringLength(50)]
        public string? InfoType { get; set; }

        public bool deleted { get; set; } = false;
    }
}
