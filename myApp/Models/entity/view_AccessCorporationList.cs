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
    //public partial class view_AccessCorporationList
    //{
    
    //    public Collection<view_AccessCorporationList> findAll()
    //    {
    //        Collection<view_AccessCorporationList> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from view_AccessCorporationList order by loginTID asc", "view_AccessCorporationList");
    //            if (ds.Tables["view_AccessCorporationList"].Rows.Count > 0)
    //            {
    //                c = new Collection<view_AccessCorporationList>();
    //                foreach (DataRow dr in ds.Tables["view_AccessCorporationList"].Rows)
    //                {
    //                    view_AccessCorporationList am = new view_AccessCorporationList();
    //                    am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //                    am.corpID = Convert.ToInt32(dr["corpID"]);
    //                    am.loginID = Convert.ToString(dr["loginID"]);
    //                    am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //                    am.empEmail = Convert.ToString(dr["empEmail"]);
    //                    am.accGroup = Convert.ToString(dr["accGroup"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.corpName = Convert.ToString(dr["corpName"]);
    //                    am.corpType = Convert.ToString(dr["corpType"]);
    //                    am.corpPhone = Convert.ToString(dr["corpPhone"]);
    //                    am.corpAddress = Convert.ToString(dr["corpAddress"]);
    //                    am.corpContact = Convert.ToString(dr["corpContact"]);
    //                    am.corpMobile = Convert.ToString(dr["corpMobile"]);
    //                    am.corpStatus = Convert.ToString(dr["corpStatus"]);
    //                    am.corpOrder = Convert.ToInt32(dr["corpOrder"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<view_AccessCorporationList> findByKeyword(String sqlCmd)
    //    {
    //        Collection<view_AccessCorporationList> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "view_AccessCorporationList");
    //            if (ds.Tables["view_AccessCorporationList"].Rows.Count > 0)
    //            {
    //                c = new Collection<view_AccessCorporationList>();
    //                foreach (DataRow dr in ds.Tables["view_AccessCorporationList"].Rows)
    //                {
    //                    view_AccessCorporationList am = new view_AccessCorporationList();
    //                    am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //                    am.corpID = Convert.ToInt32(dr["corpID"]);
    //                    am.loginID = Convert.ToString(dr["loginID"]);
    //                    am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //                    am.empEmail = Convert.ToString(dr["empEmail"]);
    //                    am.accGroup = Convert.ToString(dr["accGroup"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.corpName = Convert.ToString(dr["corpName"]);
    //                    am.corpType = Convert.ToString(dr["corpType"]);
    //                    am.corpPhone = Convert.ToString(dr["corpPhone"]);
    //                    am.corpAddress = Convert.ToString(dr["corpAddress"]);
    //                    am.corpContact = Convert.ToString(dr["corpContact"]);
    //                    am.corpMobile = Convert.ToString(dr["corpMobile"]);
    //                    am.corpStatus = Convert.ToString(dr["corpStatus"]);
    //                    am.corpOrder = Convert.ToInt32(dr["corpOrder"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public view_AccessCorporationList findByPrimaryKey(int loginTID)
    //    {
    //        view_AccessCorporationList am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM view_AccessCorporationList a WHERE a.loginTID = " + loginTID;
    //            DataSet ds = my.select(sqlCmd, "view_AccessCorporationList");
    //            if (ds.Tables["view_AccessCorporationList"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["view_AccessCorporationList"].Rows[0];
    //                am = new view_AccessCorporationList();
    //                am.loginTID = Convert.ToInt32(dr["loginTID"]);
    //                am.corpID = Convert.ToInt32(dr["corpID"]);
    //                am.loginID = Convert.ToString(dr["loginID"]);
    //                am.loginPWD = Convert.ToString(dr["loginPWD"]);
    //                am.empEmail = Convert.ToString(dr["empEmail"]);
    //                am.accGroup = Convert.ToString(dr["accGroup"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.corpName = Convert.ToString(dr["corpName"]);
    //                am.corpType = Convert.ToString(dr["corpType"]);
    //                am.corpPhone = Convert.ToString(dr["corpPhone"]);
    //                am.corpAddress = Convert.ToString(dr["corpAddress"]);
    //                am.corpContact = Convert.ToString(dr["corpContact"]);
    //                am.corpMobile = Convert.ToString(dr["corpMobile"]);
    //                am.corpStatus = Convert.ToString(dr["corpStatus"]);
    //                am.corpOrder = Convert.ToInt32(dr["corpOrder"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int loginTID, int corpID, String loginID, String loginPWD, String empEmail, String accGroup, String status, String corpName, String corpType, String corpPhone, String corpAddress, String corpContact, String corpMobile, String corpStatus, int corpOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into view_AccessCorporationList(loginTID,corpID,loginID,loginPWD,empEmail,accGroup,status,corpName,corpType,corpPhone,corpAddress,corpContact,corpMobile,corpStatus,corpOrder) values (" + loginTID + "," + corpID + ",'" + loginID + "','" + loginPWD + "','" + empEmail + "','" + accGroup + "','" + status + "','" + corpName + "','" + corpType + "','" + corpPhone + "','" + corpAddress + "','" + corpContact + "','" + corpMobile + "','" + corpStatus + "'," + corpOrder + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int loginTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from view_AccessCorporationList where loginTID = " + loginTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int loginTID, int corpID, String loginID, String loginPWD, String empEmail, String accGroup, String status, String corpName, String corpType, String corpPhone, String corpAddress, String corpContact, String corpMobile, String corpStatus, int corpOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update view_AccessCorporationList set loginTID =" + loginTID + ",corpID =" + corpID + ",loginID ='" + loginID + "',loginPWD ='" + loginPWD + "',empEmail ='" + empEmail + "',accGroup ='" + accGroup + "',status ='" + status + "',corpName ='" + corpName + "',corpType ='" + corpType + "',corpPhone ='" + corpPhone + "',corpAddress ='" + corpAddress + "',corpContact ='" + corpContact + "',corpMobile ='" + corpMobile + "',corpStatus ='" + corpStatus + "',corpOrder =" + corpOrder + " where loginTID = " + this.loginTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update view_AccessCorporationList set loginTID =" + this.loginTID + ",corpID =" + this.corpID + ",loginID ='" + this.loginID + "',loginPWD ='" + this.loginPWD + "',empEmail ='" + this.empEmail + "',accGroup ='" + this.accGroup + "',status ='" + this.status + "',corpName ='" + this.corpName + "',corpType ='" + this.corpType + "',corpPhone ='" + this.corpPhone + "',corpAddress ='" + this.corpAddress + "',corpContact ='" + this.corpContact + "',corpMobile ='" + this.corpMobile + "',corpStatus ='" + this.corpStatus + "',corpOrder =" + this.corpOrder + " where loginTID = " + this.loginTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "view_AccessCorporationList");
    //            if (ds.Tables["view_AccessCorporationList"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["view_AccessCorporationList"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewAccessCorporationList.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


