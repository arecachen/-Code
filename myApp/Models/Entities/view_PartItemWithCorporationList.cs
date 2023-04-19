namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_PartItemWithCorporationList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carPartItemTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string? itemName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int corporationTID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string? corpName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string? corpType { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string? corpStatus { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int corpOrder { get; set; }
    }
}
