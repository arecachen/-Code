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
    //public partial class OrderCarRegularGroup
    //{

    //    public Collection<OrderCarRegularGroup> findAll()
    //    {
    //        Collection<OrderCarRegularGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarRegularGroup order by OrderCarRegularGroupTID asc", "OrderCarRegularGroup");
    //            if (ds.Tables["OrderCarRegularGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularGroup>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularGroup"].Rows)
    //                {
    //                    OrderCarRegularGroup am = new OrderCarRegularGroup();
    //                    am.Grp_Title = Convert.ToString(dr["Grp_Title"]);
    //                    am.Grp_Status = Convert.ToString(dr["Grp_Status"]);
    //                    am.Grp_Order = Convert.ToInt32(dr["Grp_Order"]);
    //                    am.OrderCarRegularGroupTID = Convert.ToInt32(dr["OrderCarRegularGroupTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarRegularGroup> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarRegularGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularGroup");
    //            if (ds.Tables["OrderCarRegularGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularGroup>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularGroup"].Rows)
    //                {
    //                    OrderCarRegularGroup am = new OrderCarRegularGroup();
    //                    am.Grp_Title = Convert.ToString(dr["Grp_Title"]);
    //                    am.Grp_Status = Convert.ToString(dr["Grp_Status"]);
    //                    am.Grp_Order = Convert.ToInt32(dr["Grp_Order"]);
    //                    am.OrderCarRegularGroupTID = Convert.ToInt32(dr["OrderCarRegularGroupTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarRegularGroup findByPrimaryKey(int OrderCarRegularGroupTID)
    //    {
    //        OrderCarRegularGroup am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarRegularGroup a WHERE a.OrderCarRegularGroupTID = " + OrderCarRegularGroupTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularGroup");
    //            if (ds.Tables["OrderCarRegularGroup"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularGroup"].Rows[0];
    //                am = new OrderCarRegularGroup();
    //                am.Grp_Title = Convert.ToString(dr["Grp_Title"]);
    //                am.Grp_Status = Convert.ToString(dr["Grp_Status"]);
    //                am.Grp_Order = Convert.ToInt32(dr["Grp_Order"]);
    //                am.OrderCarRegularGroupTID = Convert.ToInt32(dr["OrderCarRegularGroupTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String Grp_Title, String Grp_Status, int Grp_Order)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(Grp_Title) ? "''" : "N'" + Regex.Replace(Grp_Title, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(Grp_Status) ? "''" : "N'" + Regex.Replace(Grp_Status, "'", "''") + "'") + ",");
    //            sb_value.Append(Grp_Order);

    //            String sqlCmd = "insert into OrderCarRegularGroup(Grp_Title,Grp_Status,Grp_Order) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarRegularGroupTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarRegularGroup where OrderCarRegularGroupTID = " + OrderCarRegularGroupTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String Grp_Title, String Grp_Status, int Grp_Order)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("Grp_Title=" + (String.IsNullOrEmpty(Grp_Title) ? "''" : "N'" + Regex.Replace(Grp_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("Grp_Status=" + (String.IsNullOrEmpty(Grp_Status) ? "''" : "N'" + Regex.Replace(Grp_Status, "'", "''") + "'") + ",");
    //            sb_value.Append("Grp_Order =" + Grp_Order);

    //            String sqlCmd = "update OrderCarRegularGroup set  " + sb_value.ToString() + "  where OrderCarRegularGroupTID = " + this.OrderCarRegularGroupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.create() : " + e.ToString());
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
    //            sb_value.Append("Grp_Title=" + (String.IsNullOrEmpty(this.Grp_Title) ? "''" : "N'" + Regex.Replace(this.Grp_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("Grp_Status=" + (String.IsNullOrEmpty(this.Grp_Status) ? "''" : "N'" + Regex.Replace(this.Grp_Status, "'", "''") + "'") + ",");
    //            sb_value.Append("Grp_Order =" + this.Grp_Order);

    //            String sqlCmd = "update OrderCarRegularGroup set  " + sb_value.ToString() + "  where OrderCarRegularGroupTID = " + this.OrderCarRegularGroupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularGroup");
    //            if (ds.Tables["OrderCarRegularGroup"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularGroup"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularGroup.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


