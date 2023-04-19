using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    [Table("dbo.View_OrderCarNTP")]
    public partial class ViewOrderCarNTP
    {
        public string? statusText { get; set; }
        public string? OrderNo { get; set; }
        public Nullable<long> createDatetime { get; set; }
        public string? custContactName { get; set; }
        [Key]
        public int orderCarNTPTID { get; set; }
        public string? groupName { get; set; }
        public long groupDate { get; set; }
        public Nullable<int> orderCarID { get; set; }
        public string? companyName { get; set; }
        public string? custName { get; set; }
        public string? custContactPhone { get; set; }
        public string? custContactMobile { get; set; }
        public Nullable<int> inTouchBy { get; set; }
        public Nullable<int> inChargeBy { get; set; }
        public string? status { get; set; }
        public string? jounery { get; set; }
    }
}