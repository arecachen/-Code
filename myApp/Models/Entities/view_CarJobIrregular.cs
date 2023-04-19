namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_CarJobIrregular
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderCarInfoTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderCarID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string? carType { get; set; }

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
        public string? OrderCarInfo_Status { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int jobChecked { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoInMemo { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoExMemo { get; set; }

        [StringLength(15)]
        public string? CarID { get; set; }

        [StringLength(30)]
        public string? dicValue { get; set; }

        [StringLength(30)]
        public string? dicText { get; set; }

        [StringLength(10)]
        public string? Car_Status { get; set; }

        [StringLength(20)]
        public string? OrderCar_Status { get; set; }
    }
}
