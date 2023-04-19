namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderRegularContractPayment")]
    public partial class OrderRegularContractPayment
    {
        [Key]
        public int OrderRegularContractPaymentTID { get; set; }

        public int orderCarID { get; set; }

        [Required]
        [StringLength(30)]
        public string? carType { get; set; }

        public int passengerMin { get; set; }

        public int passengerMax { get; set; }

        public int? price { get; set; }
        public bool deleted { get; set; } = false;
        public virtual OrderCar? OrderCar { get; set; }
    }
}
