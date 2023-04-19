namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(FinAccountCodeMainMetadata))]
    [Table("FinAccountCodeMain")]
    public partial class FinAccountCodeMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinAccountCodeMain()
        {
            FinAccountCodeItem = new HashSet<FinAccountCodeItem>();
        }

        [Key]
        public int FinAccountCodeMainTID { get; set; }

        [Required]
        [StringLength(20)]
        public string? FinAccCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? FinAccName { get; set; }

        [Required]
        [StringLength(20)]
        public string? FinAccDirection { get; set; }

        public int FinAccOrder { get; set; }   
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinAccountCodeItem> FinAccountCodeItem { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class FinAccountCodeMainMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<FinAccountCodeItem>? FinAccountCodeItem { get; set; }
    }
}
