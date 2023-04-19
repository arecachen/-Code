namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CarMainMetadata))]
    [Table("CarMain")]
    public partial class CarMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarMain()
        {
            CarAccident = new HashSet<CarAccident>();
            CarCertificate = new HashSet<CarCertificate>();
            CarFuelRecord = new HashSet<CarFuelRecord>();
            CarFined = new HashSet<CarFined>();
            CarMaintaince = new HashSet<CarMaintaince>();
            CarNotAvailable = new HashSet<CarNotAvailable>();
            CarSafetyRecord = new HashSet<CarSafetyRecord>();
            CarWithEquipment = new HashSet<CarWithEquipment>();
            OrderCarInfo = new HashSet<OrderCarInfo>();
        }

        [Key]
        [StringLength(15)]
        public string? CarID { get; set; }

        public int carManuYear { get; set; }

        public int carManuMonth { get; set; }
        [NotMapped]
        public string? carManuYM { get { return string.Format("{0}/{1}", carManuYear.ToString("0000"), carManuMonth.ToString("00")); } }
        [Required]
        [StringLength(30)]
        public string? carMake { get; set; }

        public int carSite { get; set; }

        [StringLength(15)]
        public string? carSize { get; set; }

        public long? purchaseDate { get; set; }

        public int? purchaseAmount { get; set; }

        public decimal? purchaseMile { get; set; }

        public long? SellDate { get; set; }

        public int? driver { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        public int busAllian { get; set; }
        public string? sBusAllian { get{return (busAllian==0)?"�_":"�O"; } }

        public int carDept { get; set; }

        public int carGroup { get; set; }

        public decimal maintainMileRange { get; set; }

        public int maintainDaysRange { get; set; }

        [StringLength(50)]
        public string? CompanyBelong { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarAccident> CarAccident { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarCertificate> CarCertificate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarFuelRecord> CarFuelRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarFined> CarFined { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarMaintaince> CarMaintaince { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarNotAvailable> CarNotAvailable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarSafetyRecord> CarSafetyRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarWithEquipment> CarWithEquipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarInfo> OrderCarInfo { get; set; }

        public bool deleted { get; set; } = false;
        [ForeignKey("driver")]
        public virtual EmployeeMain EmployeeMain { get; set; }
        [NotMapped]
        [Display(Name = "����/���A")]
        public string? carNo_status { get; set; }
        [NotMapped]
        [Display(Name = "�Y�N������ҷ�")]
        public string? certDue { get; set; }
        [NotMapped]
        public string? sPurchaseDate
        {
            get { return ((long?)purchaseDate).LongToDateString(); }
            set { purchaseDate = value.ToDateLong(); }
        }
        [NotMapped]
        public string? sSellDate
        {
            get { return ((long?)SellDate).LongToDateString(); }
            set { SellDate = value.ToDateLong(); }
        }
        [NotMapped]
        public string? lastFuelDate { get; set; }
        [NotMapped]
        public int lastFuelMiles { get; set; }
        [NotMapped]
        public string? sStatus
        {
            get
            {
                return (status == "Active") ? "���`"
                    : (status == "Maintaince") ? "����"
                  : (status == "Sold") ? "��X"
                   : (status == "Revocation") ? "���o"
                    : "���w";
            }
        }
        [NotMapped]
        public string? car_id { get { return CarID.Replace("-", ""); } }
    }
    public class CarMainMetadata
    {
        [Required]
        [Display(Name = "����/�P�~�W��")]
        public string? CarID { get; set; }
        [Display(Name = "�t�P")]
        public string? carMake { get; set; }
        [Display(Name = "�X�t�~")]
        public int carManuYear { get; set; }
        [Display(Name = "�X�t��")]
        public int carManuMonth { get; set; }
        [Display(Name = "�y���")]
        public int carSite { get; set; }
        [Display(Name = "�U���O�i���{���Z")]
        public int maintainMileRange { get; set; }
        [Display(Name = "�U���O�i��ƶ��Z")]
        public int maintainDaysRange { get; set; }
        [Display(Name = "���A")]
        public string? status { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarAccident>? CarAccident { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarCertificate>? CarCertificate { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarFuelRecord>? CarFuelRecord { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarFined>? CarFined { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarMaintaince>? CarMaintaince { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarNotAvailable>? CarNotAvailable { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarSafetyRecord>? CarSafetyRecord { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarWithEquipment>? CarWithEquipment { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCarInfo>? OrderCarInfo { get; set; }
    }
}
