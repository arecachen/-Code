namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(FileFolderMetadata))]
    [Table("FileFolder")]
    public partial class FileFolder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileFolder()
        {
            FileInformation = new HashSet<FileInformation>();
        }

        [Key]
        public int FileFolderTID { get; set; }

        [Required]
        [StringLength(256)]
        public string? FolderTitle { get; set; }

        [StringLength(256)]
        public string? FolderInstroduction { get; set; }

        [Required]
        [StringLength(256)]
        public string? FolderCreateDate { get; set; }

        [StringLength(256)]
        public string? FolderEditDate { get; set; }

        public int FileGroupID { get; set; }

        public virtual FileGroup? FileGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileInformation> FileInformation { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class FileFolderMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<FileInformation>? FileInformation { get; set; }
    }
}
