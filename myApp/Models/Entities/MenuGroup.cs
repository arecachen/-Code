namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(MenuGroupMetadata))]
    [Table("MenuGroup")]
    public partial class MenuGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuGroup()
        {
            AccessControlGroup = new HashSet<AccessControlGroup>();
        }

        [Key]
        public int groupTID { get; set; }

        [Required]
        [StringLength(256)]
        public string? subMenuIDs { get; set; }

        [Required]
        [StringLength(30)]
        public string? groupName { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessControlGroup> AccessControlGroup { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class MenuGroupMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<AccessControlGroup>? AccessControlGroup { get; set; }
    }
}
