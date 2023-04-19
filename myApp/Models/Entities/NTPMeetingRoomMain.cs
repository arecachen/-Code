using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Altways;

namespace hsintongERP2022.Models
{
    [Table("NTPMeetingRoomMain")]
    public class NTPMeetingRoomMain
    {
        [Key, Required]
        public int NTPMeetingRoomMainTID { get; set; }
        [Required]
        public int orderCarID { get; set; }
        public int AccRoomTID { get; set; }
        [ForeignKey("AccRoomTID")]
        public AccomodationRoom? AccomodationRoom { get; set; }
        //第幾晚, 下拉選單 (1~10)
        public int AccDayOrder { get; set; }
        [Display(Name = "全天、半天"), StringLength(10)]
        public string? TimePeriod { get; set; }//全天、半天
        [Display(Name = "會議室名"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? RoomName { get; set; }
        [Display(Name = "備註"), StringLength(255), MaxLength(255, ErrorMessage = "長度不可超過 255個字")]
        public string? Remark { get; set; }
        [Display(Name = "場租提供內容"), StringLength(255), MaxLength(255, ErrorMessage = "長度不可超過 255個字")]
        public string? Support { get; set; }
        [Display(Name = "會議茶點費用")]
        public int? TeaTimeFee { get; set; }
        [Display(Name = "會議茶點net")]
        public int? TeaTimeNet { get; set; }
        [Display(Name = "份數")]
        public int? TeaTimeAmount { get; set; }
        [Display(Name = "茶點內容"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? TeaTimeFood { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan? Period1start { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan? Period1end { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan? Period2start { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan? Period2end { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan? Period3start { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan? Period3end { get; set; }
        [Display(Name = "縣市"), StringLength(10), MaxLength(10, ErrorMessage = "長度不可超過 10個字")]
        public string? City { get; set; }
        [Display(Name = "鄉鎮市區")]
        public int? dist { get; set; }
        [Display(Name = "會議場地"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? MeetingPlace { get; set; }
        [Display(Name = "聯絡人"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? Contract { get; set; }
        [Display(Name = "聯絡人電話"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? ContractTel { get; set; }
        [Display(Name = "會議室類型"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? MeetingRoomType { get; set; }
        [Display(Name = "會議室費用")]
        public int? MeetingRoomFee { get; set; }
        [Display(Name = "會議室net")]
        public int? MeetingRoomNet { get; set; }
        [Display(Name = "狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? meetingRoom
        {
            get { return string.Format("{0} {1}(net{2})", RoomName, MeetingRoomFee, MeetingRoomNet); }

        }
        [NotMapped]
        public string? teaCake
        {
            get { return string.Format("{0}(net{1})×{2}份", TeaTimeFee, TeaTimeNet, TeaTimeAmount); }
        }
        [NotMapped]
        public string? period1
        {
            get
            {
                return string.Format("{0}～{1}", Period1start.Ensure(x => x.Value.ToString(@"hh\:mm"), ""), Period1end.Ensure(x => x.Value.ToString(@"hh\:mm"), ""));
            }
        }
        [NotMapped]
        public string? period2
        {
            get
            {
                return string.Format("{0}～{1}", Period2start.Ensure(x => x.Value.ToString(@"hh\:mm"), ""), Period2end.Ensure(x => x.Value.ToString(@"hh\:mm"), ""));
            }
        }
        [NotMapped]
        public string? period3
        {
            get
            {
                return string.Format("{0}～{1}", Period3start.Ensure(x => x.Value.ToString(@"hh\:mm"), ""), Period3end.Ensure(x => x.Value.ToString(@"hh\:mm"), ""));
            }
        }
    }
}