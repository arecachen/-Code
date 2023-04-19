namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(OrderCarMetadata))]
    [Table("OrderCar")]
    public partial class OrderCar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderCar()
        {
            OrderCarInfo = new HashSet<OrderCarInfo>();
            OrderIrregular = new HashSet<OrderIrregular>();
            OrderRegular = new HashSet<OrderRegular>();
            OrderRegularContractPayment = new HashSet<OrderRegularContractPayment>();
            OrderRegularPayment = new HashSet<OrderRegularPayment>();
        }

        [Key]
        public int orderTID { get; set; }
        [Range(1,int.MaxValue, ErrorMessage = "必須有值")]
        public int? inTouchBy { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "必須有值")]
        public int? inChargeBy { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "必須有值")]
        public int? createBy { get; set; }

        public long createDatetime { get; set; }

        public long? lastUpdateDatetime { get; set; }
        [Range(1, int.MaxValue)]
        public int? lastUpdateBy { get; set; }

        public int custID { get; set; }
        [DisplayName("訂車人姓名 ")]
        [Range(1, int.MaxValue, ErrorMessage = "必須有值")]
        public int custContactID { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "必須有值")]
        public int? custWithCompID { get; set; }

        [Required(ErrorMessage ="ddd")]
        [StringLength(50)]
        public string? custContactName { get; set; }

        [StringLength(50)]
        public string? custContactPhone { get; set; }

        [Required(ErrorMessage ="手機不得空白")]
        [DisplayName("手機"), StringLength(50)]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "手機格式錯誤")]
        public string? custContactMobile { get; set; }

        [StringLength(50)]
        public string? custContactFax { get; set; }

        [Required]
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

        [Required]
        [StringLength(20)]
        public string? status { get; set; }

        public virtual Customer Customer { get; set; }
        [ForeignKey("custContactID")]
        public virtual CustomerContact CustomerContact { get; set; }
        [ForeignKey("custWithCompID")]
        public virtual CustomerWithCompany CustomerWithCompany { get; set; }
        public virtual CustomerUniCode CustomerUniCode { get; set; }

        public virtual EmployeeMain EmployeeMain { get; set; }

        public virtual EmployeeMain EmployeeMain1 { get; set; }

        public virtual EmployeeMain EmployeeMain2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarInfo> OrderCarInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderIrregular> OrderIrregular { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRegular> OrderRegular { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRegularContractPayment> OrderRegularContractPayment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRegularPayment> OrderRegularPayment { get; set; }
        [Column(TypeName = "text"), Display(Name = "訂單概要")]
        public string? schematic { get; set; }
        [Column(TypeName = "text"), Display(Name = "訂單筆記")]
        public string? notes { get; set; }
        public bool deleted { get; set; } = false;
        public int? orgCustContactID { get; set; }

        [NotMapped, Display(Name = "總車趟數")]
        public int carTimes { get; set; }
        [NotMapped, Display(Name = "總車資")]
        public int carFee { get; set; }
        [NotMapped, Display(Name = "行程內容")]
        public string? jounery { get; set; }
        [NotMapped, Display(Name = "住宿飯店")]
        public string? accomodation { get; set; }
        [NotMapped, Display(Name = "餐廳")]
        public string? restruant { get; set; }
        [NotMapped, Display(Name = "景點")]
        public string? attractions { get; set; }
        [NotMapped]
        public string? createDate
        {
            get { return createDatetime.StampToDateString(); }
            set { createDatetime = value.ToDateLong(); }
        }
        [NotMapped]
        public string? sLastUpdateDatetime
        {
            get { return lastUpdateDatetime.LongToDateString(); }
            set { lastUpdateDatetime = value.ToDateLong(); }
        }
        [NotMapped]
        public string? compName { get; set; }
        [NotMapped]
        public string? sStatus
        {
            get
            {
                return (status == "NTPQuote") ? "尚未建案"
                    : (status == "Create") ? "已建案"
                    : (status == "Prepare") ? "準備中"
                    : (status == "Working") ? "執行中"
                    : (status == "Complete") ? "服務結束"
                    : (status == "Cancel") ? "取消"
                    : (status == "Dispute") ? "爭議處理中"
                    : "契合中";
            }
        }
    }
    public class OrderCarMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCarInfo>? OrderCarInfo { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderIrregular>? OrderIrregular { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderRegular>? OrderRegular { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderRegularContractPayment>? OrderRegularContractPayment { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderRegularPayment>? OrderRegularPayment { get; set; }
    }
}
