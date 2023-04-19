using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{


    //public partial class CompanyCalendar
    //{
  
    //    #region sql
    //    public Collection<CompanyCalendar> findAll()
    //    {
    //        Collection<CompanyCalendar> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CompanyCalendar order by CompanyCalendarTID asc", "CompanyCalendar");
    //            if (ds.Tables["CompanyCalendar"].Rows.Count > 0)
    //            {
    //                c = new Collection<CompanyCalendar>();
    //                foreach (DataRow dr in ds.Tables["CompanyCalendar"].Rows)
    //                {
    //                    CompanyCalendar am = new CompanyCalendar();
    //                    am.CCalendarEventCat = Convert.ToString(dr["CCalendarEventCat"]);
    //                    am.CCalendarStartDateTime = Convert.ToInt64(dr["CCalendarStartDateTime"]);
    //                    am.CCalendarEndDateTime = Convert.ToInt64(dr["CCalendarEndDateTime"]);
    //                    am.CCalendarMemo = Convert.ToString(dr["CCalendarMemo"]);
    //                    am.CCalendarStatus = Convert.ToString(dr["CCalendarStatus"]);
    //                    am.CompanyCalendarTID = Convert.ToInt32(dr["CompanyCalendarTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CompanyCalendar> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CompanyCalendar> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CompanyCalendar");
    //            if (ds.Tables["CompanyCalendar"].Rows.Count > 0)
    //            {
    //                c = new Collection<CompanyCalendar>();
    //                foreach (DataRow dr in ds.Tables["CompanyCalendar"].Rows)
    //                {
    //                    CompanyCalendar am = new CompanyCalendar();
    //                    am.CCalendarEventCat = Convert.ToString(dr["CCalendarEventCat"]);
    //                    am.CCalendarStartDateTime = Convert.ToInt64(dr["CCalendarStartDateTime"]);
    //                    am.CCalendarEndDateTime = Convert.ToInt64(dr["CCalendarEndDateTime"]);
    //                    am.CCalendarMemo = Convert.ToString(dr["CCalendarMemo"]);
    //                    am.CCalendarStatus = Convert.ToString(dr["CCalendarStatus"]);
    //                    am.CompanyCalendarTID = Convert.ToInt32(dr["CompanyCalendarTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CompanyCalendar findByPrimaryKey(int CompanyCalendarTID)
    //    {
    //        CompanyCalendar am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CompanyCalendar a WHERE a.CompanyCalendarTID = " + CompanyCalendarTID;
    //            DataSet ds = my.select(sqlCmd, "CompanyCalendar");
    //            if (ds.Tables["CompanyCalendar"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CompanyCalendar"].Rows[0];
    //                am = new CompanyCalendar();
    //                am.CCalendarEventCat = Convert.ToString(dr["CCalendarEventCat"]);
    //                am.CCalendarStartDateTime = Convert.ToInt64(dr["CCalendarStartDateTime"]);
    //                am.CCalendarEndDateTime = Convert.ToInt64(dr["CCalendarEndDateTime"]);
    //                am.CCalendarMemo = Convert.ToString(dr["CCalendarMemo"]);
    //                am.CCalendarStatus = Convert.ToString(dr["CCalendarStatus"]);
    //                am.CompanyCalendarTID = Convert.ToInt32(dr["CompanyCalendarTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String CCalendarEventCat, long CCalendarStartDateTime, long CCalendarEndDateTime, String CCalendarMemo, String CCalendarStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(CCalendarEventCat) ? "''" : "N'" + Regex.Replace(CCalendarEventCat, "'", "''") + "'") + ",");
    //            sb_value.Append(CCalendarStartDateTime + ",");
    //            sb_value.Append(CCalendarEndDateTime + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CCalendarMemo) ? "null" : "N'" + Regex.Replace(CCalendarMemo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CCalendarStatus) ? "''" : "N'" + Regex.Replace(CCalendarStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into CompanyCalendar(CCalendarEventCat,CCalendarStartDateTime,CCalendarEndDateTime,CCalendarMemo,CCalendarStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int CompanyCalendarTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CompanyCalendar where CompanyCalendarTID = " + CompanyCalendarTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String CCalendarEventCat, long CCalendarStartDateTime, long CCalendarEndDateTime, String CCalendarMemo, String CCalendarStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("CCalendarEventCat=" + (String.IsNullOrEmpty(CCalendarEventCat) ? "''" : "N'" + Regex.Replace(CCalendarEventCat, "'", "''") + "'") + ",");
    //            sb_value.Append("CCalendarStartDateTime =" + CCalendarStartDateTime + ",");
    //            sb_value.Append("CCalendarEndDateTime =" + CCalendarEndDateTime + ",");
    //            sb_value.Append("CCalendarMemo=" + (String.IsNullOrEmpty(CCalendarMemo) ? "null" : "N'" + Regex.Replace(CCalendarMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("CCalendarStatus=" + (String.IsNullOrEmpty(CCalendarStatus) ? "''" : "N'" + Regex.Replace(CCalendarStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CompanyCalendar set  " + sb_value.ToString() + "  where CompanyCalendarTID = " + this.CompanyCalendarTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.create() : " + e.ToString());
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
    //            sb_value.Append("CCalendarEventCat=" + (String.IsNullOrEmpty(this.CCalendarEventCat) ? "''" : "N'" + Regex.Replace(this.CCalendarEventCat, "'", "''") + "'") + ",");
    //            sb_value.Append("CCalendarStartDateTime =" + this.CCalendarStartDateTime + ",");
    //            sb_value.Append("CCalendarEndDateTime =" + this.CCalendarEndDateTime + ",");
    //            sb_value.Append("CCalendarMemo=" + (String.IsNullOrEmpty(this.CCalendarMemo) ? "null" : "N'" + Regex.Replace(this.CCalendarMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("CCalendarStatus=" + (String.IsNullOrEmpty(this.CCalendarStatus) ? "''" : "N'" + Regex.Replace(this.CCalendarStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CompanyCalendar set  " + sb_value.ToString() + "  where CompanyCalendarTID = " + this.CompanyCalendarTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CompanyCalendar");
    //            if (ds.Tables["CompanyCalendar"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CompanyCalendar"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CompanyCalendar.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }

    //    #endregion sql
    //}
}


