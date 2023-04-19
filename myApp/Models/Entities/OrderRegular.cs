namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderRegular")]
    public partial class OrderRegular
    {
        [Key]
        public int orderRegularTID { get; set; }

        public int orderCarID { get; set; }

        [Required]
        [StringLength(30)]
        public string? payTerm { get; set; }

        [StringLength(30)]
        public string? payPeriod { get; set; }

        public int? payAmount { get; set; }

        public int? payTermAmount { get; set; }

        public int payPeriodCount { get; set; }

        public int? orderCostScheduleID { get; set; }

        public virtual OrderCar? OrderCar { get; set; }
        public bool deleted { get; set; } = false;
        public virtual OrderCarCostScheduleMain? OrderCarCostScheduleMain { get; set; }
    }
}
