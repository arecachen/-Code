namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarRegular")]
    public partial class OrderCarRegular
    {
        [Key]
        public int OrderCarRegularTID { get; set; }

        [StringLength(256)]
        public string? MainTitle { get; set; }

        public int? inTouchBy { get; set; }

        public int? inChargeBy { get; set; }

        public int CreateBy { get; set; }

        public long CreateDate { get; set; }

        public int? UpdateBy { get; set; }

        public long? UpdateDate { get; set; }

        public int CustomerID { get; set; }

        public int CustomerContactID { get; set; }

        [StringLength(50)]
        public string? Cust_Name { get; set; }

        [StringLength(50)]
        public string? Cust_Phone { get; set; }

        [StringLength(50)]
        public string? Cust_Mobile { get; set; }

        [StringLength(50)]
        public string? Cust_Fax { get; set; }

        public int? PayAmount { get; set; }

        [StringLength(256)]
        public string? ExtraDocument { get; set; }

        public long StartDate { get; set; }

        public long EndDate { get; set; }

        [Required]
        [StringLength(20)]
        public string? status { get; set; }

        public bool deleted { get; set; } = false;
    }
}
