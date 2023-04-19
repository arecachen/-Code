using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    [Table("dbo.View_CustomerContact")]
    public class ViewCustomerContact
    {
        [Key]
        public int customerContactTID { get; set; }
        public int custID { get; set; }
        public string? custName { get; set; }
        public string? custPhone { get; set; }
        public string? custMobile { get; set; }
        public string? custEmail { get; set; }
        public string? custFax { get; set; }
        public string? memo { get; set; }
        public string? Caution { get; set; }
        public Nullable<int> customerSourceTID { get; set; }
        public bool potentialCust { get; set; }
        public long createDate { get; set; }
        public long lastUpdateDate { get; set; }
        public int createdBy { get; set; }
        public int custCategory { get; set; }
        public string? salutations { get; set; }
        public string? title { get; set; }
        public string? organization { get; set; }
        public string? companyName { get; set; }
    }
}