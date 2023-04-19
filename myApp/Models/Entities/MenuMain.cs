namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(MenuMainMetadata))]
    [Table("MenuMain")]
    public partial class MenuMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuMain()
        {
            MenuSub = new HashSet<MenuSub>();
        }

        [Key]
        public int menuMainTID { get; set; }

        [Required]
        [StringLength(20)]
        public string? mainName { get; set; }

        [Required]
        [StringLength(10)]
        public string? mainType { get; set; }

        [Required]
        [StringLength(256)]
        public string? mainLink { get; set; }

        public int mainNewWindow { get; set; }

        [StringLength(256)]
        public string? mainProp { get; set; }

        public int mainOrder { get; set; }

        [Required]
        [StringLength(10)]
        public string? mainStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuSub> MenuSub { get; set; }

        public bool deleted { get; set; } = false;
    }
    public class MenuMainMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<MenuSub>? MenuSub { get; set; }
    }
}
