namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CustomerUniCodeMetadata))]
    [Table("CustomerUniCode")]
    public partial class CustomerUniCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerUniCode()
        {
            OrderCar = new HashSet<OrderCar>();
        }

        [Key]
        public int customerUniCodeTID { get; set; }

        public int custID { get; set; }

        [Required]
        [StringLength(15)]
        public string? uniCode { get; set; }

        [Required]
        [StringLength(100)]
        public string? uniName { get; set; }

        public virtual Customer? Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCar> OrderCar { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class CustomerUniCodeMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCar>? OrderCar { get; set; }
    }
}
