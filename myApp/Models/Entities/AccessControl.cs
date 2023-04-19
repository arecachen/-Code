namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    [MetadataType(typeof(AccessControlMetadata))]
    [Table("AccessControl")]
    public partial class AccessControl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccessControl()
        {
            AccessControlGroup = new HashSet<AccessControlGroup>();
        }

        [Key]
        public int accessControlTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? ctPageName { get; set; }

        [Required]
        [StringLength(50)]
        public string? ctlPageID { get; set; }

        [Column(TypeName = "text")]
        public string? ctlMemo { get; set; }        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessControlGroup> AccessControlGroup { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class AccessControlMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<AccessControlGroup>? AccessControlGroup { get; set; }
    }
}
