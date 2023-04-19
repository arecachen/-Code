namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CustomerSourceMetadata))]
    [Table("CustomerSource")]
    public partial class CustomerSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerSource()
        {
            Customer = new HashSet<Customer>();
        }

        [Key]
        public int customerSourceTID { get; set; }

        [Required]
        [StringLength(25)]
        public string? custSourceName { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customer { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class CustomerSourceMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Customer>? Customer { get; set; }

    }
}
