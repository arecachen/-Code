namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarPartItemWithCorporation")]
    public partial class CarPartItemWithCorporation
    {
        [Key]
        public int CarPartItemWithCorporationTID { get; set; }

        public int carPartItemID { get; set; }

        public int corporationID { get; set; }
        [ForeignKey("carPartItemID")]
        public virtual CarPartItem? CarPartItem { get; set; }
        [ForeignKey("corporationID")]
        public virtual Corporation? Corporation { get; set; }
        
       
        public bool deleted { get; set; } = false;
    }
}
