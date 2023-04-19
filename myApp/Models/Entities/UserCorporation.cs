using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace hsintongERP2022.Models
{
    public partial class UserCorporation
    {
        public int AccessAccountTID { get; set; }  //登入帳號表的主ID
        public int CorporationTID { get; set; } //協力商編號
        public string? corpName { get; set; } //不可空值,特約/協力名稱 
        public string? corpType { get; set; } //不可空值,特約/協力商類別 [DictionaryTable].dicCategory='Corporation_corpType' 
        public string? corpPhone { get; set; } //可空值,特約/協力商電話 
        public string? corpAddress { get; set; } //可空值,特約/協力商地址 
        public string? corpContact { get; set; } //可空值,特約/協力商主要聯絡人 
        public string? corpMobile { get; set; } //可空值,特約/協力商主要連絡人手機 
        public string? corpStatus { get; set; } //不可空值,特約/協力商狀態 [StatusTable].statusGroup = 'Corporation' 
        public string? LoginID { get; set; } //登入帳號
        public string? LoginPWD { get; set; } //登入密碼
        public String? accGroup { get; set; } // 群組
        public StringBuilder? menuList { get; set; } //選單列表
    }
}