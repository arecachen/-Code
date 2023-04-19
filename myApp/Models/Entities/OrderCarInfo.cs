namespace hsintongERP2022.Models
{
    using Altways;
    using Howgreater.util;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrderCarInfo")]
    public partial class OrderCarInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderCarInfo()
        {
            CarAppointment = new HashSet<CarAppointment>();
            OrderCarInfoPassenger_del = new HashSet<OrderCarInfoPassenger_del>();
            OrderCarInfoPayRecord = new HashSet<OrderCarInfoPayRecord>();
            OrderCarInfoWithEquip = new HashSet<OrderCarInfoWithEquip>();
        }

        [Key]
        public int orderCarInfoTID { get; set; }

        public int orderCarID { get; set; }

        [Required]
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
        public string? status { get; set; }

        public int jobChecked { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoInMemo { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoExMemo { get; set; }
        [Display(Name = "貼條"), StringLength(256), MaxLength(256, ErrorMessage = "長度不可超過 256個字")]
        public string? sticker { get; set; }
        [Display(Name = "贈品"), StringLength(256), MaxLength(256, ErrorMessage = "長度不可超過 256個字")]
        public string? gift { get; set; }
        [Display(Name = "附贈品")]
        public bool withGift { get; set; }
        [Display(Name = "保險")]
        public bool withInsurance { get; set; }
        [Display(Name = "領隊")]
        public bool withGuide { get; set; }
        [Display(Name = "收客")]
        public bool receiveCustomers { get; set; }
        [Display(Name = "回程時間")]
        public TimeSpan? backTime { get; set; }
        [Display(Name = "結束時間")]
        public TimeSpan? finishedTime { get; set; }
        public virtual CarMain CarMain { get; set; }
        [ForeignKey("carDriver")]
        public virtual EmployeeMain EmployeeMain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarAppointment> CarAppointment { get; set; }
        [ForeignKey("orderCarID")]
        public virtual OrderCar OrderCar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarInfoPassenger_del> OrderCarInfoPassenger_del { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarInfoPayRecord> OrderCarInfoPayRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarInfoWithEquip> OrderCarInfoWithEquip { get; set; }

        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? sRentStartDate
        {
            get { return rentStartDate.LongToDateString(); }
            set { rentStartDate = value.ToDateLong(); }
        }
        [NotMapped]
        public TimeSpan? rentArriveTime
        {
            get { return new TimeSpan(rentArriveHour ?? 0, rentArriveMinute ?? 0, 0); }
            set { rentArriveHour = value.Ensure(x => x.Value.Hours, 0); rentArriveMinute = value.Ensure(x => x.Value.Minutes, 0); }
        }
        [NotMapped]
        public string? sRentArriveTime
        {
            get { return string.Format("{0}:{1}", (rentArriveHour ?? 0).ToString("00"), (rentArriveMinute ?? 0).ToString("00")); }
            set { rentArriveHour = value.Ensure(x => x.Split(':')[0]).ToInt(0); rentArriveMinute = value.Ensure(x => x.Split(':')[1]).ToInt(0); }
        }
        [NotMapped]
        public string? sWithTourSticker { get { return sWithTour(withTourSticker.HasValue ? withTourSticker.Value : -1); } }
        [NotMapped]
        public bool bJobChecked
        {
            get { return jobChecked > 0; }
            set { jobChecked = value ? 1 : 0; }
        }
        [NotMapped]
        public bool bInsurancePaidBy
        {
            get { return insurancePaidBy > 0; }
            set { insurancePaidBy = (value) ? 1 : 0; }
        }
        [NotMapped]
        public int? tipType
        {
            get
            {
                return (priceTour > 0) ? 1 : (priceTip > 0) ? 2 : (int?)null;
            }
            set
            {
                switch (value)
                {
                    case 1:
                        priceTour = 1;
                        priceTip = 0;
                        break;
                    case 2:
                        priceTour = 0;
                        priceTip = 1;
                        break;
                    default:
                        priceTour = 0;
                        priceTip = 0;
                        break;
                }
            }
        }
        [NotMapped]
        public bool bPriceParking
        {
            get { return priceParking > 0; }
            set { priceParking = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bPriceTax
        {
            get { return priceTax > 0; }
            set { priceTax = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourContract
        {
            get { return withTourContract > 0; }
            set { withTourContract = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourQuotation
        {
            get { return withTourQuotation > 0; }
            set { withTourQuotation = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourInvoice
        {
            get { return withTourInvoice > 0; }
            set { withTourInvoice = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourReceipt
        {
            get { return withTourReceipt > 0; }
            set { withTourReceipt = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourInsurace
        {
            get { return withTourInsurace > 0; }
            set { withTourInsurace = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourSticker
        {
            get { return withTourSticker > 0; }
            set { withTourSticker = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourPaymentAccount
        {
            get { return withTourPaymentAccount > 0; }
            set { withTourPaymentAccount = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourSecurityCheck
        {
            get { return withTourSecurityCheck > 0; }
            set { withTourSecurityCheck = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourCarDetails
        {
            get { return withTourCarDetails > 0; }
            set { withTourCarDetails = (value) ? 1 : 0; }
        }
        [NotMapped]
        public bool bWithTourOther
        {
            get { return withTourOther > 0; }
            set { withTourOther = (value) ? 1 : 0; }
        }
        public string? sWithTour(int idx)
        {
            return (idx == 0)
                ? "不需要" : (idx == 1)
                ? "需要，未處理" : (idx == 2)
                ? "需要，已處理" : (idx == 3)
                ? "需要，已裝?" : "未定";
        }

    }
}
