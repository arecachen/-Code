using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace hsintongERP2022.Models
{
    //系統通知訊息資料表
    //public class SysMessage
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public long CreateDateime { get; set; }
    //    public int Createby { get; set; } //EmployeeMain.ID 0 or null 代表系統自建
    //    public long NotifyDatetime { get; set; } //預設跟CreateDatetime 一樣，此欄位為之後延遲提醒設計之用
    //    [Display(Name = "群組"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
    //    public string? MSGGroup { get; set; } //值在程式建立的時候賦予，不由使用者自訂
    //    [Display(Name = "標題"), StringLength(30), MaxLength(30, ErrorMessage = "長度不可超過 30個字")]
    //    public string? MessageTitle { get; set; }
    //    [Display(Name = "主訊息內容"), Column(TypeName = "text")]
    //    public string? Message { get; set; }
    //    public int AppointTo { get; set; } //EmployeeMain.ID 接收者ID
    //    public int AppointToAck { get; set; } //預設0, 1: 使用者回覆已完成 2: 備用
    //    public long AppointToAckDatetime { get; set; }
    //    [Display(Name = "預留欄位"), Column(TypeName = "text")]
    //    public string? AppointToAckMemo { get; set; }
    //    public bool deleted { get; set; } = false;
    //}
    public class SysNotify
    {
        [Key]
        public int Id { get; set; }
        public long CreateDatetime { get; set; }
        public int? Createby { get; set; } //EmployeeMain.ID 0 or null 代表系統自建
        public long NotifyDatetime { get; set; } //預設跟CreateDatetime 一樣，此欄位為之後延遲提醒設計之用
        [Display(Name = "群組"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? MSGGroup { get; set; } //值在程式建立的時候賦予，不由使用者自訂
        [Display(Name = "標題"), StringLength(30), MaxLength(30, ErrorMessage = "長度不可超過 30個字")]
        public string? MessageTitle { get; set; }
        [Display(Name = "主訊息內容"), Column(TypeName = "text")]
        public string? Message { get; set; }
        public int AppointTo { get; set; } //EmployeeMain.ID 接收者ID
        public int AppointToAck { get; set; } = 0;//預設0, 1: 使用者回覆已完成 2: 備用
        public long AppointToAckDatetime { get; set; }
        [Display(Name = "預留欄位"), Column(TypeName = "text")]
        public string? AppointToAckMemo { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? sNotifyDatetime
        {
            get { return ((long?)NotifyDatetime).LongToDateString(); }
            set { NotifyDatetime = value.ToDateLong(); }
        }
        public static async Task<int> AddNotify(string? mSGGroup, string? messageTitle, string? message, int appointTo)
        {
            Model_hsintong db = new Model_hsintong();
            SysNotify sysNotify = new SysNotify()
            {
                CreateDatetime = DateTime.Today.ToDatLong(),
                Createby = null, // null 代表系統自建
                NotifyDatetime = DateTime.Today.ToDatLong(),
                MSGGroup = mSGGroup,
                MessageTitle = messageTitle,
                Message = message,
                AppointTo = appointTo,
                AppointToAck = 0,
                AppointToAckDatetime = 0,
                AppointToAckMemo = "",
                deleted = false
            };
            db.SysNotify.Add(sysNotify);
            return await db.SaveChangesAsync();
        }
    }
    //系統通知訊息對應表
    public class SysMessageFlow
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "流程代碼"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? FlowCode { get; set; }
        [Display(Name = "流程名稱"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? FlowName { get; set; }
        [Display(Name = "流程群組"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? FlowGroup { get; set; }
        [Display(Name = "流程類別"), StringLength(30), MaxLength(30, ErrorMessage = "長度不可超過 30個字")]
        public string? FlowType { get; set; } //流程屬於系統或是工作事項，使用者無法自訂，也不會出現在管理畫面上
        [Display(Name = "通知群組清單"), Column(TypeName = "text")]
        public string? NotifyGroup { get; set; } //通知群組清單，或該欄位採用多對多的中繼資料表也可以
        [Display(Name = "通知使用者清單"), Column(TypeName = "text")]
        public string? NotifyMember { get; set; } //通知使用者清單，或該欄位採用多對多的中繼資料表也可以
        public long LastModifyDatetime { get; set; }
        public int LastModifyBy { get; set; }
        public bool deleted { get; set; } = false;



    }
    //工作事項通報對象
    public class NotifyStaff
    {
        [Key]
        public int Id { get; set; }
        public int empId { get; set; }
        public int flowId { get; set; }
        public bool deleted { get; set; } = false;
        [ForeignKey("flowId")]
        public virtual SysMessageFlow? SysMessageFlow { get; set; }
        [ForeignKey("empId")]
        public virtual EmployeeMain? EmployeeMain { get; set; }
    }


}