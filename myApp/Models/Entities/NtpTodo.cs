using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    //國旅單工作管理
    public class NtpTodo
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        [Display(Name = "經辦人ID")]
        public int inChargeBy { get; set; }
      
        [Display(Name = "接洽人ID")]
        public int inTouchBy { get; set; }
        [Display(Name = "出車起始日期")]
        public string? startDate { get; set; }
        [Display(Name = "出車終止日期")]
        public string? endDate { get; set; }
        [Display(Name = "建檔日期")]
        public string? createDate { get; set; }
        [Display(Name = "住宿資訊尚未建立")]
        public bool checkStayInfoCreated { get; set; }
        [Display(Name = "訂金尚未輸入")]
        public bool checkDpositInputed { get; set; }
        [Display(Name = "報到地點")]
        public bool checkCheckInLocation { get; set; }
        [Display(Name = "領隊未安排/重複")]
        public bool checkLeaderArrange { get; set; }
        [Display(Name = "保險")]
        public bool checkInsu { get; set; }
        [Display(Name = "旅平險")]
        public bool checkTravInsu { get; set; }
        [Display(Name = "旅責險")]
        public bool checkTravLiabInsu { get; set; }
        [Display(Name = "合約書")]
        public bool checkContract { get; set; }
        [Display(Name = "抽籤")]
        public bool checkDrawLots { get; set; }
        [Display(Name = "吊牌")]
        public bool checkHangTag { get; set; }
        [Display(Name = "旅遊手冊")]
        public bool checkTravBroc { get; set; }
        [Display(Name = "說明會資料")]
        public bool checkBrieSessInfo { get; set; }
        [Display(Name = "醫藥箱")]
        public bool checkMediChes { get; set; }
        [Display(Name = "紅布條")]
        public bool checkRedCloth { get; set; }
        [Display(Name = "貼條")]
        public bool checkLabel { get; set; }
        [Display(Name = "宵夜")]
        public bool checkNightSnack { get; set; }
        [Display(Name = "贈品")]
        public bool checkGift { get; set; }
        [Display(Name = "其他")]
        public bool checkOther { get; set; }
        [Display(Name = "礦泉水")]
        public bool checkMineralWater { get; set; }
        
    }
}