namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarMaintainWithItem")]
    public partial class CarMaintainWithItem
    {
        [Key]
        public int carMaintainWithItemTID { get; set; }

        public int carMaintainID { get; set; }

        public int carMaintainItemID { get; set; }

        [Required]
        [StringLength(12)]
        public string? mtnStatus { get; set; }

        [StringLength(256)]
        public string? mtnFaultyDesc { get; set; }

        public int mtnResolve { get; set; }

        public int? mtnCost { get; set; }

        public int mtnShowOnReport { get; set; }

        public decimal? nextCheckMile { get; set; }

        public long? nextCheckDate { get; set; }

        public int? mtnChecked { get; set; }

        public int? mtnResolveCheck { get; set; }

        public bool deleted { get; set; } = false;
        [ForeignKey("carMaintainID")]
        public virtual CarMaintaince? CarMaintaince { get; set; }
        [ForeignKey("carMaintainItemID")]
        public virtual CarMaintainItem? CarMaintainItem { get; set; }
        [ForeignKey("carMaintainItemID")]
        public virtual CarPartItem? CarPartItem { get; set; }
        [NotMapped]
        public string? sNextCheckDate
        {
            get { return ((long?)nextCheckDate).LongToDateString(); }
            set { nextCheckDate = value.ToDateLong(); }
        }
        [NotMapped]
        public bool? bMtnChecked
        {
            get { return (mtnChecked == null) ? (bool?)null : mtnChecked.Value > 0; }
            set
            {
                mtnChecked = (value == null) ? (int?)null : (value.Value) ? 1 : 0;
            }
        }
        [NotMapped]
        public bool? bMtnResolveCheck
        {
            get
            {
                return (mtnResolveCheck == null) ? (bool?)null : (mtnResolveCheck == 1);
            }
            set
            {
                if (value == null)
                    mtnResolveCheck = null;
                else
                    mtnResolveCheck = (value.Value) ? 1 : 2;
            }
        }
        [NotMapped]
        public bool bMtnShowOnReport
        {
            get { return (mtnShowOnReport == 1); }
            set { mtnShowOnReport = value ? 1 : 0; }
        }
    }
}
