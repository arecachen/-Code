namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(FileGroupMetadata))]
    [Table("FileGroup")]
    public partial class FileGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileGroup()
        {
            FileFolder = new HashSet<FileFolder>();
        }

        [Key]
        public int FileGroupTID { get; set; }

        [Required]
        [StringLength(256)]
        public string? GroupName { get; set; }

        public int? GroupOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileFolder> FileFolder { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class FileGroupMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<FileFolder>? FileFolder { get; set; }
    }
}
