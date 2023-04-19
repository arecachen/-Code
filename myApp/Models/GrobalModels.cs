using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Howgreater.util;
using hsintongERP2022.Utility;

namespace hsintongERP2022.Models
{
    //系統有以下動作需做紀錄到DB供後續查詢:
    //- 登入/登出系統: 不論成功或失敗，記錄使用者帳號、時間、動作(登入/登出)、動作紀錄(成功、失敗)、IP位置
    //- 儲存、修改、刪除動作
    public enum ActionCode
    {
        Logout = 0,
        Login = 1,
        Save = 2,
        Modify = 3,
        Delete = 4,
        Create=5,
        Excel=6,
        Register=7
    }
    public class Activity
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        
        [Display(Name = "使用者帳號"), StringLength(256)]
        public string? UserName { get; set; }        
        
        [Display(Name = "控制名稱"), StringLength(64)]
        public string? ControlName { set; get; }
        
        [Display(Name = "活動名稱"), StringLength(64)]
        public string? ActionName { set; get; }
        
        [Required]     
        [Display(Name = "動作時間")]
        public long TimeStamp { get; set; }        
        [Display(Name = "動作")]
        public ActionCode ActionCode { get; set; }
        [Display(Name = "動作紀錄")]
        public bool Result { get; set; }
        [Display(Name = "IP位置"), StringLength(15)]
        public string? IP { get; set; }
        [NotMapped]
        [Display(Name = "日期")]
        public string? ActionTime
        {
            get { return ((long?)TimeStamp).LongToDateString(); }//     get { return (new DateTime(1970, 1, 1)).AddSeconds(TimeStamp).ToString(); }
            set { TimeStamp = Convert.ToInt32(DateTime.UtcNow.AddHours(8).Subtract(new DateTime(1970, 1, 1)).TotalSeconds); }
        }
        public static async Task AddActivityAsync(string? userName,string? controlerName,string? actionName, ActionCode actionCode, bool result, string? ip, DateTime time, Model_hsintong yd)
        {
            Activity activity = new Activity()
            {
                UserName = userName,
                ControlName=controlerName,
                ActionName=actionName,
                ActionCode = actionCode,
                Result = result,
                IP = ip,
                ActionTime = time.ToString()
            };
            yd.Activity.Add(activity);
            await yd.SaveChangesAsync();
        }
    }
}