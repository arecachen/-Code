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
    //public partial class FinCashFlowFinal
    //{
       
    //    public Collection<FinCashFlowFinal> findAll()
    //    {
    //        Collection<FinCashFlowFinal> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from FinCashFlowFinal order by FinCashFlowFinalTID asc", "FinCashFlowFinal");
    //            if (ds.Tables["FinCashFlowFinal"].Rows.Count > 0)
    //            {
    //                c = new Collection<FinCashFlowFinal>();
    //                foreach (DataRow dr in ds.Tables["FinCashFlowFinal"].Rows)
    //                {
    //                    FinCashFlowFinal am = new FinCashFlowFinal();
    //                    am.FinCompany = Convert.ToString(dr["FinCompany"]);
    //                    am.FinFinalCash = Convert.ToInt64(dr["FinFinalCash"]);
    //                    am.FinSettleDate = Convert.ToInt64(dr["FinSettleDate"]);
    //                    am.FinCreateDate = Convert.ToInt64(dr["FinCreateDate"]);
    //                    am.FinFinalCash_Non = Convert.ToInt64(dr["FinFinalCash_Non"]);
    //                    am.FinCashFlowFinalTID = Convert.ToInt32(dr["FinCashFlowFinalTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<FinCashFlowFinal> findByKeyword(String sqlCmd)
    //    {
    //        Collection<FinCashFlowFinal> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "FinCashFlowFinal");
    //            if (ds.Tables["FinCashFlowFinal"].Rows.Count > 0)
    //            {
    //                c = new Collection<FinCashFlowFinal>();
    //                foreach (DataRow dr in ds.Tables["FinCashFlowFinal"].Rows)
    //                {
    //                    FinCashFlowFinal am = new FinCashFlowFinal();
    //                    am.FinCompany = Convert.ToString(dr["FinCompany"]);
    //                    am.FinFinalCash = Convert.ToInt64(dr["FinFinalCash"]);
    //                    am.FinSettleDate = Convert.ToInt64(dr["FinSettleDate"]);
    //                    am.FinCreateDate = Convert.ToInt64(dr["FinCreateDate"]);
    //                    am.FinFinalCash_Non = Convert.ToInt64(dr["FinFinalCash_Non"]);
    //                    am.FinCashFlowFinalTID = Convert.ToInt32(dr["FinCashFlowFinalTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public FinCashFlowFinal findByPrimaryKey(int FinCashFlowFinalTID)
    //    {
    //        FinCashFlowFinal am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM FinCashFlowFinal a WHERE a.FinCashFlowFinalTID = " + FinCashFlowFinalTID;
    //            DataSet ds = my.select(sqlCmd, "FinCashFlowFinal");
    //            if (ds.Tables["FinCashFlowFinal"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["FinCashFlowFinal"].Rows[0];
    //                am = new FinCashFlowFinal();
    //                am.FinCompany = Convert.ToString(dr["FinCompany"]);
    //                am.FinFinalCash = Convert.ToInt64(dr["FinFinalCash"]);
    //                am.FinSettleDate = Convert.ToInt64(dr["FinSettleDate"]);
    //                am.FinCreateDate = Convert.ToInt64(dr["FinCreateDate"]);
    //                am.FinFinalCash_Non = Convert.ToInt64(dr["FinFinalCash_Non"]);
    //                am.FinCashFlowFinalTID = Convert.ToInt32(dr["FinCashFlowFinalTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String FinCompany, long FinFinalCash, long FinSettleDate, long FinCreateDate, long FinFinalCash_Non)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(FinCompany) ? "''" : "N'" + Regex.Replace(FinCompany, "'", "''") + "'") + ",");
    //            sb_value.Append(FinFinalCash + ",");
    //            sb_value.Append(FinSettleDate + ",");
    //            sb_value.Append(FinCreateDate + ",");
    //            sb_value.Append(FinFinalCash_Non);

    //            String sqlCmd = "insert into FinCashFlowFinal(FinCompany,FinFinalCash,FinSettleDate,FinCreateDate,FinFinalCash_Non) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int FinCashFlowFinalTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from FinCashFlowFinal where FinCashFlowFinalTID = " + FinCashFlowFinalTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String FinCompany, long FinFinalCash, long FinSettleDate, long FinCreateDate, long FinFinalCash_Non)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("FinCompany=" + (String.IsNullOrEmpty(FinCompany) ? "''" : "N'" + Regex.Replace(FinCompany, "'", "''") + "'") + ",");
    //            sb_value.Append("FinFinalCash =" + FinFinalCash + ",");
    //            sb_value.Append("FinSettleDate =" + FinSettleDate + ",");
    //            sb_value.Append("FinCreateDate =" + FinCreateDate + ",");
    //            sb_value.Append("FinFinalCash_Non =" + FinFinalCash_Non);

    //            String sqlCmd = "update FinCashFlowFinal set  " + sb_value.ToString() + "  where FinCashFlowFinalTID = " + this.FinCashFlowFinalTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.create() : " + e.ToString());
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
    //            sb_value.Append("FinCompany=" + (String.IsNullOrEmpty(this.FinCompany) ? "''" : "N'" + Regex.Replace(this.FinCompany, "'", "''") + "'") + ",");
    //            sb_value.Append("FinFinalCash =" + this.FinFinalCash + ",");
    //            sb_value.Append("FinSettleDate =" + this.FinSettleDate + ",");
    //            sb_value.Append("FinCreateDate =" + this.FinCreateDate + ",");
    //            sb_value.Append("FinFinalCash_Non =" + this.FinFinalCash_Non);

    //            String sqlCmd = "update FinCashFlowFinal set  " + sb_value.ToString() + "  where FinCashFlowFinalTID = " + this.FinCashFlowFinalTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "FinCashFlowFinal");
    //            if (ds.Tables["FinCashFlowFinal"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["FinCashFlowFinal"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowFinal.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


