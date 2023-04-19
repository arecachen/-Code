namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CorporationMetadata))]
    [Table("Corporation")]
    public partial class Corporation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Corporation()
        {
            AccessCorporation = new HashSet<AccessCorporation>();
            CarAccident = new HashSet<CarAccident>();
            CarFuelRecord = new HashSet<CarFuelRecord>();
            CarMaintaince = new HashSet<CarMaintaince>();
            CarPartItemWithCorporation = new HashSet<CarPartItemWithCorporation>();
        }

        [Key]
        public int corporationTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? corpName { get; set; }

        [Required]
        [StringLength(15)]
        public string? corpType { get; set; }

        [StringLength(50)]
        public string? corpPhone { get; set; }

        [StringLength(50)]
        public string? corpAddress { get; set; }

        [StringLength(50)]
        public string? corpContact { get; set; }

        [StringLength(50)]
        public string? corpMobile { get; set; }

        [Required]
        [StringLength(25)]
        public string? corpStatus { get; set; }

        public int corpOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessCorporation> AccessCorporation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarAccident> CarAccident { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarFuelRecord> CarFuelRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarMaintaince> CarMaintaince { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarPartItemWithCorporation> CarPartItemWithCorporation { get; set; }
        public bool deleted { get; set; } = false;
    }
    public class CorporationMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<AccessCorporation>? AccessCorporation { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarAccident>? CarAccident { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarFuelRecord>? CarFuelRecord { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarMaintaince>? CarMaintaince { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarPartItemWithCorporation>? CarPartItemWithCorporation { get; set; }
    }
}
