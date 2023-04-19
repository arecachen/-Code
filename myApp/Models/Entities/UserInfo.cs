using Howgreater.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace hsintongERP2022.Models
{
    public partial class UserInfo
    {
        //public  UserInfo(string? loginID,string? loginPWD)
        public UserInfo() { }
        public UserInfo(string? loginID)
        {
            Model_hsintong db=new Model_hsintong();
            string? sqlCmd;
            var acc = db.AccessAccount.Join(db.EmployeeMain, m => m.empID, d => d.employeeTID, (m, d) => new { m, d })
                .FirstOrDefault(x => x.m.loginID == loginID && x.m.status == "Active");
            if (acc == null) return;
           // string? encPWD = new Security().encyptCode(loginPWD);
            this.AccessAccountTID = acc.m.loginTID;
            this.EmployeeTID = acc.d.employeeTID;
            this.EmployeeID = acc.d.empID;
            this.EmployeeNID = acc.d.empNID;
            this.Name = acc.d.empName;
            this.Email = acc.m.empEmail;
            this.Birthday = acc.d.empDOB;
            this.Mobile = acc.d.empMainContact;
            this.LoginID = loginID;
           // this.LoginPWD = encPWD;
            this.accGroup = acc.m.accGroup;
                //ui.menuList = new ShowMenu().MenuString("");

                //系統公用變數
                this.noDriverID =EmployeeMain.getNoDriverTID(db);

                //載入特定頁面的特殊權限
                List<String> accessPageRight = new List<String>();
                accessPageRight.Add("NA"); //initial 

                if (acc.m.accGroup != "ALL")
                {
                    sqlCmd = "Select * from view_AccessControlList WHERE menuGroupID = " + acc.m.accGroup;
                }
                else
                {
                    sqlCmd = "Select * from AccessControl ";
                }
                DataTable dt_accessPageRight = new MssqlTool().findByKeywordDateTable(sqlCmd);
                if (dt_accessPageRight != null && dt_accessPageRight.Rows.Count > 0)
                {
                    foreach (DataRow dr_accessPageRight in dt_accessPageRight.Rows)
                    {
                        accessPageRight.Add(dr_accessPageRight["ctlPageID"].ToString());
                    }

                }
                this.accessPageRight = accessPageRight;
        }
        public int AccessAccountTID { get; set; }  //登入帳號表的主ID
        public int EmployeeTID { get; set; } //員工資料表的主ID
        public string? EmployeeID { get; set; } //員工編號
        public string? EmployeeNID { get; set; } //員工身分證
        public string? Name { get; set; } //員工姓名
        public long Birthday { get; set; } //生日 yyyyMMdd
        public string? Email { get; set; } //Email
        public string? Tel { get; set; } //目前沒用到
        public string? Fax { get; set; } //目前沒用到
        public string? Mobile { get; set; } //員工主要聯絡電話
        public string? LoginID { get; set; } //登入帳號
        public string? LoginPWD { get; set; } //登入密碼
        public string? accGroup { get; set; } // 群組
        public string? menuList { get; set; } //選單列表
        public int noDriverID { get; set; } // 無司機TID
        public List<String> accessPageRight { get; set; } // 對於一些頁面僅能讓部分特定權限群組 (menuGroup) 看到與使用，在載入這些頁面時會先確認登入者是否擁有該權限
    }
}