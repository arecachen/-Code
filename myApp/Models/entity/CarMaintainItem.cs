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
    //public partial class CarMaintainItem
    //{
    
    //    public Collection<CarMaintainItem> findAll()
    //    {
    //        Collection<CarMaintainItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarMaintainItem order by carMaintainItemTID asc", "CarMaintainItem");
    //            if (ds.Tables["CarMaintainItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMaintainItem>();
    //                foreach (DataRow dr in ds.Tables["CarMaintainItem"].Rows)
    //                {
    //                    CarMaintainItem am = new CarMaintainItem();
    //                    am.itemName = Convert.ToString(dr["itemName"]);
    //                    am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                    am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                    am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                    am.carMaintainItemTID = Convert.ToInt32(dr["carMaintainItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarMaintainItem> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarMaintainItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarMaintainItem");
    //            if (ds.Tables["CarMaintainItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMaintainItem>();
    //                foreach (DataRow dr in ds.Tables["CarMaintainItem"].Rows)
    //                {
    //                    CarMaintainItem am = new CarMaintainItem();
    //                    am.itemName = Convert.ToString(dr["itemName"]);
    //                    am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                    am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                    am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                    am.carMaintainItemTID = Convert.ToInt32(dr["carMaintainItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarMaintainItem findByPrimaryKey(int carMaintainItemTID)
    //    {
    //        CarMaintainItem am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarMaintainItem a WHERE a.carMaintainItemTID = " + carMaintainItemTID;
    //            DataSet ds = my.select(sqlCmd, "CarMaintainItem");
    //            if (ds.Tables["CarMaintainItem"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarMaintainItem"].Rows[0];
    //                am = new CarMaintainItem();
    //                am.itemName = Convert.ToString(dr["itemName"]);
    //                am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                am.carMaintainItemTID = Convert.ToInt32(dr["carMaintainItemTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String itemName, String itemMemo, int itemShowOnReport, String itemStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarMaintainItem(itemName,itemMemo,itemShowOnReport,itemStatus) values ('" + itemName + "','" + itemMemo + "'," + itemShowOnReport + ",'" + itemStatus + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carMaintainItemTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarMaintainItem where carMaintainItemTID = " + carMaintainItemTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String itemName, String itemMemo, int itemShowOnReport, String itemStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarMaintainItem set itemName ='" + itemName + "',itemMemo ='" + itemMemo + "',itemShowOnReport =" + itemShowOnReport + ",itemStatus ='" + itemStatus + "' where carMaintainItemTID = " + this.carMaintainItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarMaintainItem set itemName ='" + this.itemName + "',itemMemo ='" + this.itemMemo + "',itemShowOnReport =" + this.itemShowOnReport + ",itemStatus ='" + this.itemStatus + "' where carMaintainItemTID = " + this.carMaintainItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarMaintainItem");
    //            if (ds.Tables["CarMaintainItem"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarMaintainItem"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainItem.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


