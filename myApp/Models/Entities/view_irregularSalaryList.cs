namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_irregularSalaryList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderCarJobTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carOrderInfoID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carOrderRegularInfoID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SourceOrderCarJobID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string? carID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int driver { get; set; }

        [StringLength(30)]
        public string? carType { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long useDate { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carStartHour { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carStartMin { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carEndHour { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carEndMin { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(15)]
        public string? apptType { get; set; }

        [Key]
        [Column(Order = 12)]
        public string? apptMemo { get; set; }

        public string? apptJobMemo { get; set; }

        public string? unpickMemo { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int apptSalary { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int apptCharge { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isTakeApart { get; set; }

        [Key]
        [Column(Order = 16)]
        public int? cost { get; set; }

        [Key]
        [Column(Order = 17)]
        public int? SalaryTips { get; set; }

        [Key]
        [Column(Order = 18)]
        public int? SalaryTrip { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(20)]
        public string? finalStatus { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(50)]
        public string? JobSource { get; set; }

        [Column(TypeName = "text")]
        public string? CheckinLocation { get; set; }

        public int? orderCarInfoTID { get; set; }

        public int? orderCarID { get; set; }

        [StringLength(10)]
        public string? Expr1 { get; set; }

        public int? carYear { get; set; }

        public long? rentStartDate { get; set; }

        public int? rentLength { get; set; }

        public int? rentArriveHour { get; set; }

        public int? rentArriveMinute { get; set; }

        [StringLength(100)]
        public string? rentArriveLocation { get; set; }

        public int? pickAtMLocation { get; set; }

        [StringLength(256)]
        public string? journey { get; set; }

        public int? returnHour { get; set; }

        public int? returnMinute { get; set; }

        public int? endHour { get; set; }

        public int? endMinute { get; set; }

        [StringLength(50)]
        public string? withCarContactName { get; set; }

        [StringLength(50)]
        public string? withCarContactPhone { get; set; }

        [StringLength(50)]
        public string? withCarContactMobile { get; set; }

        public int? price { get; set; }

        public int? priceTour { get; set; }

        public int? priceTip { get; set; }

        public int? priceParking { get; set; }

        public int? priceTax { get; set; }

        public int? costTip { get; set; }

        public int? costAccomodation { get; set; }

        public int? priceInsurance { get; set; }

        public int? insurancePaidBy { get; set; }

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

        [StringLength(15)]
        public string? carAssign { get; set; }

        public int? carDriver { get; set; }

        [StringLength(50)]
        public string? carGuide { get; set; }

        [StringLength(20)]
        public string? jobType { get; set; }

        [StringLength(20)]
        public string? status { get; set; }

        public int? jobChecked { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoInMemo { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoExMemo { get; set; }

        public int? orderTID { get; set; }

        public int? inTouchBy { get; set; }

        public int? inChargeBy { get; set; }

        public int? createBy { get; set; }

        public long? createDatetime { get; set; }

        public long? lastUpdateDatetime { get; set; }

        public int? lastUpdateBy { get; set; }

        public int? custID { get; set; }

        public int? custContactID { get; set; }

        [StringLength(50)]
        public string? custContactName { get; set; }

        [StringLength(50)]
        public string? custContactPhone { get; set; }

        [StringLength(50)]
        public string? custContactMobile { get; set; }

        [StringLength(50)]
        public string? custContactFax { get; set; }

        [StringLength(20)]
        public string? orderSource { get; set; }

        [StringLength(20)]
        public string? orderType { get; set; }

        public int? payByCash { get; set; }

        public int? payByTransfer { get; set; }

        public int? payByInfo { get; set; }

        public int? payTermMonthly { get; set; }

        public int? payPaid { get; set; }

        [StringLength(15)]
        public string? payWith { get; set; }

        public int? payAmountShow { get; set; }

        public int? payToCustUniCode { get; set; }

        [StringLength(256)]
        public string? extraDocument { get; set; }

        [Column(TypeName = "text")]
        public string? memoExternal { get; set; }

        [Column(TypeName = "text")]
        public string? memoInternal { get; set; }

        public long? regu_contractStart { get; set; }

        public long? regu_contractEnd { get; set; }

        [StringLength(20)]
        public string? Expr2 { get; set; }

        public int? customerTID { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        [StringLength(50)]
        public string? mainPhone { get; set; }

        public int? custSourceID { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Column(TypeName = "text")]
        public string? caution { get; set; }

        public int? busAllian { get; set; }

        [StringLength(10)]
        public string? Expr3 { get; set; }
    }
}
