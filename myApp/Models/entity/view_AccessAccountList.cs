using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
namespace hsintongERP2022.Models
{
    //public partial class view_AccessAccountList
    //{
      
    //    public Collection<view_AccessAccountList> findAll()
    //    {
    //        Collection<view_AccessAccountList> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from view_AccessAccountList order by loginTID asc", "view_AccessAccountList");
    //            if (ds.Tables["view_AccessAccountList"].Rows.Count > 0)
    //            {
    //                c = new Collection<view_AccessAccountList>();
    //                foreach (DataRow dr in ds.Tables["view_AccessAccountList"].Rows)
    //                {
    //                    view_AccessAccountList am = new view_AccessAccountList();
    //                    am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //                    am.loginID = Convert.ToString(dr["loginID"]);
    //                    am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //                    am.empEmail = Convert.ToString(dr["empEmail"]);
    //                    am.accGroup = Convert.ToString(dr["accGroup"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.employeeTID = Convert.ToInt32(dr["employeeTID"]);
    //                    am.empID = Convert.ToString(dr["empID"]);
    //                    am.empNID = Convert.ToString(dr["empNID"]);
    //                    am.empName = Convert.ToString(dr["empName"]);
    //                    am.empDOB = Convert.ToInt64(dr["empDOB"]);
    //                    am.empMainContact = Convert.ToString(dr["empMainContact"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<view_AccessAccountList> findByKeyword(String sqlCmd)
    //    {
    //        Collection<view_AccessAccountList> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "view_AccessAccountList");
    //            if (ds.Tables["view_AccessAccountList"].Rows.Count > 0)
    //            {
    //                c = new Collection<view_AccessAccountList>();
    //                foreach (DataRow dr in ds.Tables["view_AccessAccountList"].Rows)
    //                {
    //                    view_AccessAccountList am = new view_AccessAccountList();
    //                    am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //                    am.loginID = Convert.ToString(dr["loginID"]);
    //                    am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //                    am.empEmail = Convert.ToString(dr["empEmail"]);
    //                    am.accGroup = Convert.ToString(dr["accGroup"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.employeeTID = Convert.ToInt32(dr["employeeTID"]);
    //                    am.empID = Convert.ToString(dr["empID"]);
    //                    am.empNID = Convert.ToString(dr["empNID"]);
    //                    am.empName = Convert.ToString(dr["empName"]);
    //                    am.empDOB = Convert.ToInt64(dr["empDOB"]);
    //                    am.empMainContact = Convert.ToString(dr["empMainContact"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public view_AccessAccountList findByPrimaryKey(int loginTID)
    //    {
    //        view_AccessAccountList am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM view_AccessAccountList a WHERE a.loginTID = " + loginTID;
    //            DataSet ds = my.select(sqlCmd, "view_AccessAccountList");
    //            if (ds.Tables["view_AccessAccountList"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["view_AccessAccountList"].Rows[0];
    //                am = new view_AccessAccountList();
    //                am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //                am.loginID = Convert.ToString(dr["loginID"]);
    //                am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //                am.empEmail = Convert.ToString(dr["empEmail"]);
    //                am.accGroup = Convert.ToString(dr["accGroup"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.employeeTID = Convert.ToInt32(dr["employeeTID"]);
    //                am.empID = Convert.ToString(dr["empID"]);
    //                am.empNID = Convert.ToString(dr["empNID"]);
    //                am.empName = Convert.ToString(dr["empName"]);
    //                am.empDOB = Convert.ToInt64(dr["empDOB"]);
    //                am.empMainContact = Convert.ToString(dr["empMainContact"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int loginTID, String loginID, String loginPWD, String empEmail, String accGroup, String status, int employeeTID, String empID, String empNID, String empName, long empDOB, String empMainContact)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into view_AccessAccountList(loginTID,loginID,loginPWD,empEmail,accGroup,status,employeeTID,empID,empNID,empName,empDOB,empMainContact) values (" + loginTID + ",'" + loginID + "','" + loginPWD + "','" + empEmail + "','" + accGroup + "','" + status + "'," + employeeTID + ",'" + empID + "','" + empNID + "','" + empName + "'," + empDOB + ",'" + empMainContact + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int loginTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from view_AccessAccountList where loginTID = " + loginTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.delete() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int DeleteByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int loginTID, String loginID, String loginPWD, String empEmail, String accGroup, String status, int employeeTID, String empID, String empNID, String empName, long empDOB, String empMainContact)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update view_AccessAccountList set loginTID =" + loginTID + ",loginID ='" + loginID + "',loginPWD ='" + loginPWD + "',empEmail ='" + empEmail + "',accGroup ='" + accGroup + "',status ='" + status + "',employeeTID =" + employeeTID + ",empID ='" + empID + "',empNID ='" + empNID + "',empName ='" + empName + "',empDOB =" + empDOB + ",empMainContact ='" + empMainContact + "' where loginTID = " + this.loginTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update view_AccessAccountList set loginTID =" + this.loginTID + ",loginID ='" + this.loginID + "',loginPWD ='" + this.loginPWD + "',empEmail ='" + this.empEmail + "',accGroup ='" + this.accGroup + "',status ='" + this.status + "',employeeTID =" + this.employeeTID + ",empID ='" + this.empID + "',empNID ='" + this.empNID + "',empName ='" + this.empName + "',empDOB =" + this.empDOB + ",empMainContact ='" + this.empMainContact + "' where loginTID = " + this.loginTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "view_AccessAccountList");
    //            if (ds.Tables["view_AccessAccountList"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["view_AccessAccountList"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessAccountList.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


