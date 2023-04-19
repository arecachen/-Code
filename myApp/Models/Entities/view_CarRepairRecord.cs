namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_CarRepairRecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string? carID { get; set; }

        [StringLength(15)]
        public string? ticketID { get; set; }

        public long? fileCreateDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal maintainMile { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long maintainDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(12)]
        public string? maintainType { get; set; }

        [StringLength(256)]
        public string? maintainMemo { get; set; }

        public int? corporationID { get; set; }

        [StringLength(50)]
        public string? maintainPerformBy { get; set; }

        public int? maintainByDriver { get; set; }

        public decimal? nextMaintainMile { get; set; }

        public long? nextMaintainDate { get; set; }

        public int? nextMaintainExecuted { get; set; }

        public decimal? nextMaintainMile2 { get; set; }

        public long? nextMaintainDate2 { get; set; }

        public int? nextMaintainExecuted2 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int driver { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainItemTID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string? itemName { get; set; }

        [StringLength(256)]
        public string? itemMemo { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int itemShowOnReport { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(12)]
        public string? itemStatus { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int corporationTID { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string? corpName { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(15)]
        public string? corpType { get; set; }

        [StringLength(50)]
        public string? corpPhone { get; set; }

        [StringLength(50)]
        public string? corpAddress { get; set; }

        [StringLength(50)]
        public string? corpContact { get; set; }

        [StringLength(50)]
        public string? corpMobile { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(25)]
        public string? corpStatus { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int corpOrder { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carMaintainWithItemTID { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(12)]
        public string? mtnStatus { get; set; }

        [StringLength(256)]
        public string? mtnFaultyDesc { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mtnResolve { get; set; }

        [Key]
        [Column(Order = 18)]
        public int? mtnCost { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mtnShowOnReport { get; set; }

        public decimal? nextCheckMile { get; set; }

        public long? nextCheckDate { get; set; }

        public int? mtnChecked { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int busAllian { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(10)]
        public string? carStatus { get; set; }
    }
}
