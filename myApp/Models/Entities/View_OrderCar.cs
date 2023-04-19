using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public partial class ViewOrderCar
    {
        [NotMapped, Display(Name = "總車趟數")]
        public int carTimes { get; set; }
        [NotMapped, Display(Name = "總車資")]
        public int carFee { get; set; }
        [NotMapped, Display(Name = "行程內容")]
        public string? jounery { get; set; }
        [NotMapped, Display(Name = "住宿飯店")]
        public string? accomodation { get; set; }
        [NotMapped, Display(Name = "餐廳")]
        public string? restruant { get; set; }
        [NotMapped, Display(Name = "景點")]
        public string? attractions { get; set; }
        [NotMapped]
        public string? createDate
        {
            get { return createDatetime.StampToDateString(); }
            set { createDatetime = value.ToDateLong(); }
        }
        [NotMapped]
        public string? sLastUpdateDatetime
        {
            get { return lastUpdateDatetime.LongToDateString(); }
            set { lastUpdateDatetime = value.ToDateLong(); }
        }
        [NotMapped]
        public string? compName { get; set; }
        [NotMapped]
        public string? sStatus
        {
            get
            {
                return (status == "NTPQuote") ? "尚未建案"
                    : (status == "Create") ? "已建案"
                    : (status == "Prepare") ? "準備中"
                    : (status == "Working") ? "執行中"
                    : (status == "Complete") ? "服務結束"
                    : (status == "Cancel") ? "取消"
                    : (status == "Dispute") ? "爭議處理中"
                    : "契合中";
            }
        }
    }
}