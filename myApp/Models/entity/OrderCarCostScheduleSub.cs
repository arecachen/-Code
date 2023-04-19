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
    //public partial class OrderCarCostScheduleSub
    //{
    
    //    public Collection<OrderCarCostScheduleSub> findAll()
    //    {
    //        Collection<OrderCarCostScheduleSub> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderCarCostScheduleSub order by orderCarCostScheduleSubTID asc", "OrderCarCostScheduleSub");
    //            if (ds.Tables["OrderCarCostScheduleSub"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarCostScheduleSub>();
    //                foreach (DataRow dr in ds.Tables["OrderCarCostScheduleSub"].Rows)
    //                {
    //                    OrderCarCostScheduleSub am = new OrderCarCostScheduleSub();
    //                    am.orderCarCostScheduleSubTID = Convert.ToInt32(dr["orderCarCostScheduleSubTID"]);
    //                    am.orderCarCostScheduleID = dr["orderCarCostScheduleID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["orderCarCostScheduleID"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.startTime = Convert.ToString(dr["startTime"]);
    //                    am.endTime = Convert.ToString(dr["endTime"]);
    //                    am.cost = dr["cost"] == DBNull.Value ? -999 : Convert.ToInt32(dr["cost"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarCostScheduleSub> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarCostScheduleSub> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarCostScheduleSub");
    //            if (ds.Tables["OrderCarCostScheduleSub"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarCostScheduleSub>();
    //                foreach (DataRow dr in ds.Tables["OrderCarCostScheduleSub"].Rows)
    //                {
    //                    OrderCarCostScheduleSub am = new OrderCarCostScheduleSub();
    //                    am.orderCarCostScheduleSubTID = Convert.ToInt32(dr["orderCarCostScheduleSubTID"]);
    //                    am.orderCarCostScheduleID = dr["orderCarCostScheduleID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["orderCarCostScheduleID"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.startTime = Convert.ToString(dr["startTime"]);
    //                    am.endTime = Convert.ToString(dr["endTime"]);
    //                    am.cost = dr["cost"] == DBNull.Value ? -999 : Convert.ToInt32(dr["cost"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarCostScheduleSub findByPrimaryKey(int orderCarCostScheduleSubTID)
    //    {
    //        OrderCarCostScheduleSub am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderCarCostScheduleSub a WHERE a.orderCarCostScheduleSubTID = " + orderCarCostScheduleSubTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarCostScheduleSub");
    //            if (ds.Tables["OrderCarCostScheduleSub"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarCostScheduleSub"].Rows[0];
    //                am = new OrderCarCostScheduleSub();
    //                am.orderCarCostScheduleSubTID = Convert.ToInt32(dr["orderCarCostScheduleSubTID"]);
    //                am.orderCarCostScheduleID = dr["orderCarCostScheduleID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["orderCarCostScheduleID"]);
    //                am.carType = Convert.ToString(dr["carType"]);
    //                am.startTime = Convert.ToString(dr["startTime"]);
    //                am.endTime = Convert.ToString(dr["endTime"]);
    //                am.cost = dr["cost"] == DBNull.Value ? -999 : Convert.ToInt32(dr["cost"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int orderCarCostScheduleID, String carType, String startTime, String endTime, double cost)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarCostScheduleSub(orderCarCostScheduleID,carType,startTime,endTime,cost) values (" + orderCarCostScheduleID + ",'" + carType + "','" + startTime + "','" + endTime + "'," + cost + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int orderCarCostScheduleSubTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderCarCostScheduleSub where orderCarCostScheduleSubTID = " + orderCarCostScheduleSubTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int orderCarCostScheduleID, String carType, String startTime, String endTime, double cost)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarCostScheduleSub set orderCarCostScheduleID =" + orderCarCostScheduleID + ",carType ='" + carType + "',startTime ='" + startTime + "',endTime ='" + endTime + "',cost =" + cost + " where orderCarCostScheduleSubTID = " + this.orderCarCostScheduleSubTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarCostScheduleSub set orderCarCostScheduleID =" + this.orderCarCostScheduleID + ",carType ='" + this.carType + "',startTime ='" + this.startTime + "',endTime ='" + this.endTime + "',cost =" + this.cost + " where orderCarCostScheduleSubTID = " + this.orderCarCostScheduleSubTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarCostScheduleSub");
    //            if (ds.Tables["OrderCarCostScheduleSub"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarCostScheduleSub"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleSub.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


