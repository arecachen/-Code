namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_MenuList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int menuMainTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string? mainName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string? mainType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string? mainLink { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mainNewWindow { get; set; }

        [StringLength(256)]
        public string? mainProp { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mainOrder { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string? mainStatus { get; set; }

        public int? menuSubTID { get; set; }

        [StringLength(20)]
        public string? subName { get; set; }

        [StringLength(20)]
        public string? subType { get; set; }

        [StringLength(256)]
        public string? subLink { get; set; }

        public int? subNewWindow { get; set; }

        [StringLength(256)]
        public string? subProp { get; set; }

        public int? subOrder { get; set; }

        [StringLength(20)]
        public string? subStatus { get; set; }

        public int? upperSub { get; set; }
    }
}
