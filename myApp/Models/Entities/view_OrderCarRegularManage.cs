namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_OrderCarRegularManage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderCarRegularTID { get; set; }

        public int? customerTID { get; set; }

        public int? customerContactTID { get; set; }

        public int? custID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerContactID { get; set; }

        [StringLength(50)]
        public string? Cust_Name { get; set; }

        [StringLength(50)]
        public string? Cust_Phone { get; set; }

        [StringLength(50)]
        public string? Cust_Mobile { get; set; }

        [StringLength(50)]
        public string? Cust_Fax { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long StartDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EndDate { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        [StringLength(50)]
        public string? custName { get; set; }

        [StringLength(50)]
        public string? custPhone { get; set; }

        [StringLength(50)]
        public string? custMobile { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(256)]
        public string? MainTitle { get; set; }
    }
}
