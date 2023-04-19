using Altways;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class NTPTicketMain
    {
        [Key, Required]
        public int NTPTicketMainTID { get; set; }
        [Required]
        public int orderCarID { get; set; }
        [ForeignKey("orderCarID")]
        public virtual OrderCar? OrderCar { get; set; }
        //第幾天, 下拉選單 (1~10)
        public int AccDayOrder { get; set; }
        [Display(Name = "縣市"), StringLength(10), MaxLength(10, ErrorMessage = "長度不可超過 10個字")]
        public string? City { get; set; }
        [Display(Name = "鄉鎮市區")]
        public int? dist { get; set; }
        public int AttractionMainTID { get; set; }
        [ForeignKey("AttractionMainTID")]
        public AttractionMain? Attraction { get; set; }
        [Display(Name = "價格")]
        public int? Price { get; set; }
        [Display(Name = "net")]
        public int? Net { get; set; }
        [Display(Name = "張數")]
        public int? Amount { get; set; }
        [Display(Name = "票價")]
        public int? Total { get; set; }
        [Display(Name = " 預約時間"), Column(TypeName = "time")]
        public TimeSpan? ReserveTime { get; set; }
        //[Range(0, 24)]
        //public int ReserveHour { get; set; }=0;
        //[Range(0, 60)]
        //public int ReserveMin { get; set; } = 0;
        [Display(Name = "聯絡人電話"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? ContractTel { get; set; }
        [Display(Name = "備註"), StringLength(255), MaxLength(255, ErrorMessage = "長度不可超過 255個字")]
        public string? Remark { get; set; }
        [NotMapped]
        public int OrderNo { get; set; }
        [NotMapped]
        public string? AttractionName { get; set; }
        [Display(Name = "狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? cityName { get; set; }
        [NotMapped]
        public string? distName { get; set; }
        [NotMapped]
        public string? sReserveTime { get { return ReserveTime.Ensure(x => x.Value.ToString(@"hh\:mm"), ""); } }
        public virtual ICollection<NTPTickets> nTPTickets { get; set; }
        [NotMapped]
        public int? FullPrice { get; set; }
        [NotMapped]
        public int? FullNet { get; set; }
        [NotMapped]
        public int? FullAmount { get; set; }
        [NotMapped]
        public int? FullTotal { get; set; }
        [NotMapped]
        public int? HalfPrice { get; set; }
        [NotMapped]
        public int? HalfNet { get; set; }
        [NotMapped]
        public int? HalfAmount { get; set; }
        [NotMapped]
        public int? HalfTotal { get; set; }
        [NotMapped]
        public int? ChildPrice { get; set; }
        [NotMapped]
        public int? ChildNet { get; set; }
        [NotMapped]
        public int? ChildAmount { get; set; }
        [NotMapped]
        public int? ChildTotal { get; set; }
        [NotMapped]
        public int? OldPrice { get; set; }
        [NotMapped]
        public int? OldNet { get; set; }
        [NotMapped]
        public int? OldAmount { get; set; }
        [NotMapped]
        public int? OldTotal { get; set; }
        [NotMapped]
        public int? GroupPrice { get; set; }
        [NotMapped]
        public int? GroupNet { get; set; }
        [NotMapped]
        public int? GroupAmount { get; set; }
        [NotMapped]
        public int? GroupTotal { get; set; }
    }
    public class NTPTickets
    {
        [Key, Required]
        public int id { get; set; }
        public int nTPTicketMainTID { get; set; }
        [Display(Name = "票種"), StringLength(10)]//[DictionaryTable].[DictionaryTable]='Ticket_type'
        public string? ticketType { get; set; }
        [Display(Name = "價格")]
        public int? Price { get; set; }
        [Display(Name = "net")]
        public int? Net { get; set; }
        [Display(Name = "張數")]
        public int? Amount { get; set; }
        [Display(Name = "合計")]
        public int? Total { get; set; }
        public bool deleted { get; set; } = false;
        [ForeignKey("nTPTicketMainTID")]
        public NTPTicketMain NTPTicketMain { get; set; }
    }
}