namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderCarInfoPassenger_del
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderCarCountTID { get; set; }

        public int orderCarInfoID { get; set; }

        public long useDate { get; set; }

        [StringLength(30)]
        public string carType { get; set; }

        public int passengerCount { get; set; }

        public int? cost { get; set; }

        public virtual OrderCarInfo OrderCarInfo { get; set; }

        public bool deleted { get; set; } = false;
    }
}
