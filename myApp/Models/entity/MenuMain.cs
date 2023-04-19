using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace hsintongERP2022.Models
{
    //[MetadataType(typeof(MenuMainMetadata))]
    //public partial class MenuMain
    //{
    
    //    public Collection<MenuMain> findAll()
    //    {
    //        Collection<MenuMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from MenuMain order by menuMainTID asc", "MenuMain");
    //            if (ds.Tables["MenuMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<MenuMain>();
    //                foreach (DataRow dr in ds.Tables["MenuMain"].Rows)
    //                {
    //                    MenuMain am = new MenuMain();
    //                    am.menuMainTID = Convert.ToInt32(dr["menuMainTID"]);
    //                    am.mainName = Convert.ToString(dr["mainName"]);
    //                    am.mainType = Convert.ToString(dr["mainType"]);
    //                    am.mainLink = Convert.ToString(dr["mainLink"]);
    //                    am.mainNewWindow = Convert.ToInt32(dr["mainNewWindow"]);
    //                    am.mainProp = Convert.ToString(dr["mainProp"]);
    //                    am.mainOrder = Convert.ToInt32(dr["mainOrder"]);
    //                    am.mainStatus = Convert.ToString(dr["mainStatus"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<MenuMain> findByKeyword(String sqlCmd)
    //    {
    //        Collection<MenuMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "MenuMain");
    //            if (ds.Tables["MenuMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<MenuMain>();
    //                foreach (DataRow dr in ds.Tables["MenuMain"].Rows)
    //                {
    //                    MenuMain am = new MenuMain();
    //                    am.menuMainTID = Convert.ToInt32(dr["menuMainTID"]);
    //                    am.mainName = Convert.ToString(dr["mainName"]);
    //                    am.mainType = Convert.ToString(dr["mainType"]);
    //                    am.mainLink = Convert.ToString(dr["mainLink"]);
    //                    am.mainNewWindow = Convert.ToInt32(dr["mainNewWindow"]);
    //                    am.mainProp = Convert.ToString(dr["mainProp"]);
    //                    am.mainOrder = Convert.ToInt32(dr["mainOrder"]);
    //                    am.mainStatus = Convert.ToString(dr["mainStatus"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public MenuMain findByPrimaryKey(int menuMainTID)
    //    {
    //        MenuMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM MenuMain a WHERE a.menuMainTID = " + menuMainTID;
    //            DataSet ds = my.select(sqlCmd, "MenuMain");
    //            if (ds.Tables["MenuMain"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["MenuMain"].Rows[0];
    //                am = new MenuMain();
    //                am.menuMainTID = Convert.ToInt32(dr["menuMainTID"]);
    //                am.mainName = Convert.ToString(dr["mainName"]);
    //                am.mainType = Convert.ToString(dr["mainType"]);
    //                am.mainLink = Convert.ToString(dr["mainLink"]);
    //                am.mainNewWindow = Convert.ToInt32(dr["mainNewWindow"]);
    //                am.mainProp = Convert.ToString(dr["mainProp"]);
    //                am.mainOrder = Convert.ToInt32(dr["mainOrder"]);
    //                am.mainStatus = Convert.ToString(dr["mainStatus"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String mainName, String mainType, String mainLink, int mainNewWindow, String mainProp, int mainOrder, String mainStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into MenuMain(mainName,mainType,mainLink,mainNewWindow,mainProp,mainOrder,mainStatus) values ('" + mainName + "','" + mainType + "','" + mainLink + "'," + mainNewWindow + ",'" + mainProp + "'," + mainOrder + ",'" + mainStatus + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int menuMainTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from MenuMain where menuMainTID = " + menuMainTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String mainName, String mainType, String mainLink, int mainNewWindow, String mainProp, int mainOrder, String mainStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update MenuMain set mainName ='" + mainName + "',mainType ='" + mainType + "',mainLink ='" + mainLink + "',mainNewWindow =" + mainNewWindow + ",mainProp ='" + mainProp + "',mainOrder =" + mainOrder + ",mainStatus ='" + mainStatus + "' where menuMainTID = " + this.menuMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update MenuMain set mainName ='" + this.mainName + "',mainType ='" + this.mainType + "',mainLink ='" + this.mainLink + "',mainNewWindow =" + this.mainNewWindow + ",mainProp ='" + this.mainProp + "',mainOrder =" + this.mainOrder + ",mainStatus ='" + this.mainStatus + "' where menuMainTID = " + this.menuMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "MenuMain");
    //            if (ds.Tables["MenuMain"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["MenuMain"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuMain.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
   
}


