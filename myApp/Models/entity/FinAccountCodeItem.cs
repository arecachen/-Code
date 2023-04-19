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
    //public partial class FinAccountCodeItem
    //{

    //    public Collection<FinAccountCodeItem> findAll()
    //    {
    //        Collection<FinAccountCodeItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from FinAccountCodeItem order by FinAccountCodeItemTID asc", "FinAccountCodeItem");
    //            if (ds.Tables["FinAccountCodeItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<FinAccountCodeItem>();
    //                foreach (DataRow dr in ds.Tables["FinAccountCodeItem"].Rows)
    //                {
    //                    FinAccountCodeItem am = new FinAccountCodeItem();
    //                    am.FinAccountCodeMainID = Convert.ToInt32(dr["FinAccountCodeMainID"]);
    //                    am.FinAccItemCode = Convert.ToString(dr["FinAccItemCode"]);
    //                    am.FinAccItemName = Convert.ToString(dr["FinAccItemName"]);
    //                    am.FinAccItemDirection = Convert.ToString(dr["FinAccItemDirection"]);
    //                    am.FinAccItemIsHeader = dr["FinAccItemIsHeader"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinAccItemIsHeader"]);
    //                    am.FinAccUpperItem = Convert.ToInt32(dr["FinAccUpperItem"]);
    //                    am.FinAccItemStatus = Convert.ToString(dr["FinAccItemStatus"]);
    //                    am.FinAccItemOrder = Convert.ToInt32(dr["FinAccItemOrder"]);
    //                    am.FinAccountCodeItemTID = Convert.ToInt32(dr["FinAccountCodeItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<FinAccountCodeItem> findByKeyword(String sqlCmd)
    //    {
    //        Collection<FinAccountCodeItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FinAccountCodeItem");
    //            if (ds.Tables["FinAccountCodeItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<FinAccountCodeItem>();
    //                foreach (DataRow dr in ds.Tables["FinAccountCodeItem"].Rows)
    //                {
    //                    FinAccountCodeItem am = new FinAccountCodeItem();
    //                    am.FinAccountCodeMainID = Convert.ToInt32(dr["FinAccountCodeMainID"]);
    //                    am.FinAccItemCode = Convert.ToString(dr["FinAccItemCode"]);
    //                    am.FinAccItemName = Convert.ToString(dr["FinAccItemName"]);
    //                    am.FinAccItemDirection = Convert.ToString(dr["FinAccItemDirection"]);
    //                    am.FinAccItemIsHeader = dr["FinAccItemIsHeader"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinAccItemIsHeader"]);
    //                    am.FinAccUpperItem = Convert.ToInt32(dr["FinAccUpperItem"]);
    //                    am.FinAccItemStatus = Convert.ToString(dr["FinAccItemStatus"]);
    //                    am.FinAccItemOrder = Convert.ToInt32(dr["FinAccItemOrder"]);
    //                    am.FinAccountCodeItemTID = Convert.ToInt32(dr["FinAccountCodeItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public FinAccountCodeItem findByPrimaryKey(int FinAccountCodeItemTID)
    //    {
    //        FinAccountCodeItem am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM FinAccountCodeItem a WHERE a.FinAccountCodeItemTID = " + FinAccountCodeItemTID;
    //            DataSet ds = my.select(sqlCmd, "FinAccountCodeItem");
    //            if (ds.Tables["FinAccountCodeItem"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["FinAccountCodeItem"].Rows[0];
    //                am = new FinAccountCodeItem();
    //                am.FinAccountCodeMainID = Convert.ToInt32(dr["FinAccountCodeMainID"]);
    //                am.FinAccItemCode = Convert.ToString(dr["FinAccItemCode"]);
    //                am.FinAccItemName = Convert.ToString(dr["FinAccItemName"]);
    //                am.FinAccItemDirection = Convert.ToString(dr["FinAccItemDirection"]);
    //                am.FinAccItemIsHeader = dr["FinAccItemIsHeader"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinAccItemIsHeader"]);
    //                am.FinAccUpperItem = Convert.ToInt32(dr["FinAccUpperItem"]);
    //                am.FinAccItemStatus = Convert.ToString(dr["FinAccItemStatus"]);
    //                am.FinAccItemOrder = Convert.ToInt32(dr["FinAccItemOrder"]);
    //                am.FinAccountCodeItemTID = Convert.ToInt32(dr["FinAccountCodeItemTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int FinAccountCodeMainID, String FinAccItemCode, String FinAccItemName, String FinAccItemDirection, int FinAccItemIsHeader, int FinAccUpperItem, String FinAccItemStatus, int FinAccItemOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into FinAccountCodeItem(FinAccountCodeMainID,FinAccItemCode,FinAccItemName,FinAccItemDirection,FinAccItemIsHeader,FinAccUpperItem,FinAccItemStatus,FinAccItemOrder) values (" + FinAccountCodeMainID + ",N'" + FinAccItemCode + "',N'" + FinAccItemName + "',N'" + FinAccItemDirection + "'," + FinAccItemIsHeader + "," + FinAccUpperItem + ",N'" + FinAccItemStatus + "'," + FinAccItemOrder + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int FinAccountCodeItemTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from FinAccountCodeItem where FinAccountCodeItemTID = " + FinAccountCodeItemTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int FinAccountCodeMainID, String FinAccItemCode, String FinAccItemName, String FinAccItemDirection, int FinAccItemIsHeader, int FinAccUpperItem, String FinAccItemStatus, int FinAccItemOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FinAccountCodeItem set FinAccountCodeMainID =" + FinAccountCodeMainID + ",FinAccItemCode =N'" + FinAccItemCode + "',FinAccItemName =N'" + FinAccItemName + "',FinAccItemDirection =N'" + FinAccItemDirection + "',FinAccItemIsHeader =" + FinAccItemIsHeader + ",FinAccUpperItem =" + FinAccUpperItem + ",FinAccItemStatus =N'" + FinAccItemStatus + "',FinAccItemOrder =" + FinAccItemOrder + " where FinAccountCodeItemTID = " + this.FinAccountCodeItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FinAccountCodeItem set FinAccountCodeMainID =" + this.FinAccountCodeMainID + ",FinAccItemCode =N'" + this.FinAccItemCode + "',FinAccItemName =N'" + this.FinAccItemName + "',FinAccItemDirection =N'" + this.FinAccItemDirection + "',FinAccItemIsHeader =" + this.FinAccItemIsHeader + ",FinAccUpperItem =" + this.FinAccUpperItem + ",FinAccItemStatus =N'" + this.FinAccItemStatus + "',FinAccItemOrder =" + this.FinAccItemOrder + " where FinAccountCodeItemTID = " + this.FinAccountCodeItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FinAccountCodeItem");
    //            if (ds.Tables["FinAccountCodeItem"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["FinAccountCodeItem"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeItem.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


