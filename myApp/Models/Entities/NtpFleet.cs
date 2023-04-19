using Altways;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    //車隊管理
    public class NtpFleet
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public int orderCarID { get; set; }
        [Display(Name = "報到時間"), Column(TypeName = "time")]
        public TimeSpan? checkInTime { get; set; }
        //[Range(0, 24), Display(Name = "報到時")]
        //public int checkInHour { get; set; } = 0;
        //[Range(0, 60), Display(Name = "報到分")]
        //public int checkInMin { get; set; } = 0;
        [Display(Name = "報到地點"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? checkInLoacation { get; set; }
        [Display(Name = "行程概要"), StringLength(200), MaxLength(200, ErrorMessage = "長度不可超過 200個字")]
        public string? scheduleSummary { get; set; }
        [Display(Name = "小費")]
        public int? tip { get; set; }
        [Display(Name = "車型"), StringLength(25), MaxLength(25, ErrorMessage = "長度不可超過 25個字")]
        public string? carType { get;set; }
        [Display(Name = "車資")]
        public int? carFee { get; set; }
        [Display(Name = "車齡")]
        public int? carYear { get; set; }
        [Display(Name = "含稅")]
        public bool? withTax { get; set; }
        [Display(Name = "含停車費")]
        public bool? withParkFee { get; set; }
        [Display(Name = "狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? status { get; set; } = "Active";
        [NotMapped]
        public string? sCheckInTime
        {
            get { return  checkInTime.Ensure(x => x.Value.ToString(@"hh\:mm")); }
        }
        public bool deleted { get; set; } = false;
    }
}