namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_dairyReportList
    {
        [StringLength(20)]
        public string? jobType { get; set; }

        [StringLength(20)]
        public string? status { get; set; }

        public int? orderCarInfoTID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string? custContactName { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string? custContactMobile { get; set; }

        [StringLength(50)]
        public string? custContactPhone { get; set; }

        public long? rentStartDate { get; set; }

        public int? rentLength { get; set; }

        public int? rentArriveHour { get; set; }

        public int? returnHour { get; set; }

        public int? returnMinute { get; set; }

        public int? endHour { get; set; }

        public int? endMinute { get; set; }

        public int? priceTour { get; set; }

        public int? priceTip { get; set; }

        public int? priceParking { get; set; }

        public int? priceTax { get; set; }

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

        public int? rentArriveMinute { get; set; }

        [StringLength(10)]
        public string? carType { get; set; }

        [StringLength(100)]
        public string? rentArriveLocation { get; set; }

        [StringLength(256)]
        public string? journey { get; set; }

        public int? price { get; set; }

        [StringLength(15)]
        public string? carAssign { get; set; }

        public int? carYear { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string? empName { get; set; }

        public int? payByCash { get; set; }

        [StringLength(15)]
        public string? payWith { get; set; }

        [Column(TypeName = "text")]
        public string? memoInternal { get; set; }

        [Column(TypeName = "text")]
        public string? memoExternal { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoInMemo { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoExMemo { get; set; }

        public int? jobChecked { get; set; }

        [StringLength(25)]
        public string? Expr1 { get; set; }

        [StringLength(25)]
        public string? statusText { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerTID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int custContactID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderIrregularTID { get; set; }

        [StringLength(60)]
        public string? apptJobMemo { get; set; }

        [StringLength(100)]
        public string? rentEndDt { get; set; }
    }
}
