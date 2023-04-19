namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderCarRegularFunds
    {
        [Key]
        public int OrderCarRegularFundsTID { get; set; }

        public int OrderCarRegularInfoID { get; set; }

        public int OrderCarRegularClassID { get; set; }

        public int OrderCarRegularGroupID { get; set; }

        public int Funds { get; set; }

        public bool deleted { get; set; } = false;
    }
}
