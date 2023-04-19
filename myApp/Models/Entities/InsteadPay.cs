using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class InsteadPay
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        [Display(Name = "訂單ID")]
        public int orderTID { get; set; }
        [Display(Name = "開立日期")]
        public long craeteDate { get; set; }
        [Display(Name = "抬頭"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string title { get; set; }
        [Display(Name = "品項金額")]
        public int? amount { get; set; }
        [Display(Name = "代轉號碼"), StringLength(25), MaxLength(25, ErrorMessage = "長度不可超過 25個字")]
        public string insteadCode { get; set; }
        [Display(Name = "含保險費")]
        public bool includeInsurence { get; set; }
        [Display(Name = "含車資")]
        public bool includeCarFee  { get; set; }
        [Display(Name = "備註"), StringLength(256), MaxLength(256, ErrorMessage = "長度不可超過 256個字")]
        public string memo  { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string sCraeteDate
        {
            get { return ((long?)craeteDate).LongToDateString(); }
            set { craeteDate = value.ToDateLong(); }
        }
    }
}