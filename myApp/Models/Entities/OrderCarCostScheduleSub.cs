namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarCostScheduleSub")]
    public partial class OrderCarCostScheduleSub
    {
        [Key]
        public int orderCarCostScheduleSubTID { get; set; }

        public int? orderCarCostScheduleID { get; set; }

        [StringLength(12)]
        public string? carType { get; set; }

        [StringLength(50)]
        public string? startTime { get; set; }

        [StringLength(50)]
        public string? endTime { get; set; }

        public int? cost { get; set; }

        public virtual OrderCarCostScheduleMain OrderCarCostScheduleMain { get; set; }
   
        public bool deleted { get; set; } = false;
    }
}
