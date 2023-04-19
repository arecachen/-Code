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
    //public partial class OrderRegularPayment
    //{
    
    //    public Collection<OrderRegularPayment> findAll()
    //    {
    //        Collection<OrderRegularPayment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderRegularPayment order by OrderRegularPaymentTID asc", "OrderRegularPayment");
    //            if (ds.Tables["OrderRegularPayment"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderRegularPayment>();
    //                foreach (DataRow dr in ds.Tables["OrderRegularPayment"].Rows)
    //                {
    //                    OrderRegularPayment am = new OrderRegularPayment();
    //                    am.OrderRegularPaymentTID = Convert.ToInt32(dr["OrderRegularPaymentTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.payDate = Convert.ToInt64(dr["payDate"]);
    //                    am.payAmount = Convert.ToInt32(dr["payAmount"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderRegularPayment> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderRegularPayment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderRegularPayment");
    //            if (ds.Tables["OrderRegularPayment"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderRegularPayment>();
    //                foreach (DataRow dr in ds.Tables["OrderRegularPayment"].Rows)
    //                {
    //                    OrderRegularPayment am = new OrderRegularPayment();
    //                    am.OrderRegularPaymentTID = Convert.ToInt32(dr["OrderRegularPaymentTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.payDate = Convert.ToInt64(dr["payDate"]);
    //                    am.payAmount = Convert.ToInt32(dr["payAmount"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderRegularPayment findByPrimaryKey(int OrderRegularPaymentTID)
    //    {
    //        OrderRegularPayment am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderRegularPayment a WHERE a.OrderRegularPaymentTID = " + OrderRegularPaymentTID;
    //            DataSet ds = my.select(sqlCmd, "OrderRegularPayment");
    //            if (ds.Tables["OrderRegularPayment"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderRegularPayment"].Rows[0];
    //                am = new OrderRegularPayment();
    //                am.OrderRegularPaymentTID = Convert.ToInt32(dr["OrderRegularPaymentTID"]);
    //                am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                am.payDate = Convert.ToInt64(dr["payDate"]);
    //                am.payAmount = Convert.ToInt32(dr["payAmount"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int orderCarID, long payDate, double payAmount, String memo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderRegularPayment(orderCarID,payDate,payAmount,memo) values (" + orderCarID + "," + payDate + "," + payAmount + ",'" + memo + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderRegularPaymentTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderRegularPayment where OrderRegularPaymentTID = " + OrderRegularPaymentTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int orderCarID, long payDate, double payAmount, String memo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderRegularPayment set orderCarID =" + orderCarID + ",payDate =" + payDate + ",payAmount =" + payAmount + ",memo ='" + memo + "' where OrderRegularPaymentTID = " + this.OrderRegularPaymentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderRegularPayment set orderCarID =" + this.orderCarID + ",payDate =" + this.payDate + ",payAmount =" + this.payAmount + ",memo ='" + this.memo + "' where OrderRegularPaymentTID = " + this.OrderRegularPaymentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderRegularPayment");
    //            if (ds.Tables["OrderRegularPayment"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderRegularPayment"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularPayment.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


