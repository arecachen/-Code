using Altways;
using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
//帳務管理
namespace hsintongERP2022.Models
{
    //請款單紀錄
    public class Invoice
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        public int orderCarNTPTID { get; set; }
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
        [Display(Name = "請款日")]
        public long invoiceDate { get; set; }
        [Display(Name = "請款單編號"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? sheetNo { get; set; }
        [Display(Name = "請款總額(總計金額)")]
        public int? amount { get; set; }
        [Display(Name = "應收總額(尾款)")]
        public int? receivable { get; set; }
        [Display(Name = "招待")]
        public int? entertain { get; set; }
        [Display(Name = "經手人(招待)"), StringLength(10), MaxLength(10, ErrorMessage = "長度不可超過 10個字")]
        public string? handler { get; set; }
        [Display(Name = "備註(招待)"), StringLength(256), MaxLength(256, ErrorMessage = "長度不可超過 256個字")]
        public string? remark { get; set; }
        [NotMapped]
        public string? sInvoiceDate
        {
            get { return ((long?)invoiceDate).LongToDateString(); }
            set { invoiceDate = value.ToDateLong(); }
        }

        [NotMapped, Display(Name = "已付總額")]
        public int? paied { get; set; }
        [NotMapped, Display(Name = "車上收款")]
        public int? prePaid { get; set; }
    }
    //請款單紀錄明細
    public class InvoiceDetail
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        public int invoiceId { get; set; }
        [Display(Name = "項目"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? ItemName { get; set; }
        [Display(Name = "項目內容"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string? ItemContext { get; set; }
        [Display(Name = "數量")]
        public int? amount { get; set; } = 0;
        [Display(Name = "規格"), StringLength(10), MaxLength(10, ErrorMessage = "長度不可超過 10個字")]
        public string? unit { get; set; }
        [Display(Name = "單價")]
        public int? unitPrice { get; set; } = 0;
        [ForeignKey("invoiceId")]
        public Invoice? Invoice { get; set; }
        //public long invoiceDate { get; set; }
        [Display(Name = "總額")]
        [NotMapped]
        public int total { get { return amount.Ensure(x => x.Value, 0) * unitPrice.Ensure(x => x.Value, 0); } }
    }
    //收款明細(新通)
    public class Receipt
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        public int orderCarNTPTID { get; set; }
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
        [Display(Name = "收款日")]
        public long receiptDate { get; set; }
        [Display(Name = "收款品項"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? receiptItem { get; set; }
        [Display(Name = "金額")]
        public int? amount { get; set; } = 0;
        [Display(Name = "付款方式"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? payWay { get; set; }
        [Display(Name = "代收轉付")]
        public bool? collectionTransfer { get; set; }=false;
        [Display(Name = "連動稽核")]
        public bool? linkAudit { get; set; } = false;
        [Display(Name = "已開單")]
        public bool? isBilled { get; set; }
        [Display(Name = "品項備註"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string? memo { get; set; }
        [Display(Name = "抬頭"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string? custTitle { get; set; }

        [NotMapped]
        public string? sReceiptDate
        {
            get { return ((long?)receiptDate).LongToDateString(); }
            set { receiptDate = value.ToDateLong(); }
        }
    }
    //支出明細(新通)
    public class ExpBill
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        public int orderCarNTPTID { get; set; }
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
        [Display(Name = "付款日")]
        public long expBillDate { get; set; }
        [Display(Name = "支出品項"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? payItem { get; set; }
        [Display(Name = "金額")]
        public int? amount { get; set; }
        [Display(Name = "付款方式"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? payWay { get; set; }
        [Display(Name = "備註"), StringLength(256), MaxLength(256, ErrorMessage = "長度不可超過 256個字")]
        public string? memo { get; set; }
        [NotMapped]
        public string? sExpBillDate
        {
            get { return ((long?)expBillDate).LongToDateString(); }
            set { expBillDate = value.ToDateLong(); }
        }
    }
}