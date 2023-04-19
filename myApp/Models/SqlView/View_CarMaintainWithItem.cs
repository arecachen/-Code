using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class ViewCarMaintainWithItem
    {
        //public int carMaintainWithItemTID { get; set; }
        public int Tid { get; set; }
        public int carMaintainID { get; set; }
        //public int carMaintainItemID { get; set; }
        public int ItemId { get; set; }
        public string? mtnStatus { get; set; }
        public string? FaultyDesc { get; set; }
        public int? Resolve { get; set; }
        public string? carID { get; set; }
        public string? ticketID { get; set; }

        public string? mtnFaultyDesc { get; set; }
        //public int? mtnResolve { get; set; }
        public int? mtnCost { get; set; }
        public int mtnShowOnReport { get; set; }
        public decimal? nextCheckMile { get; set; }
        public long? nextCheckDate { get; set; }

        public int? mtnChecked { get; set; }
        public int? mtnResolveCheck { get; set; }
        public long? maintainDate { get; set; }
        public string? maintainMemo { get; set; }
        public int? corporationID { get; set; }
        public string? corpName { get; set; }
        public string? itemName { get; set; }
        public string? carStatus { get; set; }
        [NotMapped]
        public string? sNextCheckDate { get { return (nextCheckDate.HasValue) ? nextCheckDate.Value.StampToDateString() : ""; } }
        [NotMapped]
        public string? sMaintainDate { get { return (maintainDate.HasValue) ? maintainDate.Value.StampToDateString() : ""; } }
        public decimal? maintainMile { get; set; }
        public string? maintainType { get; set; }
        //public long? fileCreateDate { get; set; }
        //[NotMapped]
        //public string? sFileCreateDate { get { return (fileCreateDate.HasValue) ? fileCreateDate.Value.StampToDateString() : ""; } }
        [NotMapped]
        public bool? bMtnChecked
        {
            get { return (mtnChecked == null) ? (bool?)null : mtnChecked.Value > 0; }

        }
        public bool bResolve
        {
            get { return (Resolve == 0 || Resolve == 3 || Resolve == 2); }
            //set { Resolve = (Resolve == 0 || Resolve == 3)?Resolve: (value) ? 2 : 1; }
        }
        public bool? bMtnResolveCheck
        {
            get
            {
                return (mtnResolveCheck == null) ? false : (mtnResolveCheck == 1);
            }

            //set
            //{
            //    if (value == null)
            //        mtnResolveCheck = null;
            //    else
            //        mtnResolveCheck = (value.Value) ? 1 : 2;
            //}
        }
        public string? empName { get; set; }
        public int? carManuYear { get; set; }
        public int? carManuMonth { get; set; }
        public int? currentMile { get; set; }
        [NotMapped]
        public string? sMmaintainMile { get { return (maintainMile == null) ? "--": maintainMile.Value.ToString("#,##0"); } }
        [NotMapped]
        public string? sMtnStatus { get { return (mtnStatus == "good") ? "良好" : (mtnStatus == "ok") ? "尚可" : "需維修"; } }
        [NotMapped]
        public string? sResolve { get { return (Resolve == 0) ? "無異常" : (Resolve == 1) ? "異常，尚未排除" : (Resolve == 2) ? "異常，已排除" : "異常，不排除"; } }
        //public string? maintainPerformBy { get; set; }
        //public int? maintainByDriver { get; set; }
        //public decimal? nextMaintainMile { get; set; }
        // public long? nextMaintainDate { get; set; }
        // [NotMapped]
        //public string? sNextMaintainDate { get { return (nextMaintainDate.HasValue) ? nextMaintainDate.Value.StampToDateString() : ""; } }
        //public int? nextMaintainExecuted { get; set; }
        // public decimal? nextMaintainMile2 { get; set; }
        // public long? nextMaintainDate2 { get; set; }
        //[NotMapped]
        // public string? sNextMaintainDate2 { get { return (nextMaintainDate2.HasValue) ? nextMaintainDate2.Value.StampToDateString() : ""; } }
        // public int? nextMaintainExecuted2 { get; set; }
        //public int? driver { get; set; }



    }
}