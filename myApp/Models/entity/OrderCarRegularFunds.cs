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
    //public partial class OrderCarRegularFunds
    //{

    //    public Collection<OrderCarRegularFunds> findAll()
    //    {
    //        Collection<OrderCarRegularFunds> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarRegularFunds order by OrderCarRegularFundsTID asc", "OrderCarRegularFunds");
    //            if (ds.Tables["OrderCarRegularFunds"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularFunds>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularFunds"].Rows)
    //                {
    //                    OrderCarRegularFunds am = new OrderCarRegularFunds();
    //                    am.OrderCarRegularInfoID = Convert.ToInt32(dr["OrderCarRegularInfoID"]);
    //                    am.OrderCarRegularClassID = Convert.ToInt32(dr["OrderCarRegularClassID"]);
    //                    am.OrderCarRegularGroupID = Convert.ToInt32(dr["OrderCarRegularGroupID"]);
    //                    am.Funds = Convert.ToInt32(dr["Funds"]);
    //                    am.OrderCarRegularFundsTID = Convert.ToInt32(dr["OrderCarRegularFundsTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarRegularFunds> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarRegularFunds> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularFunds");
    //            if (ds.Tables["OrderCarRegularFunds"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularFunds>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularFunds"].Rows)
    //                {
    //                    OrderCarRegularFunds am = new OrderCarRegularFunds();
    //                    am.OrderCarRegularInfoID = Convert.ToInt32(dr["OrderCarRegularInfoID"]);
    //                    am.OrderCarRegularClassID = Convert.ToInt32(dr["OrderCarRegularClassID"]);
    //                    am.OrderCarRegularGroupID = Convert.ToInt32(dr["OrderCarRegularGroupID"]);
    //                    am.Funds = Convert.ToInt32(dr["Funds"]);
    //                    am.OrderCarRegularFundsTID = Convert.ToInt32(dr["OrderCarRegularFundsTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarRegularFunds findByPrimaryKey(int OrderCarRegularFundsTID)
    //    {
    //        OrderCarRegularFunds am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarRegularFunds a WHERE a.OrderCarRegularFundsTID = " + OrderCarRegularFundsTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularFunds");
    //            if (ds.Tables["OrderCarRegularFunds"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularFunds"].Rows[0];
    //                am = new OrderCarRegularFunds();
    //                am.OrderCarRegularInfoID = Convert.ToInt32(dr["OrderCarRegularInfoID"]);
    //                am.OrderCarRegularClassID = Convert.ToInt32(dr["OrderCarRegularClassID"]);
    //                am.OrderCarRegularGroupID = Convert.ToInt32(dr["OrderCarRegularGroupID"]);
    //                am.Funds = Convert.ToInt32(dr["Funds"]);
    //                am.OrderCarRegularFundsTID = Convert.ToInt32(dr["OrderCarRegularFundsTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int OrderCarRegularInfoID, int OrderCarRegularClassID, int OrderCarRegularGroupID, int Funds)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(OrderCarRegularInfoID + ",");
    //            sb_value.Append(OrderCarRegularClassID + ",");
    //            sb_value.Append(OrderCarRegularGroupID + ",");
    //            sb_value.Append(Funds);

    //            String sqlCmd = "insert into OrderCarRegularFunds(OrderCarRegularInfoID,OrderCarRegularClassID,OrderCarRegularGroupID,Funds) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarRegularFundsTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarRegularFunds where OrderCarRegularFundsTID = " + OrderCarRegularFundsTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int OrderCarRegularInfoID, int OrderCarRegularClassID, int OrderCarRegularGroupID, int Funds)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("OrderCarRegularInfoID =" + OrderCarRegularInfoID + ",");
    //            sb_value.Append("OrderCarRegularClassID =" + OrderCarRegularClassID + ",");
    //            sb_value.Append("OrderCarRegularGroupID =" + OrderCarRegularGroupID + ",");
    //            sb_value.Append("Funds =" + Funds);

    //            String sqlCmd = "update OrderCarRegularFunds set  " + sb_value.ToString() + "  where OrderCarRegularFundsTID = " + this.OrderCarRegularFundsTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.create() : " + e.ToString());
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
    //            sb_value.Append("OrderCarRegularClassID =" + this.OrderCarRegularClassID + ",");
    //            sb_value.Append("OrderCarRegularGroupID =" + this.OrderCarRegularGroupID + ",");
    //            sb_value.Append("Funds =" + this.Funds);

    //            String sqlCmd = "update OrderCarRegularFunds set  " + sb_value.ToString() + "  where OrderCarRegularFundsTID = " + this.OrderCarRegularFundsTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularFunds");
    //            if (ds.Tables["OrderCarRegularFunds"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularFunds"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFunds.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


