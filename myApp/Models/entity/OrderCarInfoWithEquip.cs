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
    //public partial class OrderCarInfoWithEquip
    //{
     
    //    public Collection<OrderCarInfoWithEquip> findAll()
    //    {
    //        Collection<OrderCarInfoWithEquip> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderCarInfoWithEquip order by orderCarInfoWithEquipTID asc", "OrderCarInfoWithEquip");
    //            if (ds.Tables["OrderCarInfoWithEquip"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarInfoWithEquip>();
    //                foreach (DataRow dr in ds.Tables["OrderCarInfoWithEquip"].Rows)
    //                {
    //                    OrderCarInfoWithEquip am = new OrderCarInfoWithEquip();
    //                    am.orderCarInfoWithEquipTID = Convert.ToInt32(dr["orderCarInfoWithEquipTID"]);
    //                    am.orderCarInfoID = Convert.ToInt32(dr["orderCarInfoID"]);
    //                    am.carEquipmentID = Convert.ToInt32(dr["carEquipmentID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarInfoWithEquip> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarInfoWithEquip> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfoWithEquip");
    //            if (ds.Tables["OrderCarInfoWithEquip"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarInfoWithEquip>();
    //                foreach (DataRow dr in ds.Tables["OrderCarInfoWithEquip"].Rows)
    //                {
    //                    OrderCarInfoWithEquip am = new OrderCarInfoWithEquip();
    //                    am.orderCarInfoWithEquipTID = Convert.ToInt32(dr["orderCarInfoWithEquipTID"]);
    //                    am.orderCarInfoID = Convert.ToInt32(dr["orderCarInfoID"]);
    //                    am.carEquipmentID = Convert.ToInt32(dr["carEquipmentID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarInfoWithEquip findByPrimaryKey(int orderCarInfoWithEquipTID)
    //    {
    //        OrderCarInfoWithEquip am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderCarInfoWithEquip a WHERE a.orderCarInfoWithEquipTID = " + orderCarInfoWithEquipTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfoWithEquip");
    //            if (ds.Tables["OrderCarInfoWithEquip"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarInfoWithEquip"].Rows[0];
    //                am = new OrderCarInfoWithEquip();
    //                am.orderCarInfoWithEquipTID = Convert.ToInt32(dr["orderCarInfoWithEquipTID"]);
    //                am.orderCarInfoID = Convert.ToInt32(dr["orderCarInfoID"]);
    //                am.carEquipmentID = Convert.ToInt32(dr["carEquipmentID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int orderCarInfoID, int carEquipmentID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarInfoWithEquip(orderCarInfoID,carEquipmentID) values (" + orderCarInfoID + "," + carEquipmentID + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int orderCarInfoWithEquipTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderCarInfoWithEquip where orderCarInfoWithEquipTID = " + orderCarInfoWithEquipTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int orderCarInfoID, int carEquipmentID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarInfoWithEquip set orderCarInfoID =" + orderCarInfoID + ",carEquipmentID =" + carEquipmentID + " where orderCarInfoWithEquipTID = " + this.orderCarInfoWithEquipTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarInfoWithEquip set orderCarInfoID =" + this.orderCarInfoID + ",carEquipmentID =" + this.carEquipmentID + " where orderCarInfoWithEquipTID = " + this.orderCarInfoWithEquipTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfoWithEquip");
    //            if (ds.Tables["OrderCarInfoWithEquip"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarInfoWithEquip"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoWithEquip.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


