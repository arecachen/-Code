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
    //public partial class BaseInfoSaving
    //{

    //    public Collection<BaseInfoSaving> findAll()
    //    {
    //        Collection<BaseInfoSaving> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from BaseInfoSaving order by BaseInfoSavingTID asc", "BaseInfoSaving");
    //            if (ds.Tables["BaseInfoSaving"].Rows.Count > 0)
    //            {
    //                c = new Collection<BaseInfoSaving>();
    //                foreach (DataRow dr in ds.Tables["BaseInfoSaving"].Rows)
    //                {
    //                    BaseInfoSaving am = new BaseInfoSaving();
    //                    am.OrderCarJobBaseDate = dr["OrderCarJobBaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["OrderCarJobBaseDate"]);
    //                    am.BaseInfoSavingTID = Convert.ToInt32(dr["BaseInfoSavingTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<BaseInfoSaving> findByKeyword(String sqlCmd)
    //    {
    //        Collection<BaseInfoSaving> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "BaseInfoSaving");
    //            if (ds.Tables["BaseInfoSaving"].Rows.Count > 0)
    //            {
    //                c = new Collection<BaseInfoSaving>();
    //                foreach (DataRow dr in ds.Tables["BaseInfoSaving"].Rows)
    //                {
    //                    BaseInfoSaving am = new BaseInfoSaving();
    //                    am.OrderCarJobBaseDate = dr["OrderCarJobBaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["OrderCarJobBaseDate"]);
    //                    am.BaseInfoSavingTID = Convert.ToInt32(dr["BaseInfoSavingTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public BaseInfoSaving findByPrimaryKey(int BaseInfoSavingTID)
    //    {
    //        BaseInfoSaving am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM BaseInfoSaving a WHERE a.BaseInfoSavingTID = " + BaseInfoSavingTID;
    //            DataSet ds = my.select(sqlCmd, "BaseInfoSaving");
    //            if (ds.Tables["BaseInfoSaving"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["BaseInfoSaving"].Rows[0];
    //                am = new BaseInfoSaving();
    //                am.OrderCarJobBaseDate = dr["OrderCarJobBaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["OrderCarJobBaseDate"]);
    //                am.BaseInfoSavingTID = Convert.ToInt32(dr["BaseInfoSavingTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(long OrderCarJobBaseDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(OrderCarJobBaseDate);

    //            String sqlCmd = "insert into BaseInfoSaving(OrderCarJobBaseDate) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int BaseInfoSavingTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from BaseInfoSaving where BaseInfoSavingTID = " + BaseInfoSavingTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(long OrderCarJobBaseDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("OrderCarJobBaseDate =" + OrderCarJobBaseDate);

    //            String sqlCmd = "update BaseInfoSaving set  " + sb_value.ToString() + "  where BaseInfoSavingTID = " + this.BaseInfoSavingTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.create() : " + e.ToString());
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
    //            sb_value.Append("OrderCarJobBaseDate =" + this.OrderCarJobBaseDate);

    //            String sqlCmd = "update BaseInfoSaving set  " + sb_value.ToString() + "  where BaseInfoSavingTID = " + this.BaseInfoSavingTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "BaseInfoSaving");
    //            if (ds.Tables["BaseInfoSaving"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["BaseInfoSaving"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


