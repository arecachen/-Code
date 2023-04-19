namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrderCarCostScheduleMain")]
    public partial class OrderCarCostScheduleMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderCarCostScheduleMain()
        {
            OrderCarCostScheduleSub = new HashSet<OrderCarCostScheduleSub>();
            OrderRegular = new HashSet<OrderRegular>();
        }

        [Key]
        public int orderCarCostScheduleTID { get; set; }

        [StringLength(30)]
        public string? costScheduleName { get; set; }

        [StringLength(12)]
        public string? status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarCostScheduleSub> OrderCarCostScheduleSub { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRegular> OrderRegular { get; set; }
 
        public bool deleted { get; set; } = false;
    }
}
