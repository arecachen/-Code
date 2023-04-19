namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderRegularPayment")]
    public partial class OrderRegularPayment
    {
        [Key]
        public int OrderRegularPaymentTID { get; set; }

        public int orderCarID { get; set; }

        public long payDate { get; set; }

        public int? payAmount { get; set; }

        [StringLength(256)]
        public string? memo { get; set; }
        public bool deleted { get; set; } = false;
        public virtual OrderCar? OrderCar { get; set; }
    }
}
