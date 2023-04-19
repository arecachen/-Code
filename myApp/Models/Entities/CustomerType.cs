namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CustomerTypeMetadata))]
    [Table("CustomerType")]
    public partial class CustomerType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerType()
        {
            CustomerWithTypes = new HashSet<CustomerWithTypes>();
        }

        [Key]
        public int customerTypeTID { get; set; }

        [Required]
        [StringLength(25)]
        public string? custTypeName { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerWithTypes> CustomerWithTypes { get; set; }


        public bool deleted { get; set; } = false;
    }
    public class CustomerTypeMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CustomerWithTypes>? CustomerWithTypes { get; set; }
    }
}
