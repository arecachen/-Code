namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_CarMaintainTracking_MaintainItems
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string? CarID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carManuYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carManuMonth { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string? carMake { get; set; }

        public long? purchaseDate { get; set; }

        public int? driver { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int busAllian { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string? carStatus { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string? empName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainWithItemTID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainItemID { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string? itemName { get; set; }

        [StringLength(256)]
        public string? itemMemo { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int itemShowOnReport { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(12)]
        public string? itemStatus { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(12)]
        public string? mtnStatus { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(30)]
        public string? mtnStatusText { get; set; }

        [StringLength(256)]
        public string? mtnFaultyDesc { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mtnResolve { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(30)]
        public string? mtnResolveText { get; set; }

        public decimal? nextCheckMile { get; set; }

        public long? nextCheckDate { get; set; }

        public int? mtnChecked { get; set; }

        public int? mtnResolveCheck { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long lastMile { get; set; }

        public decimal? mileToCheck { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainTID { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long maintainDate { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal maintainMile { get; set; }

        public long? fileCreateDate { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(12)]
        public string? maintainType { get; set; }

        [StringLength(256)]
        public string? maintainMemo { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(50)]
        public string? driverName { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(50)]
        public string? corpName { get; set; }

        [StringLength(50)]
        public string? maintainPerformBy { get; set; }

        [StringLength(15)]
        public string? ticketID { get; set; }

        [Key]
        [Column(Order = 23)]
        public int? mtnCost { get; set; }
    }
}
