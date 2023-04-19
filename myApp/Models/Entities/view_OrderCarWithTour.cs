namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_OrderCarWithTour
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerTID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderCarInfoTID { get; set; }

        public long? rentStartDate { get; set; }

        [StringLength(100)]
        public string? rentArriveLocation { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string? custContactName { get; set; }

        [StringLength(50)]
        public string? custContactPhone { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string? custContactMobile { get; set; }

        [StringLength(50)]
        public string? custContactFax { get; set; }

        [StringLength(50)]
        public string? withCarContactName { get; set; }

        [StringLength(50)]
        public string? withCarContactPhone { get; set; }

        [StringLength(50)]
        public string? withCarContactMobile { get; set; }

        public int? withTourContract { get; set; }

        public int? withTourQuotation { get; set; }

        public int? withTourInvoice { get; set; }

        public int? withTourReceipt { get; set; }

        public int? withTourInsurace { get; set; }

        public int? withTourSticker { get; set; }

        public int? withTourPaymentAccount { get; set; }

        public int? withTourSecurityCheck { get; set; }

        public int? withTourCarDetails { get; set; }

        public int? withTourOther { get; set; }

        [StringLength(256)]
        public string? withTourOtherMemo { get; set; }

        [StringLength(50)]
        public string? mainPhone { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderIrregularTID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int custContactID { get; set; }
    }
}
