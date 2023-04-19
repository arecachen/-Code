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
    //public partial class OrderRegularContractPayment
    //{
    
    //    public Collection<OrderRegularContractPayment> findAll()
    //    {
    //        Collection<OrderRegularContractPayment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderRegularContractPayment order by OrderRegularContractPaymentTID asc", "OrderRegularContractPayment");
    //            if (ds.Tables["OrderRegularContractPayment"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderRegularContractPayment>();
    //                foreach (DataRow dr in ds.Tables["OrderRegularContractPayment"].Rows)
    //                {
    //                    OrderRegularContractPayment am = new OrderRegularContractPayment();
    //                    am.OrderRegularContractPaymentTID = Convert.ToInt32(dr["OrderRegularContractPaymentTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.passengerMin = Convert.ToInt32(dr["passengerMin"]);
    //                    am.passengerMax = Convert.ToInt32(dr["passengerMax"]);
    //                    am.price = Convert.ToInt32(dr["price"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderRegularContractPayment> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderRegularContractPayment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderRegularContractPayment");
    //            if (ds.Tables["OrderRegularContractPayment"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderRegularContractPayment>();
    //                foreach (DataRow dr in ds.Tables["OrderRegularContractPayment"].Rows)
    //                {
    //                    OrderRegularContractPayment am = new OrderRegularContractPayment();
    //                    am.OrderRegularContractPaymentTID = Convert.ToInt32(dr["OrderRegularContractPaymentTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.passengerMin = Convert.ToInt32(dr["passengerMin"]);
    //                    am.passengerMax = Convert.ToInt32(dr["passengerMax"]);
    //                    am.price = Convert.ToInt32(dr["price"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderRegularContractPayment findByPrimaryKey(int OrderRegularContractPaymentTID)
    //    {
    //        OrderRegularContractPayment am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderRegularContractPayment a WHERE a.OrderRegularContractPaymentTID = " + OrderRegularContractPaymentTID;
    //            DataSet ds = my.select(sqlCmd, "OrderRegularContractPayment");
    //            if (ds.Tables["OrderRegularContractPayment"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderRegularContractPayment"].Rows[0];
    //                am = new OrderRegularContractPayment();
    //                am.OrderRegularContractPaymentTID = Convert.ToInt32(dr["OrderRegularContractPaymentTID"]);
    //                am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                am.carType = Convert.ToString(dr["carType"]);
    //                am.passengerMin = Convert.ToInt32(dr["passengerMin"]);
    //                am.passengerMax = Convert.ToInt32(dr["passengerMax"]);
    //                am.price = Convert.ToInt32(dr["price"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int orderCarID, String carType, int passengerMin, int passengerMax, double price)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderRegularContractPayment(orderCarID,carType,passengerMin,passengerMax,price) values (" + orderCarID + ",'" + carType + "'," + passengerMin + "," + passengerMax + "," + price + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderRegularContractPaymentTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderRegularContractPayment where OrderRegularContractPaymentTID = " + OrderRegularContractPaymentTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int orderCarID, String carType, int passengerMin, int passengerMax, double price)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderRegularContractPayment set orderCarID =" + orderCarID + ",carType ='" + carType + "',passengerMin =" + passengerMin + ",passengerMax =" + passengerMax + ",price =" + price + " where OrderRegularContractPaymentTID = " + this.OrderRegularContractPaymentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderRegularContractPayment set orderCarID =" + this.orderCarID + ",carType ='" + this.carType + "',passengerMin =" + this.passengerMin + ",passengerMax =" + this.passengerMax + ",price =" + this.price + " where OrderRegularContractPaymentTID = " + this.OrderRegularContractPaymentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderRegularContractPayment");
    //            if (ds.Tables["OrderRegularContractPayment"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderRegularContractPayment"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegularContractPayment.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


