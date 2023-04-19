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

    //public partial class CarPartItem
    //{
   
    //    public Collection<CarPartItem> findAll()
    //    {
    //        Collection<CarPartItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarPartItem order by carPartItemTID asc", "CarPartItem");
    //            if (ds.Tables["CarPartItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarPartItem>();
    //                foreach (DataRow dr in ds.Tables["CarPartItem"].Rows)
    //                {
    //                    CarPartItem am = new CarPartItem();
    //                    am.itemName = Convert.ToString(dr["itemName"]);
    //                    am.itemCheckAfterMile = Convert.ToDecimal(dr["itemCheckAfterMile"]);
    //                    am.itemCheckAfterMonth = Convert.ToInt32(dr["itemCheckAfterMonth"]);
    //                    am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                    am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                    am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                    am.itemOkMemo = Convert.ToString(dr["itemOkMemo"]);
    //                    am.itemFaultyMemo = Convert.ToString(dr["itemFaultyMemo"]);
    //                    am.carPartItemTID = Convert.ToInt32(dr["carPartItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarPartItem> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarPartItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarPartItem");
    //            if (ds.Tables["CarPartItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarPartItem>();
    //                foreach (DataRow dr in ds.Tables["CarPartItem"].Rows)
    //                {
    //                    CarPartItem am = new CarPartItem();
    //                    am.itemName = Convert.ToString(dr["itemName"]);
    //                    am.itemCheckAfterMile = Convert.ToDecimal(dr["itemCheckAfterMile"]);
    //                    am.itemCheckAfterMonth = Convert.ToInt32(dr["itemCheckAfterMonth"]);
    //                    am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                    am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                    am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                    am.itemOkMemo = Convert.ToString(dr["itemOkMemo"]);
    //                    am.itemFaultyMemo = Convert.ToString(dr["itemFaultyMemo"]);
    //                    am.carPartItemTID = Convert.ToInt32(dr["carPartItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarPartItem findByPrimaryKey(int carPartItemTID)
    //    {
    //        CarPartItem am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarPartItem a WHERE a.carPartItemTID = " + carPartItemTID;
    //            DataSet ds = my.select(sqlCmd, "CarPartItem");
    //            if (ds.Tables["CarPartItem"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarPartItem"].Rows[0];
    //                am = new CarPartItem();
    //                am.itemName = Convert.ToString(dr["itemName"]);
    //                am.itemCheckAfterMile = Convert.ToDecimal(dr["itemCheckAfterMile"]);
    //                am.itemCheckAfterMonth = Convert.ToInt32(dr["itemCheckAfterMonth"]);
    //                am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                am.itemOkMemo = Convert.ToString(dr["itemOkMemo"]);
    //                am.itemFaultyMemo = Convert.ToString(dr["itemFaultyMemo"]);
    //                am.carPartItemTID = Convert.ToInt32(dr["carPartItemTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String itemName, double itemCheckAfterMile, int itemCheckAfterMonth, String itemMemo, int itemShowOnReport, String itemStatus, String itemOkMemo, String itemFaultyMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarPartItem(itemName,itemCheckAfterMile,itemCheckAfterMonth,itemMemo,itemShowOnReport,itemStatus,itemOkMemo,itemFaultyMemo) values (N'" + itemName + "'," + itemCheckAfterMile + "," + itemCheckAfterMonth + ",N'" + itemMemo + "'," + itemShowOnReport + ",N'" + itemStatus + "',N'" + itemOkMemo + "',N'" + itemFaultyMemo + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carPartItemTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarPartItem where carPartItemTID = " + carPartItemTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String itemName, double itemCheckAfterMile, int itemCheckAfterMonth, String itemMemo, int itemShowOnReport, String itemStatus, String itemOkMemo, String itemFaultyMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarPartItem set itemName =N'" + itemName + "',itemCheckAfterMile =" + itemCheckAfterMile + ",itemCheckAfterMonth =" + itemCheckAfterMonth + ",itemMemo =N'" + itemMemo + "',itemShowOnReport =" + itemShowOnReport + ",itemStatus =N'" + itemStatus + "',itemOkMemo =N'" + itemOkMemo + "',itemFaultyMemo =N'" + itemFaultyMemo + "' where carPartItemTID = " + this.carPartItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarPartItem set itemName =N'" + this.itemName + "',itemCheckAfterMile =" + this.itemCheckAfterMile + ",itemCheckAfterMonth =" + this.itemCheckAfterMonth + ",itemMemo =N'" + this.itemMemo + "',itemShowOnReport =" + this.itemShowOnReport + ",itemStatus =N'" + this.itemStatus + "',itemOkMemo =N'" + this.itemOkMemo + "',itemFaultyMemo =N'" + this.itemFaultyMemo + "' where carPartItemTID = " + this.carPartItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarPartItem");
    //            if (ds.Tables["CarPartItem"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarPartItem"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItem.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
 
}


