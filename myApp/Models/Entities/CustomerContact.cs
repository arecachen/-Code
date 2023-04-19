namespace hsintongERP2022.Models
{
    using Altways;
    using Howgreater.util;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CustomerContactMetadata))]
    [Table("CustomerContact")]
    public partial class CustomerContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerContact()
        {
            OrderCar = new HashSet<OrderCar>();
        }

        [Key]
        public int customerContactTID { get; set; }

        public int custID { get; set; } = 0;

        [Required]
        [StringLength(50)]
        public string? custName { get; set; }

        [StringLength(50)]
        public string? custPhone { get; set; }
        [Required]
        [StringLength(50)]
        public string? custMobile { get; set; } = "";

        [StringLength(256)]
        public string? custEmail { get; set; }

        [StringLength(50)]
        public string? custFax { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; } = "";

        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCar> OrderCar { get; set; }

        [Column(TypeName = "text")]
        [Display(Name = "�`�N")]
        public string? Caution { get; set; }
        [Display(Name = "�ӷ�")]
        public int? customerSourceTID { get; set; }
        [Display(Name = "�L�b�Ȥ�")]

        public bool potentialCust { get; set; }
        [Display(Name = "�إ߮ɶ�")]
        public long createDate { get; set; }
        [Display(Name = "�̫�ק�ɶ�")]
        public long lastUpdateDate { get; set; }
        [Display(Name = "�إߤH��")]
        public int createdBy { get; set; }
        [Display(Name = "�Ȥ����?")]
        public CustCategory custCategory { get; set; }
        [Display(Name = "�٩I"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? salutations { get; set; }
        [Display(Name = "���Y"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? title { get; set; }
        [Display(Name = "���?"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? organization { get; set; }
        [ForeignKey("customerSourceTID")]
        public CustomerSource customerSource { get; set; }

        public virtual IEnumerable<CustomerWithCompany> WithCompanies { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? Phone { get { return custPhone.Ensure(x => x, "").RemoveNonNumber(); } }
        [NotMapped]
        public string? Mobile { get { return custMobile.Ensure(x => x, "").RemoveNonNumber(); } }
        [NotMapped]
        public string? custSource { get { return customerSourceTID.ToString(); } set { customerSourceTID = value.Ensure(x => x.ToInt(0), null); } }
        [NotMapped]
        public string? withCompany { get; set; }
        [NotMapped]
        public string? compId { get; set; }
    }
    public class CustomerWithCompany
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public int customerId { get; set; }
        [Required]
        public int companyId { get; set; }

        public bool deleted { get; set; } = false;
        [ForeignKey("customerId")]
        public CustomerContact? customerContact { get; set; }
        [ForeignKey("companyId")]
        public CustomerCompany? customerCompany { get; set; }
    }
    public class Organization
    {
        [Key, Required]
        public int Id { get; set; }
        [Display(Name = "���W��"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? name { get; set; }
        public bool deleted { get; set; } = false;
    }
    public enum CustCategory
    {
        pure = 0,//�Ȥ�
        peer = 1 //�P�~
    }
    public class CustomerContactMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCar>? OrderCar { get; set; }
    }
}
