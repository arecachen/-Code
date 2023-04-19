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
    //public partial class OrderCarPartnerCarStatementMain
    //{
     
    //    public Collection<OrderCarPartnerCarStatementMain> findAll()
    //    {
    //        Collection<OrderCarPartnerCarStatementMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarPartnerCarStatementMain order by OrderCarPartnerCarStatementMainTID asc", "OrderCarPartnerCarStatementMain");
    //            if (ds.Tables["OrderCarPartnerCarStatementMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarPartnerCarStatementMain>();
    //                foreach (DataRow dr in ds.Tables["OrderCarPartnerCarStatementMain"].Rows)
    //                {
    //                    OrderCarPartnerCarStatementMain am = new OrderCarPartnerCarStatementMain();
    //                    am.PCSDate = Convert.ToInt64(dr["PCSDate"]);
    //                    am.PCSRecordAmount = Convert.ToInt32(dr["PCSRecordAmount"]);
    //                    am.PCSIntentAmount = Convert.ToInt32(dr["PCSIntentAmount"]);
    //                    am.PCSMemo = Convert.ToString(dr["PCSMemo"]);
    //                    am.PCSSettleDate = dr["PCSSettleDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["PCSSettleDate"]);
    //                    am.PCSSettleAmount = dr["PCSSettleAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSSettleAmount"]);
    //                    am.PCSSettleMemo = Convert.ToString(dr["PCSSettleMemo"]);
    //                    am.PCSSettleBy = dr["PCSSettleBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSSettleBy"]);
    //                    am.PCSCreateBy = dr["PCSCreateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSCreateBy"]);
    //                    am.OrderCarPartnerCarStatementMainTID = Convert.ToInt32(dr["OrderCarPartnerCarStatementMainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarPartnerCarStatementMain> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarPartnerCarStatementMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarPartnerCarStatementMain");
    //            if (ds.Tables["OrderCarPartnerCarStatementMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarPartnerCarStatementMain>();
    //                foreach (DataRow dr in ds.Tables["OrderCarPartnerCarStatementMain"].Rows)
    //                {
    //                    OrderCarPartnerCarStatementMain am = new OrderCarPartnerCarStatementMain();
    //                    am.PCSDate = Convert.ToInt64(dr["PCSDate"]);
    //                    am.PCSRecordAmount = Convert.ToInt32(dr["PCSRecordAmount"]);
    //                    am.PCSIntentAmount = Convert.ToInt32(dr["PCSIntentAmount"]);
    //                    am.PCSMemo = Convert.ToString(dr["PCSMemo"]);
    //                    am.PCSSettleDate = dr["PCSSettleDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["PCSSettleDate"]);
    //                    am.PCSSettleAmount = dr["PCSSettleAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSSettleAmount"]);
    //                    am.PCSSettleMemo = Convert.ToString(dr["PCSSettleMemo"]);
    //                    am.PCSSettleBy = dr["PCSSettleBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSSettleBy"]);
    //                    am.PCSCreateBy = dr["PCSCreateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSCreateBy"]);
    //                    am.OrderCarPartnerCarStatementMainTID = Convert.ToInt32(dr["OrderCarPartnerCarStatementMainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarPartnerCarStatementMain findByPrimaryKey(int OrderCarPartnerCarStatementMainTID)
    //    {
    //        OrderCarPartnerCarStatementMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarPartnerCarStatementMain a WHERE a.OrderCarPartnerCarStatementMainTID = " + OrderCarPartnerCarStatementMainTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarPartnerCarStatementMain");
    //            if (ds.Tables["OrderCarPartnerCarStatementMain"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarPartnerCarStatementMain"].Rows[0];
    //                am = new OrderCarPartnerCarStatementMain();
    //                am.PCSDate = Convert.ToInt64(dr["PCSDate"]);
    //                am.PCSRecordAmount = Convert.ToInt32(dr["PCSRecordAmount"]);
    //                am.PCSIntentAmount = Convert.ToInt32(dr["PCSIntentAmount"]);
    //                am.PCSMemo = Convert.ToString(dr["PCSMemo"]);
    //                am.PCSSettleDate = dr["PCSSettleDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["PCSSettleDate"]);
    //                am.PCSSettleAmount = dr["PCSSettleAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSSettleAmount"]);
    //                am.PCSSettleMemo = Convert.ToString(dr["PCSSettleMemo"]);
    //                am.PCSSettleBy = dr["PCSSettleBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSSettleBy"]);
    //                am.PCSCreateBy = dr["PCSCreateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PCSCreateBy"]);
    //                am.OrderCarPartnerCarStatementMainTID = Convert.ToInt32(dr["OrderCarPartnerCarStatementMainTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(long PCSDate, double PCSRecordAmount, double PCSIntentAmount, String PCSMemo, long PCSSettleDate, double PCSSettleAmount, String PCSSettleMemo, int PCSSettleBy, int PCSCreateBy)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(PCSDate + ",");
    //            sb_value.Append(PCSRecordAmount + ",");
    //            sb_value.Append(PCSIntentAmount + ",");
    //            sb_value.Append((String.IsNullOrEmpty(PCSMemo) ? "null" : "N'" + Regex.Replace(PCSMemo, "'", "''") + "'") + ",");
    //            sb_value.Append(PCSSettleDate + ",");
    //            sb_value.Append(PCSSettleAmount + ",");
    //            sb_value.Append((String.IsNullOrEmpty(PCSSettleMemo) ? "null" : "N'" + Regex.Replace(PCSSettleMemo, "'", "''") + "'") + ",");
    //            sb_value.Append(PCSSettleBy + ",");
    //            sb_value.Append(PCSCreateBy);

    //            String sqlCmd = "insert into OrderCarPartnerCarStatementMain(PCSDate,PCSRecordAmount,PCSIntentAmount,PCSMemo,PCSSettleDate,PCSSettleAmount,PCSSettleMemo,PCSSettleBy,PCSCreateBy) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarPartnerCarStatementMainTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarPartnerCarStatementMain where OrderCarPartnerCarStatementMainTID = " + OrderCarPartnerCarStatementMainTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(long PCSDate, double PCSRecordAmount, double PCSIntentAmount, String PCSMemo, long PCSSettleDate, double PCSSettleAmount, String PCSSettleMemo, int PCSSettleBy, int PCSCreateBy)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("PCSDate =" + PCSDate + ",");
    //            sb_value.Append("PCSRecordAmount =" + PCSRecordAmount + ",");
    //            sb_value.Append("PCSIntentAmount =" + PCSIntentAmount + ",");
    //            sb_value.Append("PCSMemo=" + (String.IsNullOrEmpty(PCSMemo) ? "null" : "N'" + Regex.Replace(PCSMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("PCSSettleDate =" + PCSSettleDate + ",");
    //            sb_value.Append("PCSSettleAmount =" + PCSSettleAmount + ",");
    //            sb_value.Append("PCSSettleMemo=" + (String.IsNullOrEmpty(PCSSettleMemo) ? "null" : "N'" + Regex.Replace(PCSSettleMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("PCSSettleBy =" + PCSSettleBy + ",");
    //            sb_value.Append("PCSCreateBy =" + PCSCreateBy);

    //            String sqlCmd = "update OrderCarPartnerCarStatementMain set  " + sb_value.ToString() + "  where OrderCarPartnerCarStatementMainTID = " + this.OrderCarPartnerCarStatementMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.create() : " + e.ToString());
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
    //            sb_value.Append("PCSDate =" + this.PCSDate + ",");
    //            sb_value.Append("PCSRecordAmount =" + this.PCSRecordAmount + ",");
    //            sb_value.Append("PCSIntentAmount =" + this.PCSIntentAmount + ",");
    //            sb_value.Append("PCSMemo=" + (String.IsNullOrEmpty(this.PCSMemo) ? "null" : "N'" + Regex.Replace(this.PCSMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("PCSSettleDate =" + this.PCSSettleDate + ",");
    //            sb_value.Append("PCSSettleAmount =" + this.PCSSettleAmount + ",");
    //            sb_value.Append("PCSSettleMemo=" + (String.IsNullOrEmpty(this.PCSSettleMemo) ? "null" : "N'" + Regex.Replace(this.PCSSettleMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("PCSSettleBy =" + this.PCSSettleBy + ",");
    //            sb_value.Append("PCSCreateBy =" + this.PCSCreateBy);

    //            String sqlCmd = "update OrderCarPartnerCarStatementMain set  " + sb_value.ToString() + "  where OrderCarPartnerCarStatementMainTID = " + this.OrderCarPartnerCarStatementMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarPartnerCarStatementMain");
    //            if (ds.Tables["OrderCarPartnerCarStatementMain"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarPartnerCarStatementMain"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarPartnerCarStatementMain.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


