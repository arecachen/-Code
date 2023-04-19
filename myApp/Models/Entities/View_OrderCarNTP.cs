using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public partial class ViewOrderCarNTP
    {
        [NotMapped]
        public string sCreateDatetime
        {
            get { return ((long?)createDatetime).LongToDateString(); }
            set { createDatetime = value.ToDateLong(); }
        }
        [NotMapped]
        public string sStatus
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