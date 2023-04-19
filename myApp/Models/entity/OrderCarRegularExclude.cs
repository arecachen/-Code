using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
namespace hsintongERP2022.Models
{
    //public partial class OrderCarRegularExclude
    //{

    //    public Collection<OrderCarRegularExclude> findAll()
    //    {
    //        Collection<OrderCarRegularExclude> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarRegularExclude order by OrderCarRegularExcludeTID asc", "OrderCarRegularExclude");
    //            if (ds.Tables["OrderCarRegularExclude"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularExclude>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularExclude"].Rows)
    //                {
    //                    OrderCarRegularExclude am = new OrderCarRegularExclude();
    //                    am.OrderCarRegularInfoID = Convert.ToInt32(dr["OrderCarRegularInfoID"]);
    //                    am.ExStartDate = Convert.ToInt64(dr["ExStartDate"]);
    //                    am.ExEndDate = Convert.ToInt64(dr["ExEndDate"]);
    //                    am.OrderCarRegularExcludeTID = Convert.ToInt32(dr["OrderCarRegularExcludeTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarRegularExclude> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarRegularExclude> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularExclude");
    //            if (ds.Tables["OrderCarRegularExclude"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularExclude>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularExclude"].Rows)
    //                {
    //                    OrderCarRegularExclude am = new OrderCarRegularExclude();
    //                    am.OrderCarRegularInfoID = Convert.ToInt32(dr["OrderCarRegularInfoID"]);
    //                    am.ExStartDate = Convert.ToInt64(dr["ExStartDate"]);
    //                    am.ExEndDate = Convert.ToInt64(dr["ExEndDate"]);
    //                    am.OrderCarRegularExcludeTID = Convert.ToInt32(dr["OrderCarRegularExcludeTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarRegularExclude findByPrimaryKey(int OrderCarRegularExcludeTID)
    //    {
    //        OrderCarRegularExclude am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarRegularExclude a WHERE a.OrderCarRegularExcludeTID = " + OrderCarRegularExcludeTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularExclude");
    //            if (ds.Tables["OrderCarRegularExclude"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularExclude"].Rows[0];
    //                am = new OrderCarRegularExclude();
    //                am.OrderCarRegularInfoID = Convert.ToInt32(dr["OrderCarRegularInfoID"]);
    //                am.ExStartDate = Convert.ToInt64(dr["ExStartDate"]);
    //                am.ExEndDate = Convert.ToInt64(dr["ExEndDate"]);
    //                am.OrderCarRegularExcludeTID = Convert.ToInt32(dr["OrderCarRegularExcludeTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int OrderCarRegularInfoID, long ExStartDate, long ExEndDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(OrderCarRegularInfoID + ",");
    //            sb_value.Append(ExStartDate + ",");
    //            sb_value.Append(ExEndDate);

    //            String sqlCmd = "insert into OrderCarRegularExclude(OrderCarRegularInfoID,ExStartDate,ExEndDate) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarRegularExcludeTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarRegularExclude where OrderCarRegularExcludeTID = " + OrderCarRegularExcludeTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.delete() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int DeleteByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int OrderCarRegularInfoID, long ExStartDate, long ExEndDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("OrderCarRegularInfoID =" + OrderCarRegularInfoID + ",");
    //            sb_value.Append("ExStartDate =" + ExStartDate + ",");
    //            sb_value.Append("ExEndDate =" + ExEndDate);

    //            String sqlCmd = "update OrderCarRegularExclude set  " + sb_value.ToString() + "  where OrderCarRegularExcludeTID = " + this.OrderCarRegularExcludeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("OrderCarRegularInfoID =" + this.OrderCarRegularInfoID + ",");
    //            sb_value.Append("ExStartDate =" + this.ExStartDate + ",");
    //            sb_value.Append("ExEndDate =" + this.ExEndDate);

    //            String sqlCmd = "update OrderCarRegularExclude set  " + sb_value.ToString() + "  where OrderCarRegularExcludeTID = " + this.OrderCarRegularExcludeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularExclude");
    //            if (ds.Tables["OrderCarRegularExclude"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularExclude"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularExclude.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


