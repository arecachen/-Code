using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace hsintongERP2022.Models
{
    public class EventLog
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        [Display(Name = "執行動作")]
        public eventType type { get; set; }
        [Display(Name = "作業名稱"), StringLength(250), MaxLength(250, ErrorMessage = "長度不可超過 50個字")]
        public string? actionName { get; set; }
        public long eventTime { get; set; }
        [Display(Name = "帳號"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? loginName { get; set; }
        [Display(Name = "備註"),MaxLength, Column(TypeName ="ntext")]
        public string? remark { get; set; }
        [Display(Name = "來源網址"), StringLength(255), MaxLength(255, ErrorMessage = "長度不可超過 255個字")]
        public string? url { get; set; }
        [NotMapped]
        [Display(Name = "紀錄時間")]
        public string? eventDateTime
        {
            get { return ((long?)eventTime).LongToDateTimeString(); }
            set { eventTime = value.ToTimLong(); }
        }
        public async static Task LogEventAsync(Model_hsintong db, eventType type, string? actionName, string? loginName, string? remark, string? url)
        {
            
            EventLog eventLog = new EventLog()
            {
                type = type,
                actionName = actionName,
                loginName = loginName,
                remark = remark,
                url = url,
                eventDateTime = DateTime.Now.ToString(),
            };
            db.eventLog.Add(eventLog);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception ex) { 
            }
        }
        public static void LogEvent(Model_hsintong db, eventType type, string? actionName, string? loginName, string? remark, string? url)
        {
            EventLog eventLog = new EventLog()
            {
                type = type,
                actionName = actionName,
                loginName = loginName,
                remark = remark,
                url = url,
                eventDateTime = DateTime.Now.ToString(),
            };
            db.eventLog.Add(eventLog);
            db.SaveChanges();
        }
    }
    public enum eventType
    {
        Add = 1,                        //新增
        Delete = 2,                   //刪除
        Modify = 3,                  //修改
        Login = 4,                    //登入
        LogOut = 5,                //登出
        UnAuthorizate = 6,   //讀取未授權頁面
        RegisterUser = 7,        //新增使用者
        ResetPassword = 8,
        Add_fail = 101,                        //新增失敗
        Delete_fail = 102,                   //刪除失敗
        Modify_fail = 103,                  //修改失敗
        Login_fail = 104,                    //登入失敗
        SendShotMessage=105      //傳送簡訊
    }
}