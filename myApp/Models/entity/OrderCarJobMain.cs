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
    //public partial class OrderCarJobMain
    //{

    //    public Collection<OrderCarJobMain> findAll()
    //    {
    //        Collection<OrderCarJobMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderCarJobMain order by OrderCarJobMainTID asc", "OrderCarJobMain");
    //            if (ds.Tables["OrderCarJobMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarJobMain>();
    //                foreach (DataRow dr in ds.Tables["OrderCarJobMain"].Rows)
    //                {
    //                    OrderCarJobMain am = new OrderCarJobMain();
    //                    am.CarJobDate = Convert.ToInt64(dr["CarJobDate"]);
    //                    am.CarJobMemo = Convert.ToString(dr["CarJobMemo"]);
    //                    am.CarJobStatus = Convert.ToString(dr["CarJobStatus"]);
    //                    am.CarJobFinalBy = Convert.ToString(dr["CarJobFinalBy"]);
    //                    am.CarJobFinalDate = Convert.ToInt64(dr["CarJobFinalDate"]);
    //                    am.OrderCarJobMainTID = Convert.ToInt32(dr["OrderCarJobMainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarJobMain> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarJobMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarJobMain");
    //            if (ds.Tables["OrderCarJobMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarJobMain>();
    //                foreach (DataRow dr in ds.Tables["OrderCarJobMain"].Rows)
    //                {
    //                    OrderCarJobMain am = new OrderCarJobMain();
    //                    am.CarJobDate = Convert.ToInt64(dr["CarJobDate"]);
    //                    am.CarJobMemo = Convert.ToString(dr["CarJobMemo"]);
    //                    am.CarJobStatus = Convert.ToString(dr["CarJobStatus"]);
    //                    am.CarJobFinalBy = Convert.ToString(dr["CarJobFinalBy"]);
    //                    am.CarJobFinalDate = Convert.ToInt64(dr["CarJobFinalDate"]);
    //                    am.OrderCarJobMainTID = Convert.ToInt32(dr["OrderCarJobMainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarJobMain findByPrimaryKey(int OrderCarJobMainTID)
    //    {
    //        OrderCarJobMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderCarJobMain a WHERE a.OrderCarJobMainTID = " + OrderCarJobMainTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarJobMain");
    //            if (ds.Tables["OrderCarJobMain"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarJobMain"].Rows[0];
    //                am = new OrderCarJobMain();
    //                am.CarJobDate = Convert.ToInt64(dr["CarJobDate"]);
    //                am.CarJobMemo = Convert.ToString(dr["CarJobMemo"]);
    //                am.CarJobStatus = Convert.ToString(dr["CarJobStatus"]);
    //                am.CarJobFinalBy = Convert.ToString(dr["CarJobFinalBy"]);
    //                am.CarJobFinalDate = Convert.ToInt64(dr["CarJobFinalDate"]);
    //                am.OrderCarJobMainTID = Convert.ToInt32(dr["OrderCarJobMainTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(long CarJobDate, String CarJobMemo, String CarJobStatus, String CarJobFinalBy, long CarJobFinalDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(CarJobDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CarJobMemo) ? "null" : "N'" + Regex.Replace(CarJobMemo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CarJobStatus) ? "null" : "N'" + Regex.Replace(CarJobStatus, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CarJobFinalBy) ? "null" : "N'" + Regex.Replace(CarJobFinalBy, "'", "''") + "'") + ",");
    //            sb_value.Append(CarJobFinalDate);

    //            String sqlCmd = "insert into OrderCarJobMain(CarJobDate,CarJobMemo,CarJobStatus,CarJobFinalBy,CarJobFinalDate) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarJobMainTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderCarJobMain where OrderCarJobMainTID = " + OrderCarJobMainTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(long CarJobDate, String CarJobMemo, String CarJobStatus, String CarJobFinalBy, long CarJobFinalDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("CarJobDate =" + CarJobDate + ",");
    //            sb_value.Append("CarJobMemo=" + (String.IsNullOrEmpty(CarJobMemo) ? "null" : "N'" + Regex.Replace(CarJobMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("CarJobStatus=" + (String.IsNullOrEmpty(CarJobStatus) ? "null" : "N'" + Regex.Replace(CarJobStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("CarJobFinalBy=" + (String.IsNullOrEmpty(CarJobFinalBy) ? "null" : "N'" + Regex.Replace(CarJobFinalBy, "'", "''") + "'") + ",");
    //            sb_value.Append("CarJobFinalDate =" + CarJobFinalDate);

    //            String sqlCmd = "update OrderCarJobMain set  " + sb_value.ToString() + "  where OrderCarJobMainTID = " + this.OrderCarJobMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("CarJobDate =" + this.CarJobDate + ",");
    //            sb_value.Append("CarJobMemo=" + (String.IsNullOrEmpty(this.CarJobMemo) ? "null" : "N'" + Regex.Replace(this.CarJobMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("CarJobStatus=" + (String.IsNullOrEmpty(this.CarJobStatus) ? "null" : "N'" + Regex.Replace(this.CarJobStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("CarJobFinalBy=" + (String.IsNullOrEmpty(this.CarJobFinalBy) ? "null" : "N'" + Regex.Replace(this.CarJobFinalBy, "'", "''") + "'") + ",");
    //            sb_value.Append("CarJobFinalDate =" + this.CarJobFinalDate);

    //            String sqlCmd = "update OrderCarJobMain set  " + sb_value.ToString() + "  where OrderCarJobMainTID = " + this.OrderCarJobMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarJobMain");
    //            if (ds.Tables["OrderCarJobMain"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarJobMain"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


