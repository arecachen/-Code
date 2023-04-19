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
    //public partial class OrderCarPartnerCarStatementItem
    //{
     
    //    public Collection<OrderCarPartnerCarStatementItem> findAll()
    //    {
    //        Collection<OrderCarPartnerCarStatementItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarPartnerCarStatementItem order by OrderCarPartnerCarStatementItemTID asc", "OrderCarPartnerCarStatementItem");
    //            if (ds.Tables["OrderCarPartnerCarStatementItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarPartnerCarStatementItem>();
    //                foreach (DataRow dr in ds.Tables["OrderCarPartnerCarStatementItem"].Rows)
    //                {
    //                    OrderCarPartnerCarStatementItem am = new OrderCarPartnerCarStatementItem();
    //                    am.OrderCarPartnerCarStatementMainID = Convert.ToInt32(dr["OrderCarPartnerCarStatementMainID"]);
    //                    am.OrderCarJobID = Convert.ToInt32(dr["OrderCarJobID"]);
    //                    am.PartnerInfoType = Convert.ToString(dr["PartnerInfoType"]);
    //                    am.PCSItemDirection = Convert.ToString(dr["PCSItemDirection"]);
    //                    am.PCSItemPrice = Convert.ToInt32(dr["PCSItemPrice"]);
    //                    am.OrderCarPartnerCarStatementItemTID = Convert.ToInt32(dr["OrderCarPartnerCarStatementItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarPartnerCarStatementItem> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarPartnerCarStatementItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarPartnerCarStatementItem");
    //            if (ds.Tables["OrderCarPartnerCarStatementItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarPartnerCarStatementItem>();
    //                foreach (DataRow dr in ds.Tables["OrderCarPartnerCarStatementItem"].Rows)
    //                {
    //                    OrderCarPartnerCarStatementItem am = new OrderCarPartnerCarStatementItem();
    //                    am.OrderCarPartnerCarStatementMainID = Convert.ToInt32(dr["OrderCarPartnerCarStatementMainID"]);
    //                    am.OrderCarJobID = Convert.ToInt32(dr["OrderCarJobID"]);
    //                    am.PartnerInfoType = Convert.ToString(dr["PartnerInfoType"]);
    //                    am.PCSItemDirection = Convert.ToString(dr["PCSItemDirection"]);
    //                    am.PCSItemPrice = Convert.ToInt32(dr["PCSItemPrice"]);
    //                    am.OrderCarPartnerCarStatementItemTID = Convert.ToInt32(dr["OrderCarPartnerCarStatementItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarPartnerCarStatementItem findByPrimaryKey(int OrderCarPartnerCarStatementItemTID)
    //    {
    //        OrderCarPartnerCarStatementItem am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarPartnerCarStatementItem a WHERE a.OrderCarPartnerCarStatementItemTID = " + OrderCarPartnerCarStatementItemTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarPartnerCarStatementItem");
    //            if (ds.Tables["OrderCarPartnerCarStatementItem"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarPartnerCarStatementItem"].Rows[0];
    //                am = new OrderCarPartnerCarStatementItem();
    //                am.OrderCarPartnerCarStatementMainID = Convert.ToInt32(dr["OrderCarPartnerCarStatementMainID"]);
    //                am.OrderCarJobID = Convert.ToInt32(dr["OrderCarJobID"]);
    //                am.PartnerInfoType = Convert.ToString(dr["PartnerInfoType"]);
    //                am.PCSItemDirection = Convert.ToString(dr["PCSItemDirection"]);
    //                am.PCSItemPrice = Convert.ToInt32(dr["PCSItemPrice"]);
    //                am.OrderCarPartnerCarStatementItemTID = Convert.ToInt32(dr["OrderCarPartnerCarStatementItemTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int OrderCarPartnerCarStatementMainID, int OrderCarJobID, String PartnerInfoType, String PCSItemDirection, double PCSItemPrice)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(OrderCarPartnerCarStatementMainID + ",");
    //            sb_value.Append(OrderCarJobID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(PartnerInfoType) ? "''" : "N'" + Regex.Replace(PartnerInfoType, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(PCSItemDirection) ? "''" : "N'" + Regex.Replace(PCSItemDirection, "'", "''") + "'") + ",");
    //            sb_value.Append(PCSItemPrice);

    //            String sqlCmd = "insert into OrderCarPartnerCarStatementItem(OrderCarPartnerCarStatementMainID,OrderCarJobID,PartnerInfoType,PCSItemDirection,PCSItemPrice) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarPartnerCarStatementItemTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarPartnerCarStatementItem where OrderCarPartnerCarStatementItemTID = " + OrderCarPartnerCarStatementItemTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int OrderCarPartnerCarStatementMainID, int OrderCarJobID, String PartnerInfoType, String PCSItemDirection, double PCSItemPrice)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("OrderCarPartnerCarStatementMainID =" + OrderCarPartnerCarStatementMainID + ",");
    //            sb_value.Append("OrderCarJobID =" + OrderCarJobID + ",");
    //            sb_value.Append("PartnerInfoType=" + (String.IsNullOrEmpty(PartnerInfoType) ? "''" : "N'" + Regex.Replace(PartnerInfoType, "'", "''") + "'") + ",");
    //            sb_value.Append("PCSItemDirection=" + (String.IsNullOrEmpty(PCSItemDirection) ? "''" : "N'" + Regex.Replace(PCSItemDirection, "'", "''") + "'") + ",");
    //            sb_value.Append("PCSItemPrice =" + PCSItemPrice);

    //            String sqlCmd = "update OrderCarPartnerCarStatementItem set  " + sb_value.ToString() + "  where OrderCarPartnerCarStatementItemTID = " + this.OrderCarPartnerCarStatementItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.create() : " + e.ToString());
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
    //            sb_value.Append("OrderCarPartnerCarStatementMainID =" + this.OrderCarPartnerCarStatementMainID + ",");
    //            sb_value.Append("OrderCarJobID =" + this.OrderCarJobID + ",");
    //            sb_value.Append("PartnerInfoType=" + (String.IsNullOrEmpty(this.PartnerInfoType) ? "''" : "N'" + Regex.Replace(this.PartnerInfoType, "'", "''") + "'") + ",");
    //            sb_value.Append("PCSItemDirection=" + (String.IsNullOrEmpty(this.PCSItemDirection) ? "''" : "N'" + Regex.Replace(this.PCSItemDirection, "'", "''") + "'") + ",");
    //            sb_value.Append("PCSItemPrice =" + this.PCSItemPrice);

    //            String sqlCmd = "update OrderCarPartnerCarStatementItem set  " + sb_value.ToString() + "  where OrderCarPartnerCarStatementItemTID = " + this.OrderCarPartnerCarStatementItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarPartnerCarStatementItem");
    //            if (ds.Tables["OrderCarPartnerCarStatementItem"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarPartnerCarStatementItem"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementItem.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


