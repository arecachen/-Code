namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CarCertTypeMetadata))]
    [Table("CarCertType")]
    public partial class CarCertType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarCertType()
        {
            CarCertificate = new HashSet<CarCertificate>();
        }

        [Key]
        public int carCertTypeTID { get; set; }

        [Required]
        [StringLength(25)]
        public string? carCertName { get; set; }

        public int carCertAlertDay { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarCertificate> CarCertificate { get; set; }
        public bool deleted { get; set; } = false;
    }
    public class CarCertTypeMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarCertificate>? CarCertificate { get; set; }
    }
}
