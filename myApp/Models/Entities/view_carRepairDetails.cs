namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_carRepairDetails
    {
        [Key]
        [StringLength(15)]
        public string? CarID { get; set; }

        public int? carMaintainTID { get; set; }

        public decimal? maintainMile { get; set; }

        public long? maintainDate { get; set; }

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

        [StringLength(50)]
        public string? itemName { get; set; }

        [StringLength(12)]
        public string? mtnStatus { get; set; }

        [StringLength(256)]
        public string? mtnFaultyDesc { get; set; }

        public int? mtnResolve { get; set; }

        public int? mtnCost { get; set; }

        [StringLength(30)]
        public string? futValue { get; set; }

        [StringLength(30)]
        public string? futText { get; set; }

        [StringLength(30)]
        public string? rsvValue { get; set; }

        [StringLength(30)]
        public string? rsvText { get; set; }
    }
}
