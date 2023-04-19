using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    //領隊管理
    public class NtpTourGuide
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public int orderCarID { get; set; }
        public int TourGuideMainTID { get; set; }
        [ForeignKey("TourGuideMainTID"), Display(Name = "領隊")]
        public TourGuideMain? TourGuideMain { get; set; }
        [Display(Name = "職責"), StringLength(10), MaxLength(10, ErrorMessage = "長度不可超過 10個字")]
        public string? duty { get; set; }
        [Display(Name = "備註"), StringLength(200), MaxLength(200, ErrorMessage = "長度不可超過 200個字")]
        public string? remark { get; set; }
        [Display(Name = "小費")]
        public int? tip { get; set; } = 0;
        [Display(Name = "電話"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? phone { get; set; }
        [Display(Name = "主領隊")]
        public bool mastGuide  { get; set; }=false;
        [Display(Name = "狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? status { get; set; } = "Active";
        [NotMapped]
        public string? TGContactName { get; set; }
        public bool deleted { get; set; } = false;
    }
    //領隊收支款管理
    public partial class NtpTGIncomeExpend
    {
        [Key]
        public int id { get; set; }       
        [Required]
        public int NtpTourGuideID { get; set; }
        [Required]
        public int orderCarNTPTID { get; set; }
        public long incomeExpendDate { get; set; }
        [Display(Name = "款項品名"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 20個字")]
        public string? itemName { get; set; }
        [Display(Name = "明細"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string? itemDesc { get; set; }
        [Display(Name = "領隊取得金額")]
        public int? income { get; set; }
        [Display(Name = "領隊支出金額")]
        public int? expenditure { get; set; }
        [Display(Name = "代收轉付")]
        public bool? collectionTransfer { get; set; }
        [Display(Name = "連動稽核")]
        public bool? linkAudit { get; set; }
        [Display(Name = "連結T字帳")]
        public bool? connectTSheet { get; set; }
        [Display(Name = "收款日")]
        [NotMapped]
        public string? sIncomeExpendDate
        {
            get { return ((long?)incomeExpendDate).LongToDateString(); }
            set { incomeExpendDate = value.ToDateLong(); }
        }    
        [ForeignKey("NtpTourGuideID")]
        public NtpTourGuide? NtpTourGuide { get; set; }
        public bool deleted { get; set; } = false;
    }
    public class PaymentItemName
    {
        [Key,Required]
        public int id { get; set; }
        [Display(Name = "款項品名"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string? itemName  { get; set; }        
        [Display(Name = "借貸:+收入/-支出"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string? Credit { get; set; }
        [Display(Name = "連結請款單")]
        public bool connectInvoice  { get; set; }
        [Display(Name = "連結T字帳")]
        public bool connectTSheet { get; set; }
        public bool deleted { get; set; } = false;
    }


}