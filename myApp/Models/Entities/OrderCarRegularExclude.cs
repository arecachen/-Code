namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarRegularExclude")]
    public partial class OrderCarRegularExclude
    {
        [Key]
        public int OrderCarRegularExcludeTID { get; set; }

        public int OrderCarRegularInfoID { get; set; }

        public long ExStartDate { get; set; }

        public long ExEndDate { get; set; }

        public bool deleted { get; set; } = false;
    }
}
