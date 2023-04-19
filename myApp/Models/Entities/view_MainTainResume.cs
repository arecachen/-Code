namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_MainTainResume
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long maintainDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal maintainMile { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string? carID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainItemTID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainTID { get; set; }

        [StringLength(256)]
        public string? mtnFaultyDesc { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string? itemName { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainItemID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string? corpName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string? mStatus { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(30)]
        public string? mResolve { get; set; }
    }
}
