namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [MetadataType(typeof(CarPartItemMetadata))]
    [Table("CarPartItem")]
    public partial class CarPartItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarPartItem()
        {
            CarMaintainWithPart = new HashSet<CarMaintainWithPart>();
            CarPartItemWithCorporation = new HashSet<CarPartItemWithCorporation>();
        }

        [Key]
        public int carPartItemTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? itemName { get; set; }

        public decimal? itemCheckAfterMile { get; set; }

        public int itemCheckAfterMonth { get; set; }

        [StringLength(256)]
        public string? itemMemo { get; set; }

        public int itemShowOnReport { get; set; }

        [Required]
        [StringLength(12)]
        public string? itemStatus { get; set; }

        [Column(TypeName = "ntext")]
        public string? itemOkMemo { get; set; }

        [Column(TypeName = "ntext")]
        public string? itemFaultyMemo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarMaintainWithPart> CarMaintainWithPart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarPartItemWithCorporation> CarPartItemWithCorporation { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class CarPartItemMetadata
    {
        [Newtonsoft.Json.JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarMaintainWithPart>? CarMaintainWithPart { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarPartItemWithCorporation>? CarPartItemWithCorporation { get; set; }
    }
}
