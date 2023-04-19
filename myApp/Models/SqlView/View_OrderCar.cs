using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    [Table("dbo.View_OrderCar")]
    public partial class ViewOrderCar
    {
        public Nullable<long> rentStartDate { get; set; }
        public string? juny { get; set; }
        public string? iStatus { get; set; }
        [Key]
        public int orderTID { get; set; }
        public Nullable<int> inTouchBy { get; set; }
        public Nullable<int> inChargeBy { get; set; }
        public Nullable<int> createBy { get; set; }
        public long createDatetime { get; set; }
        public Nullable<long> lastUpdateDatetime { get; set; }
        public Nullable<int> lastUpdateBy { get; set; }
        public int custID { get; set; }
        public int custContactID { get; set; }
        public string? custContactName { get; set; }
        public string? custContactPhone { get; set; }
        public string? custContactMobile { get; set; }
        public string? custContactFax { get; set; }
        public string? orderSource { get; set; }
        public string? orderType { get; set; }
        public Nullable<int> payByCash { get; set; }
        public Nullable<int> payByTransfer { get; set; }
        public Nullable<int> payByInfo { get; set; }
        public Nullable<int> payTermMonthly { get; set; }
        public Nullable<int> payPaid { get; set; }
        public string? payWith { get; set; }
        public Nullable<int> payAmountShow { get; set; }
        public Nullable<int> payToCustUniCode { get; set; }
        public string? extraDocument { get; set; }
        public string? memoExternal { get; set; }
        public string? memoInternal { get; set; }
        public Nullable<long> regu_contractStart { get; set; }
        public Nullable<long> regu_contractEnd { get; set; }
        public string? status { get; set; }
        public Nullable<int> orgCustContactID { get; set; }
        public string? schematic { get; set; }
        public string? notes { get; set; }
        public Nullable<int> custWithCompID { get; set; }
    }
}