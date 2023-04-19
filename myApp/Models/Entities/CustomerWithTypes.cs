namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerWithTypes
    {
        [Key]
        public int CustomerWithTypeTID { get; set; }

        public int? custID { get; set; }

        public int custTypeID { get; set; }

        public virtual Customer? Customer { get; set; }

        public virtual CustomerType? CustomerType { get; set; }

        public int? customerContactTID { get; set; }
        [ForeignKey("customerContactTID")]
        public CustomerContact? customerContact { get; set; }
        public bool deleted { get; set; } = false;
    }
}
