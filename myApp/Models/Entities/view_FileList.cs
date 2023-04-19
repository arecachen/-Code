namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_FileList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileGroupTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string? GroupName { get; set; }

        public int? GroupOrder { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileFolderTID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string? FolderTitle { get; set; }

        [StringLength(256)]
        public string? FolderInstroduction { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(256)]
        public string? FolderCreateDate { get; set; }

        [StringLength(256)]
        public string? FolderEditDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileGroupID { get; set; }
    }
}
