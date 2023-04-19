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
    //[MetadataType(typeof(OrderCarCostScheduleMainMetadata))]
    //public partial class OrderCarCostScheduleMain
    //{
    
    //    public Collection<OrderCarCostScheduleMain> findAll()
    //    {
    //        Collection<OrderCarCostScheduleMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderCarCostScheduleMain order by orderCarCostScheduleTID asc", "OrderCarCostScheduleMain");
    //            if (ds.Tables["OrderCarCostScheduleMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarCostScheduleMain>();
    //                foreach (DataRow dr in ds.Tables["OrderCarCostScheduleMain"].Rows)
    //                {
    //                    OrderCarCostScheduleMain am = new OrderCarCostScheduleMain();
    //                    am.orderCarCostScheduleTID = Convert.ToInt32(dr["orderCarCostScheduleTID"]);
    //                    am.costScheduleName = Convert.ToString(dr["costScheduleName"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarCostScheduleMain> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarCostScheduleMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarCostScheduleMain");
    //            if (ds.Tables["OrderCarCostScheduleMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarCostScheduleMain>();
    //                foreach (DataRow dr in ds.Tables["OrderCarCostScheduleMain"].Rows)
    //                {
    //                    OrderCarCostScheduleMain am = new OrderCarCostScheduleMain();
    //                    am.orderCarCostScheduleTID = Convert.ToInt32(dr["orderCarCostScheduleTID"]);
    //                    am.costScheduleName = Convert.ToString(dr["costScheduleName"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarCostScheduleMain findByPrimaryKey(int orderCarCostScheduleTID)
    //    {
    //        OrderCarCostScheduleMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderCarCostScheduleMain a WHERE a.orderCarCostScheduleTID = " + orderCarCostScheduleTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarCostScheduleMain");
    //            if (ds.Tables["OrderCarCostScheduleMain"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarCostScheduleMain"].Rows[0];
    //                am = new OrderCarCostScheduleMain();
    //                am.orderCarCostScheduleTID = Convert.ToInt32(dr["orderCarCostScheduleTID"]);
    //                am.costScheduleName = Convert.ToString(dr["costScheduleName"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String costScheduleName, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarCostScheduleMain(costScheduleName,status) values ('" + costScheduleName + "','" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int orderCarCostScheduleTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderCarCostScheduleMain where orderCarCostScheduleTID = " + orderCarCostScheduleTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String costScheduleName, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarCostScheduleMain set costScheduleName ='" + costScheduleName + "',status ='" + status + "' where orderCarCostScheduleTID = " + this.orderCarCostScheduleTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarCostScheduleMain set costScheduleName ='" + this.costScheduleName + "',status ='" + this.status + "' where orderCarCostScheduleTID = " + this.orderCarCostScheduleTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarCostScheduleMain");
    //            if (ds.Tables["OrderCarCostScheduleMain"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarCostScheduleMain"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarCostScheduleMain.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
    //public class OrderCarCostScheduleMainMetadata
    //{
    //    [JsonIgnore]
    //    [IgnoreDataMember]
    //    public virtual ICollection<OrderCarCostScheduleSub> OrderCarCostScheduleSub { get; set; }
    //    [JsonIgnore]
    //    [IgnoreDataMember]
    //    public virtual ICollection<OrderRegular> OrderRegular { get; set; }
    //}
}


