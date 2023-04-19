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
    //public partial class view_MenuList
    //{
        //public int menuMainTID { get; set; } //不可空值, 
        //public String mainName { get; set; } //不可空值, 
        //public String mainType { get; set; } //不可空值, 
        //public String mainLink { get; set; } //不可空值, 
        //public int mainNewWindow { get; set; } //不可空值, 
        //public String mainProp { get; set; } //可空值, 
        //public int mainOrder { get; set; } //不可空值, 
        //public String mainStatus { get; set; } //不可空值, 
        //public int menuSubTID { get; set; } //可空值, 
        //public String subName { get; set; } //可空值, 
        //public String subType { get; set; } //可空值, 
        //public String subLink { get; set; } //可空值, 
        //public int subNewWindow { get; set; } //可空值, 
        //public String subProp { get; set; } //可空值, 
        //public int subOrder { get; set; } //可空值, 
        //public String subStatus { get; set; } //可空值, 
        //public int upperSub { get; set; } //可空值, 
        //public Collection<view_MenuList> findAll()
        //{
        //    Collection<view_MenuList> c = null;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        DataSet ds = my.select("select * from view_MenuList order by menuMainTID asc", "view_MenuList");
        //        if (ds.Tables["view_MenuList"].Rows.Count > 0)
        //        {
        //            c = new Collection<view_MenuList>();
        //            foreach (DataRow dr in ds.Tables["view_MenuList"].Rows)
        //            {
        //                view_MenuList am = new view_MenuList();
        //                am.menuMainTID = Convert.ToInt32(dr["menuMainTID"]);
        //                am.mainName = Convert.ToString(dr["mainName"]);
        //                am.mainType = Convert.ToString(dr["mainType"]);
        //                am.mainLink = Convert.ToString(dr["mainLink"]);
        //                am.mainNewWindow = Convert.ToInt32(dr["mainNewWindow"]);
        //                am.mainProp = Convert.ToString(dr["mainProp"]);
        //                am.mainOrder = Convert.ToInt32(dr["mainOrder"]);
        //                am.mainStatus = Convert.ToString(dr["mainStatus"]);
        //                am.menuSubTID = dr["menuSubTID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["menuSubTID"]);
        //                am.subName = Convert.ToString(dr["subName"]);
        //                am.subType = Convert.ToString(dr["subType"]);
        //                am.subLink = Convert.ToString(dr["subLink"]);
        //                am.subNewWindow = dr["subNewWindow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subNewWindow"]);
        //                am.subProp = Convert.ToString(dr["subProp"]);
        //                am.subOrder = dr["subOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subOrder"]);
        //                am.subStatus = Convert.ToString(dr["subStatus"]);
        //                am.upperSub = dr["upperSub"] == DBNull.Value ? -999 : Convert.ToInt32(dr["upperSub"]);
        //                c.Add(am);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.findAll() : " + e.ToString());
        //    }
        //    return c;
        //}


        //public Collection<view_MenuList> findByKeyword(String sqlCmd)
        //{
        //    Collection<view_MenuList> c = null;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        DataSet ds = my.select(sqlCmd, "view_MenuList");
        //        if (ds.Tables["view_MenuList"].Rows.Count > 0)
        //        {
        //            c = new Collection<view_MenuList>();
        //            foreach (DataRow dr in ds.Tables["view_MenuList"].Rows)
        //            {
        //                view_MenuList am = new view_MenuList();
        //                am.menuMainTID = Convert.ToInt32(dr["menuMainTID"]);
        //                am.mainName = Convert.ToString(dr["mainName"]);
        //                am.mainType = Convert.ToString(dr["mainType"]);
        //                am.mainLink = Convert.ToString(dr["mainLink"]);
        //                am.mainNewWindow = Convert.ToInt32(dr["mainNewWindow"]);
        //                am.mainProp = Convert.ToString(dr["mainProp"]);
        //                am.mainOrder = Convert.ToInt32(dr["mainOrder"]);
        //                am.mainStatus = Convert.ToString(dr["mainStatus"]);
        //                am.menuSubTID = dr["menuSubTID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["menuSubTID"]);
        //                am.subName = Convert.ToString(dr["subName"]);
        //                am.subType = Convert.ToString(dr["subType"]);
        //                am.subLink = Convert.ToString(dr["subLink"]);
        //                am.subNewWindow = dr["subNewWindow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subNewWindow"]);
        //                am.subProp = Convert.ToString(dr["subProp"]);
        //                am.subOrder = dr["subOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subOrder"]);
        //                am.subStatus = Convert.ToString(dr["subStatus"]);
        //                am.upperSub = dr["upperSub"] == DBNull.Value ? -999 : Convert.ToInt32(dr["upperSub"]);
        //                c.Add(am);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.findByKeyword() : " + e.ToString());
        //    }
        //    return c;
        //}


        //public view_MenuList findByPrimaryKey(int menuMainTID)
        //{
        //    view_MenuList am = null;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "select * FROM view_MenuList a WHERE a.menuMainTID = " + menuMainTID;
        //        DataSet ds = my.select(sqlCmd, "view_MenuList");
        //        if (ds.Tables["view_MenuList"].Rows.Count == 1)
        //        {
        //            DataRow dr = ds.Tables["view_MenuList"].Rows[0];
        //            am = new view_MenuList();
        //            am.menuMainTID = Convert.ToInt32(dr["menuMainTID"]);
        //            am.mainName = Convert.ToString(dr["mainName"]);
        //            am.mainType = Convert.ToString(dr["mainType"]);
        //            am.mainLink = Convert.ToString(dr["mainLink"]);
        //            am.mainNewWindow = Convert.ToInt32(dr["mainNewWindow"]);
        //            am.mainProp = Convert.ToString(dr["mainProp"]);
        //            am.mainOrder = Convert.ToInt32(dr["mainOrder"]);
        //            am.mainStatus = Convert.ToString(dr["mainStatus"]);
        //            am.menuSubTID = dr["menuSubTID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["menuSubTID"]);
        //            am.subName = Convert.ToString(dr["subName"]);
        //            am.subType = Convert.ToString(dr["subType"]);
        //            am.subLink = Convert.ToString(dr["subLink"]);
        //            am.subNewWindow = dr["subNewWindow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subNewWindow"]);
        //            am.subProp = Convert.ToString(dr["subProp"]);
        //            am.subOrder = dr["subOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subOrder"]);
        //            am.subStatus = Convert.ToString(dr["subStatus"]);
        //            am.upperSub = dr["upperSub"] == DBNull.Value ? -999 : Convert.ToInt32(dr["upperSub"]);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.findByPrimaryKey() : " + e.ToString());
        //    }
        //    return am;
        //}


        //public int create(int menuMainTID, String mainName, String mainType, String mainLink, int mainNewWindow, String mainProp, int mainOrder, String mainStatus, int menuSubTID, String subName, String subType, String subLink, int subNewWindow, String subProp, int subOrder, String subStatus, int upperSub)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "insert into view_MenuList(menuMainTID,mainName,mainType,mainLink,mainNewWindow,mainProp,mainOrder,mainStatus,menuSubTID,subName,subType,subLink,subNewWindow,subProp,subOrder,subStatus,upperSub) values (" + menuMainTID + ",'" + mainName + "','" + mainType + "','" + mainLink + "'," + mainNewWindow + ",'" + mainProp + "'," + mainOrder + ",'" + mainStatus + "'," + menuSubTID + ",'" + subName + "','" + subType + "','" + subLink + "'," + subNewWindow + ",'" + subProp + "'," + subOrder + ",'" + subStatus + "'," + upperSub + ")";
        //        count = my.insert(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.create() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int Delete(int menuMainTID)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "delete from view_MenuList where menuMainTID = " + menuMainTID;
        //        count = my.delete(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.delete() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int DeleteByKeyword(String sqlCmd)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        count = my.delete(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.DeleteByKeyword() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int update(int menuMainTID, String mainName, String mainType, String mainLink, int mainNewWindow, String mainProp, int mainOrder, String mainStatus, int menuSubTID, String subName, String subType, String subLink, int subNewWindow, String subProp, int subOrder, String subStatus, int upperSub)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "update view_MenuList set menuMainTID =" + menuMainTID + ",mainName ='" + mainName + "',mainType ='" + mainType + "',mainLink ='" + mainLink + "',mainNewWindow =" + mainNewWindow + ",mainProp ='" + mainProp + "',mainOrder =" + mainOrder + ",mainStatus ='" + mainStatus + "',menuSubTID =" + menuSubTID + ",subName ='" + subName + "',subType ='" + subType + "',subLink ='" + subLink + "',subNewWindow =" + subNewWindow + ",subProp ='" + subProp + "',subOrder =" + subOrder + ",subStatus ='" + subStatus + "',upperSub =" + upperSub + " where menuMainTID = " + this.menuMainTID;
        //        count = my.update(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.create() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int update()
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "update view_MenuList set menuMainTID =" + this.menuMainTID + ",mainName ='" + this.mainName + "',mainType ='" + this.mainType + "',mainLink ='" + this.mainLink + "',mainNewWindow =" + this.mainNewWindow + ",mainProp ='" + this.mainProp + "',mainOrder =" + this.mainOrder + ",mainStatus ='" + this.mainStatus + "',menuSubTID =" + this.menuSubTID + ",subName ='" + this.subName + "',subType ='" + this.subType + "',subLink ='" + this.subLink + "',subNewWindow =" + this.subNewWindow + ",subProp ='" + this.subProp + "',subOrder =" + this.subOrder + ",subStatus ='" + this.subStatus + "',upperSub =" + this.upperSub + " where menuMainTID = " + this.menuMainTID;
        //        count = my.update(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.update() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int TotalCountByKeyword(String sqlCmd)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        DataSet ds = my.select(sqlCmd, "view_MenuList");
        //        if (ds.Tables["view_MenuList"].Rows.Count > 0)
        //        {
        //            DataRow dr = ds.Tables["view_MenuList"].Rows[0];
        //            count = Convert.ToInt32(dr[0]);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        count = 0;
        //        new log().wiriteSystemLog("hsintongERP2022.Models.ViewMenuList.TotalCountByKeyword() : " + e.ToString());
        //    }
        //    return count;
        //}


    //}
}


