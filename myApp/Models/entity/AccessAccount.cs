using Howgreater.util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace hsintongERP2022.Models
{

    //public partial class AccessAccount
    //{

    //    #region sql
    //    //Model_hsintong db = new Model_hsintong();
    //    //public int loginTID { get; set; } //不可空值, 
    //    //public int empID { get; set; } //不可空值,FK_EmployeeMain_employeeTID 
    //    //public String loginID { get; set; } //不可空值,登入ID 
    //    //public String loginPWD { get; set; } //不可空值,登入密碼 
    //    //public String empEmail { get; set; } //可空值,登入者email 
    //    //public String accGroup { get; set; } //可空值,歸屬群組 
    //    //public String status { get; set; } //不可空值,狀態 參考[StatusTable].statusGroup='AccessAccount' 
    //    //public Collection<AccessAccount> findAll()
    //    //{
    //    //    return new Collection<AccessAccount>(db.AccessAccount.OrderBy(a => a.loginTID).ToList<AccessAccount>());
    //    //}
    //    //public Collection<AccessAccount> _findAll()
    //    //{
    //    //    AccessAccount accessAccount = new AccessAccount();
    //    //    Collection<AccessAccount> c = null;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        DataSet ds = my.select("select * from AccessAccount order by loginTID asc", "AccessAccount");
    //    //        if (ds.Tables["AccessAccount"].Rows.Count > 0)
    //    //        {
    //    //            c = new Collection<AccessAccount>();
    //    //            foreach (DataRow dr in ds.Tables["AccessAccount"].Rows)
    //    //            {
    //    //                AccessAccount am = new AccessAccount();
    //    //                am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //    //                am.empID = Convert.ToInt32(dr["empID"]);
    //    //                am.loginID = Convert.ToString(dr["loginID"]);
    //    //                am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //    //                am.empEmail = Convert.ToString(dr["empEmail"]);
    //    //                am.accGroup = Convert.ToString(dr["accGroup"]);
    //    //                am.status = Convert.ToString(dr["status"]);
    //    //                c.Add(am);
    //    //            }
    //    //        }
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.findAll() : " + e.ToString());
    //    //    }
    //    //    return c;
    //    //}

      
    //    //public Collection<AccessAccount> _findByKeyword(String sqlCmd)
    //    //{
    //    //    Collection<AccessAccount> c = null;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        DataSet ds = my.select(sqlCmd, "AccessAccount");
    //    //        if (ds.Tables["AccessAccount"].Rows.Count > 0)
    //    //        {
    //    //            c = new Collection<AccessAccount>();
    //    //            foreach (DataRow dr in ds.Tables["AccessAccount"].Rows)
    //    //            {
    //    //                AccessAccount am = new AccessAccount();
    //    //                am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //    //                am.empID = Convert.ToInt32(dr["empID"]);
    //    //                am.loginID = Convert.ToString(dr["loginID"]);
    //    //                am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //    //                am.empEmail = Convert.ToString(dr["empEmail"]);
    //    //                am.accGroup = Convert.ToString(dr["accGroup"]);
    //    //                am.status = Convert.ToString(dr["status"]);
    //    //                c.Add(am);
    //    //            }
    //    //        }
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.findByKeyword() : " + e.ToString());
    //    //    }
    //    //    return c;
    //    //}


       
    //    //public AccessAccount _findByPrimaryKey(int loginTID)
    //    //{
    //    //    AccessAccount am = null;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        String sqlCmd = "select * FROM AccessAccount a WHERE a.loginTID = " + loginTID;
    //    //        DataSet ds = my.select(sqlCmd, "AccessAccount");
    //    //        if (ds.Tables["AccessAccount"].Rows.Count == 1)
    //    //        {
    //    //            DataRow dr = ds.Tables["AccessAccount"].Rows[0];
    //    //            am = new AccessAccount();
    //    //            am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //    //            am.empID = Convert.ToInt32(dr["empID"]);
    //    //            am.loginID = Convert.ToString(dr["loginID"]);
    //    //            am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //    //            am.empEmail = Convert.ToString(dr["empEmail"]);
    //    //            am.accGroup = Convert.ToString(dr["accGroup"]);
    //    //            am.status = Convert.ToString(dr["status"]);
    //    //        }
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.findByPrimaryKey() : " + e.ToString());
    //    //    }
    //    //    return am;
    //    //}


    //    //public int _create(int empID, String loginID, String loginPWD, String empEmail, String accGroup, String status)
    //    //{
    //    //    int count = 0;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        String sqlCmd = "insert into AccessAccount(empID,loginID,loginPWD,empEmail,accGroup,status) values (" + empID + ",'" + loginID + "','" + loginPWD + "','" + empEmail + "','" + accGroup + "','" + status + "')";
    //    //        count = my.insert(sqlCmd);
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.create() : " + e.ToString());
    //    //    }
    //    //    return count;
    //    //}

      
    //    //public int _Delete(int loginTID)
    //    //{
    //    //    int count = 0;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        String sqlCmd = "delete from AccessAccount where loginTID = " + loginTID;
    //    //        count = my.delete(sqlCmd);
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.delete() : " + e.ToString());
    //    //    }
    //    //    return count;
    //    //}

    //    //public int DeleteByKeyword(String sqlCmd)
    //    //{
    //    //  return db.Database.ExecuteSqlCommand(sqlCmd);
    //    //}
    //    //public int _DeleteByKeyword(String sqlCmd)
    //    //{
    //    //    int count = 0;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        count = my.delete(sqlCmd);
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.DeleteByKeyword() : " + e.ToString());
    //    //    }
    //    //    return count;
    //    //}

    //    //public int update(int empID, String loginID, String loginPWD, String empEmail, String accGroup, String status)
    //    //{
    //    //    var aa = db.AccessAccount.Find(this.loginTID);
    //    //    if (aa == null) return 0;
    //    //    aa.empID = empID;
    //    //    aa.loginID = loginID;
    //    //    aa.loginPWD = loginPWD;
    //    //    aa.empEmail = empEmail;
    //    //    aa.accGroup = accGroup;
    //    //    aa.status = status;
    //    //    return db.SaveChanges();
    //    //}
    //    //public int _update(int empID, String loginID, String loginPWD, String empEmail, String accGroup, String status)
    //    //{
    //    //    int count = 0;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        String sqlCmd = "update AccessAccount set empID =" + empID + ",loginID ='" + loginID + "',loginPWD ='" + loginPWD + "',empEmail ='" + empEmail + "',accGroup ='" + accGroup + "',status ='" + status + "' where loginTID = " + this.loginTID;
    //    //        count = my.update(sqlCmd);
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.create() : " + e.ToString());
    //    //    }
    //    //    return count;
    //    //}

    
    //    //public int _update()
    //    //{
    //    //    int count = 0;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        String sqlCmd = "update AccessAccount set empID =" + this.empID + ",loginID ='" + this.loginID + "',loginPWD ='" + this.loginPWD + "',empEmail ='" + this.empEmail + "',accGroup ='" + this.accGroup + "',status ='" + this.status + "' where loginTID = " + this.loginTID;
    //    //        count = my.update(sqlCmd);
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.update() : " + e.ToString());
    //    //    }
    //    //    return count;
    //    //}

    //    //public int TotalCountByKeyword(String sqlCmd)
    //    //{
    //    //    int count = 0;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        DataSet ds = my.select(sqlCmd, "AccessAccount");
    //    //        if (ds.Tables["AccessAccount"].Rows.Count > 0)
    //    //        {
    //    //            DataRow dr = ds.Tables["AccessAccount"].Rows[0];
    //    //            count = Convert.ToInt32(dr[0]);
    //    //        }
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        count = 0;
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.AccessAccount.TotalCountByKeyword() : " + e.ToString());
    //    //    }
    //    //    return count;
    //    //}

    //    #endregion sql
    //}

}


