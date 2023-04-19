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
        [Range(1,int.MaxValue, ErrorMessage = "��������")]
        public int? inTouchBy { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "��������")]
        public int? inChargeBy { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "��������")]
        public int? createBy { get; set; }

        public long createDatetime { get; set; }

        public long? lastUpdateDatetime { get; set; }
        [Range(1, int.MaxValue)]
        public int? lastUpdateBy { get; set; }

        public int custID { get; set; }
        [DisplayName("�q���H�m�W ")]
        [Range(1, int.MaxValue, ErrorMessage = "��������")]
        public int custContactID { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "��������")]
        public int? custWithCompID { get; set; }

        [Required(ErrorMessage ="ddd")]
        [StringLength(50)]
        public string? custContactName { get; set; }

        [StringLength(50)]
        public string? custContactPhone { get; set; }

        [Required(ErrorMessage ="������o�ť�")]
        [DisplayName("���"), StringLength(50)]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "����榡���~")]
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
        [Column(TypeName = "text"), Display(Name = "�q�淧�n")]
        public string? schematic { get; set; }
        [Column(TypeName = "text"), Display(Name = "�q�浧�O")]
        public string? notes { get; set; }
        public bool deleted { get; set; } = false;
        public int? orgCustContactID { get; set; }

        [NotMapped, Display(Name = "�`�����")]
        public int carTimes { get; set; }
        [NotMapped, Display(Name = "�`����")]
        public int carFee { get; set; }
        [NotMapped, Display(Name = "��{���e")]
        public string? jounery { get; set; }
        [NotMapped, Display(Name = "��J����")]
        public string? accomodation { get; set; }
        [NotMapped, Display(Name = "�\�U")]
        public string? restruant { get; set; }
        [NotMapped, Display(Name = "���I")]
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
                return (status == "NTPQuote") ? "�|���خ�"
                    : (status == "Create") ? "�w�خ�"
                    : (status == "Prepare") ? "�ǳƤ�"
                    : (status == "Working") ? "���椤"
                    : (status == "Complete") ? "�A�ȵ���"
                    : (status == "Cancel") ? "����"
                    : (status == "Dispute") ? "��ĳ�B�z��"
                    : "���X��";
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
