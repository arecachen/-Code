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
    //public partial class MenuSub
    //{
        
    //    public Collection<MenuSub> findAll()
    //    {
    //        Collection<MenuSub> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from MenuSub order by menuSubTID asc", "MenuSub");
    //            if (ds.Tables["MenuSub"].Rows.Count > 0)
    //            {
    //                c = new Collection<MenuSub>();
    //                foreach (DataRow dr in ds.Tables["MenuSub"].Rows)
    //                {
    //                    MenuSub am = new MenuSub();
    //                    am.menuSubTID = Convert.ToInt32(dr["menuSubTID"]);
    //                    am.menuMainID = Convert.ToInt32(dr["menuMainID"]);
    //                    am.subName = Convert.ToString(dr["subName"]);
    //                    am.subType = Convert.ToString(dr["subType"]);
    //                    am.subLink = Convert.ToString(dr["subLink"]);
    //                    am.subNewWindow = Convert.ToInt32(dr["subNewWindow"]);
    //                    am.subProp = Convert.ToString(dr["subProp"]);
    //                    am.subOrder = dr["subOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subOrder"]);
    //                    am.subStatus = Convert.ToString(dr["subStatus"]);
    //                    am.upperSub = Convert.ToInt32(dr["upperSub"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<MenuSub> findByKeyword(String sqlCmd)
    //    {
    //        Collection<MenuSub> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "MenuSub");
    //            if (ds.Tables["MenuSub"].Rows.Count > 0)
    //            {
    //                c = new Collection<MenuSub>();
    //                foreach (DataRow dr in ds.Tables["MenuSub"].Rows)
    //                {
    //                    MenuSub am = new MenuSub();
    //                    am.menuSubTID = Convert.ToInt32(dr["menuSubTID"]);
    //                    am.menuMainID = Convert.ToInt32(dr["menuMainID"]);
    //                    am.subName = Convert.ToString(dr["subName"]);
    //                    am.subType = Convert.ToString(dr["subType"]);
    //                    am.subLink = Convert.ToString(dr["subLink"]);
    //                    am.subNewWindow = Convert.ToInt32(dr["subNewWindow"]);
    //                    am.subProp = Convert.ToString(dr["subProp"]);
    //                    am.subOrder = dr["subOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subOrder"]);
    //                    am.subStatus = Convert.ToString(dr["subStatus"]);
    //                    am.upperSub = Convert.ToInt32(dr["upperSub"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public MenuSub findByPrimaryKey(int menuSubTID)
    //    {
    //        MenuSub am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM MenuSub a WHERE a.menuSubTID = " + menuSubTID;
    //            DataSet ds = my.select(sqlCmd, "MenuSub");
    //            if (ds.Tables["MenuSub"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["MenuSub"].Rows[0];
    //                am = new MenuSub();
    //                am.menuSubTID = Convert.ToInt32(dr["menuSubTID"]);
    //                am.menuMainID = Convert.ToInt32(dr["menuMainID"]);
    //                am.subName = Convert.ToString(dr["subName"]);
    //                am.subType = Convert.ToString(dr["subType"]);
    //                am.subLink = Convert.ToString(dr["subLink"]);
    //                am.subNewWindow = Convert.ToInt32(dr["subNewWindow"]);
    //                am.subProp = Convert.ToString(dr["subProp"]);
    //                am.subOrder = dr["subOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["subOrder"]);
    //                am.subStatus = Convert.ToString(dr["subStatus"]);
    //                am.upperSub = Convert.ToInt32(dr["upperSub"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int menuMainID, String subName, String subType, String subLink, int subNewWindow, String subProp, int subOrder, String subStatus, int upperSub)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into MenuSub(menuMainID,subName,subType,subLink,subNewWindow,subProp,subOrder,subStatus,upperSub) values (" + menuMainID + ",'" + subName + "','" + subType + "','" + subLink + "'," + subNewWindow + ",'" + subProp + "'," + subOrder + ",'" + subStatus + "'," + upperSub + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int menuSubTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from MenuSub where menuSubTID = " + menuSubTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int menuMainID, String subName, String subType, String subLink, int subNewWindow, String subProp, int subOrder, String subStatus, int upperSub)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update MenuSub set menuMainID =" + menuMainID + ",subName ='" + subName + "',subType ='" + subType + "',subLink ='" + subLink + "',subNewWindow =" + subNewWindow + ",subProp ='" + subProp + "',subOrder =" + subOrder + ",subStatus ='" + subStatus + "',upperSub =" + upperSub + " where menuSubTID = " + this.menuSubTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update MenuSub set menuMainID =" + this.menuMainID + ",subName ='" + this.subName + "',subType ='" + this.subType + "',subLink ='" + this.subLink + "',subNewWindow =" + this.subNewWindow + ",subProp ='" + this.subProp + "',subOrder =" + this.subOrder + ",subStatus ='" + this.subStatus + "',upperSub =" + this.upperSub + " where menuSubTID = " + this.menuSubTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "MenuSub");
    //            if (ds.Tables["MenuSub"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["MenuSub"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuSub.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


