namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_CarMaintainList
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string? CarID { get; set; }

        public int? carMaintainTID { get; set; }

        public long? maintainDate { get; set; }

        public decimal? maintainMile { get; set; }

        [StringLength(12)]
        public string? maintainType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string? status { get; set; }

        public int? carMaintainWithItemTID { get; set; }

        public int? carMaintainItemTID { get; set; }

        [StringLength(50)]
        public string? itemName { get; set; }

        [StringLength(12)]
        public string? mtnStatus { get; set; }

        [StringLength(256)]
        public string? mtnFaultyDesc { get; set; }

        public int? mtnResolve { get; set; }

        public decimal? nextCheckMile { get; set; }

        public long? nextCheckDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carManuYear { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carManuMonth { get; set; }

        public int? mtnChecked { get; set; }

        public int? mtnResolveCheck { get; set; }

        public int? driver { get; set; }
    }
}
