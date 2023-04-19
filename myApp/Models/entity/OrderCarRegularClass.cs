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
    //public partial class OrderCarRegularClass
    //{
   
    //    public Collection<OrderCarRegularClass> findAll()
    //    {
    //        Collection<OrderCarRegularClass> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarRegularClass order by OrderCarRegularClassTID asc", "OrderCarRegularClass");
    //            if (ds.Tables["OrderCarRegularClass"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularClass>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularClass"].Rows)
    //                {
    //                    OrderCarRegularClass am = new OrderCarRegularClass();
    //                    am.Cls_Title = Convert.ToString(dr["Cls_Title"]);
    //                    am.Cls_Status = Convert.ToString(dr["Cls_Status"]);
    //                    am.Cls_Order = Convert.ToInt32(dr["Cls_Order"]);
    //                    am.OrderCarRegularClassTID = Convert.ToInt32(dr["OrderCarRegularClassTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarRegularClass> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarRegularClass> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularClass");
    //            if (ds.Tables["OrderCarRegularClass"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularClass>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularClass"].Rows)
    //                {
    //                    OrderCarRegularClass am = new OrderCarRegularClass();
    //                    am.Cls_Title = Convert.ToString(dr["Cls_Title"]);
    //                    am.Cls_Status = Convert.ToString(dr["Cls_Status"]);
    //                    am.Cls_Order = Convert.ToInt32(dr["Cls_Order"]);
    //                    am.OrderCarRegularClassTID = Convert.ToInt32(dr["OrderCarRegularClassTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarRegularClass findByPrimaryKey(int OrderCarRegularClassTID)
    //    {
    //        OrderCarRegularClass am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarRegularClass a WHERE a.OrderCarRegularClassTID = " + OrderCarRegularClassTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularClass");
    //            if (ds.Tables["OrderCarRegularClass"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularClass"].Rows[0];
    //                am = new OrderCarRegularClass();
    //                am.Cls_Title = Convert.ToString(dr["Cls_Title"]);
    //                am.Cls_Status = Convert.ToString(dr["Cls_Status"]);
    //                am.Cls_Order = Convert.ToInt32(dr["Cls_Order"]);
    //                am.OrderCarRegularClassTID = Convert.ToInt32(dr["OrderCarRegularClassTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String Cls_Title, String Cls_Status, int Cls_Order)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(Cls_Title) ? "''" : "N'" + Regex.Replace(Cls_Title, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(Cls_Status) ? "''" : "N'" + Regex.Replace(Cls_Status, "'", "''") + "'") + ",");
    //            sb_value.Append(Cls_Order);

    //            String sqlCmd = "insert into OrderCarRegularClass(Cls_Title,Cls_Status,Cls_Order) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarRegularClassTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarRegularClass where OrderCarRegularClassTID = " + OrderCarRegularClassTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String Cls_Title, String Cls_Status, int Cls_Order)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("Cls_Title=" + (String.IsNullOrEmpty(Cls_Title) ? "''" : "N'" + Regex.Replace(Cls_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("Cls_Status=" + (String.IsNullOrEmpty(Cls_Status) ? "''" : "N'" + Regex.Replace(Cls_Status, "'", "''") + "'") + ",");
    //            sb_value.Append("Cls_Order =" + Cls_Order);

    //            String sqlCmd = "update OrderCarRegularClass set  " + sb_value.ToString() + "  where OrderCarRegularClassTID = " + this.OrderCarRegularClassTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.create() : " + e.ToString());
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
    //            sb_value.Append("Cls_Title=" + (String.IsNullOrEmpty(this.Cls_Title) ? "''" : "N'" + Regex.Replace(this.Cls_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("Cls_Status=" + (String.IsNullOrEmpty(this.Cls_Status) ? "''" : "N'" + Regex.Replace(this.Cls_Status, "'", "''") + "'") + ",");
    //            sb_value.Append("Cls_Order =" + this.Cls_Order);

    //            String sqlCmd = "update OrderCarRegularClass set  " + sb_value.ToString() + "  where OrderCarRegularClassTID = " + this.OrderCarRegularClassTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularClass");
    //            if (ds.Tables["OrderCarRegularClass"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularClass"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularClass.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


