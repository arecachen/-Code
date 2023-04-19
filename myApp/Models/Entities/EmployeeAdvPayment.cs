namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeAdvPayment")]
    public partial class EmployeeAdvPayment
    {
        [Key]
        public int employeeAdvPaymentTID { get; set; }

        public int empPaymentRecordID { get; set; }

        public int employeeID { get; set; }

        [Required]
        [StringLength(30)]
        public string? empContact { get; set; }

        public long empCashDatetime { get; set; }

        public int? empCashAmount { get; set; }

        [StringLength(256)]
        public string? empCashMemo { get; set; }

        public int empRepaid { get; set; }

        public long? empRepaidDate { get; set; }

        public int empRepaidCash { get; set; }

        public int cashRecordBy { get; set; }

        public int cashUpdateBy { get; set; }

        public long cashRecordDatetime { get; set; }

        public long cashLastUpadteDatetime { get; set; }

        public bool deleted { get; set; } = false;
        [NotMapped, Display(Name = "借款日期")]
        public string? sCashDate
        {
            get { return ((long?)empCashDatetime).LongToDateString(); }
            set { empCashDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "還款日期")]
        public string? sRepaidDate
        {
            get { return ((long?)empRepaidDate).LongToDateString(); }
            set { empRepaidDate = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "建檔日期 ")]
        public string? sCashRecordDatetime
        {
            get { return ((long?)cashRecordDatetime).LongToDateString(); }
            set { cashRecordDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "最後更新日期 ")]
        public string? sCashLastUpadteDatetime
        {
            get { return ((long?)cashLastUpadteDatetime).LongToDateString(); }
            set { cashLastUpadteDatetime = value.ToTimLong(); }
        }
        [NotMapped, Display(Name = "是否還款 ")]
        public string? sRepaid
        {
            get { return (empRepaid == 0) ? "未歸還" : (empRepaid == 1) ? "全額歸還" : (empRepaid == 2) ? "部份歸還" : (empRepaid == 3) ? "認列損失" : "刪除"; }

        }
        [ForeignKey("employeeID")]
        public virtual EmployeeMain? EmployeeMain { get; set; }
    }
}
