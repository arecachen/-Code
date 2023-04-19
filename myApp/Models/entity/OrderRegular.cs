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
    //public partial class OrderRegular
    //{
      
    //    public Collection<OrderRegular> findAll()
    //    {
    //        Collection<OrderRegular> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderRegular order by orderRegularTID asc", "OrderRegular");
    //            if (ds.Tables["OrderRegular"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderRegular>();
    //                foreach (DataRow dr in ds.Tables["OrderRegular"].Rows)
    //                {
    //                    OrderRegular am = new OrderRegular();
    //                    am.orderRegularTID = Convert.ToInt32(dr["orderRegularTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.payTerm = Convert.ToString(dr["payTerm"]);
    //                    am.payPeriod = Convert.ToString(dr["payPeriod"]);
    //                    am.payAmount = dr["payAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payAmount"]);
    //                    am.payTermAmount = dr["payTermAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payTermAmount"]);
    //                    am.payPeriodCount = Convert.ToInt32(dr["payPeriodCount"]);
    //                    am.orderCostScheduleID = dr["orderCostScheduleID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["orderCostScheduleID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderRegular> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderRegular> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderRegular");
    //            if (ds.Tables["OrderRegular"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderRegular>();
    //                foreach (DataRow dr in ds.Tables["OrderRegular"].Rows)
    //                {
    //                    OrderRegular am = new OrderRegular();
    //                    am.orderRegularTID = Convert.ToInt32(dr["orderRegularTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.payTerm = Convert.ToString(dr["payTerm"]);
    //                    am.payPeriod = Convert.ToString(dr["payPeriod"]);
    //                    am.payAmount = dr["payAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payAmount"]);
    //                    am.payTermAmount = dr["payTermAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payTermAmount"]);
    //                    am.payPeriodCount = Convert.ToInt32(dr["payPeriodCount"]);
    //                    am.orderCostScheduleID = dr["orderCostScheduleID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["orderCostScheduleID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderRegular findByPrimaryKey(int orderRegularTID)
    //    {
    //        OrderRegular am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderRegular a WHERE a.orderRegularTID = " + orderRegularTID;
    //            DataSet ds = my.select(sqlCmd, "OrderRegular");
    //            if (ds.Tables["OrderRegular"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderRegular"].Rows[0];
    //                am = new OrderRegular();
    //                am.orderRegularTID = Convert.ToInt32(dr["orderRegularTID"]);
    //                am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                am.payTerm = Convert.ToString(dr["payTerm"]);
    //                am.payPeriod = Convert.ToString(dr["payPeriod"]);
    //                am.payAmount = dr["payAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payAmount"]);
    //                am.payTermAmount = dr["payTermAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payTermAmount"]);
    //                am.payPeriodCount = Convert.ToInt32(dr["payPeriodCount"]);
    //                am.orderCostScheduleID = dr["orderCostScheduleID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["orderCostScheduleID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int orderCarID, String payTerm, String payPeriod, double payAmount, double payTermAmount, int payPeriodCount, int orderCostScheduleID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderRegular(orderCarID,payTerm,payPeriod,payAmount,payTermAmount,payPeriodCount,orderCostScheduleID) values (" + orderCarID + ",'" + payTerm + "','" + payPeriod + "'," + payAmount + "," + payTermAmount + "," + payPeriodCount + "," + orderCostScheduleID + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int orderRegularTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderRegular where orderRegularTID = " + orderRegularTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int orderCarID, String payTerm, String payPeriod, double payAmount, double payTermAmount, int payPeriodCount, int orderCostScheduleID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderRegular set orderCarID =" + orderCarID + ",payTerm ='" + payTerm + "',payPeriod ='" + payPeriod + "',payAmount =" + payAmount + ",payTermAmount =" + payTermAmount + ",payPeriodCount =" + payPeriodCount + ",orderCostScheduleID =" + orderCostScheduleID + " where orderRegularTID = " + this.orderRegularTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderRegular set orderCarID =" + this.orderCarID + ",payTerm ='" + this.payTerm + "',payPeriod ='" + this.payPeriod + "',payAmount =" + this.payAmount + ",payTermAmount =" + this.payTermAmount + ",payPeriodCount =" + this.payPeriodCount + ",orderCostScheduleID =" + this.orderCostScheduleID + " where orderRegularTID = " + this.orderRegularTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderRegular");
    //            if (ds.Tables["OrderRegular"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderRegular"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


