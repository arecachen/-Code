namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseInfoSaving")]
    public partial class BaseInfoSaving
    {
        [Key]
        public int BaseInfoSavingTID { get; set; }

        public long? OrderCarJobBaseDate { get; set; }
    
        public bool deleted { get; set; } = false;
    }
}
