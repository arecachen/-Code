namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarInfoWithEquip")]
    public partial class OrderCarInfoWithEquip
    {
        [Key]
        public int orderCarInfoWithEquipTID { get; set; }

        public int orderCarInfoID { get; set; }

        public int carEquipmentID { get; set; }

        public virtual CarEquipment? CarEquipment { get; set; }

        public virtual OrderCarInfo? OrderCarInfo { get; set; }

        public bool deleted { get; set; } = false;
    }
}
