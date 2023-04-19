namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_CustomerWithContact
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerTID { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        [StringLength(50)]
        public string? mainPhone { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string? status { get; set; }

        public int? customerContactTID { get; set; }

        [StringLength(50)]
        public string? custName { get; set; }

        [StringLength(50)]
        public string? custPhone { get; set; }

        [StringLength(50)]
        public string? custMobile { get; set; }

        [StringLength(256)]
        public string? custEmail { get; set; }

        [StringLength(50)]
        public string? custFax { get; set; }

        [Column(TypeName = "text")]
        public string? caution { get; set; }

        public int? customerTypeTID { get; set; }

        [StringLength(25)]
        public string? custTypeName { get; set; }

        [StringLength(10)]
        public string? Expr1 { get; set; }
    }
}
