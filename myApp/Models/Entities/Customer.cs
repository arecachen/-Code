namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CustomerMetadata))]
    [Table("Customer")]
    public partial class Customer //deprecation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            CustomerAddress = new HashSet<CustomerAddress>();
            CustomerContact = new HashSet<CustomerContact>();
            CustomerUniCode = new HashSet<CustomerUniCode>();
            CustomerWithTypes = new HashSet<CustomerWithTypes>();
            OrderCar = new HashSet<OrderCar>();
        }

        [Key]
        public int customerTID { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        [StringLength(50)]
        public string? mainPhone { get; set; }

        public int custSourceID { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Column(TypeName = "text")]
        public string? caution { get; set; }

        public int busAllian { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }

        public virtual CustomerSource? CustomerSource { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerContact> CustomerContact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerUniCode> CustomerUniCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerWithTypes> CustomerWithTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCar> OrderCar { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class CustomerMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CustomerAddress>? CustomerAddress { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CustomerContact>? CustomerContact { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CustomerUniCode>? CustomerUniCode { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CustomerWithTypes>? CustomerWithTypes { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCar>? OrderCar { get; set; }
    }
}
