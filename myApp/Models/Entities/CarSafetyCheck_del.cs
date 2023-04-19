namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarSafetyCheck_del
    {
        [Key]
        public int carSafetyCheckTID { get; set; }

        [Required]
        [StringLength(15)]
        public string? carID { get; set; }

        public int checkBy { get; set; }

        public long checkDate { get; set; }

        public int chkSafetyDoorOpen { get; set; }

        public int chkSafetyDoorTag { get; set; }

        public int chkSafeWayClear { get; set; }

        public int chkSafeWayWidth320 { get; set; }

        public int chkFireRescue2 { get; set; }

        public long chkFireResuceDate1 { get; set; }

        public long chkFireResuceDate2 { get; set; }

        public int chkWindowCrack3 { get; set; }

        public int chkWindowCrackTag { get; set; }

        public int chkFrontSeat700 { get; set; }

        public int chkFrontSeatBar { get; set; }

        public int chkBoostClear { get; set; }

        public int chkWheel16 { get; set; }

        public int chkWheelSurface { get; set; }

        [Required]
        [StringLength(256)]
        public string? chkDocument { get; set; }

        public bool deleted { get; set; } = false;
    }
}
