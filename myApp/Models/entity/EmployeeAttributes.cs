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
    //public partial class EmployeeAttributes
    //{
    //    //public String EA_Title { get; set; } //不可空值,屬性名稱 
    //    //public String EA_Status { get; set; } //不可空值,狀態, 啟用:Active、停用:Inactive 
    //    //public int EmployeeAttributesTID { get; set; } //不可空值, 
    //    public Collection<EmployeeAttributes> findAll()
    //    {
    //        Collection<EmployeeAttributes> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from EmployeeAttributes order by EmployeeAttributesTID asc", "EmployeeAttributes");
    //            if (ds.Tables["EmployeeAttributes"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeAttributes>();
    //                foreach (DataRow dr in ds.Tables["EmployeeAttributes"].Rows)
    //                {
    //                    EmployeeAttributes am = new EmployeeAttributes();
    //                    am.EA_Title = Convert.ToString(dr["EA_Title"]);
    //                    am.EA_Status = Convert.ToString(dr["EA_Status"]);
    //                    am.EmployeeAttributesTID = Convert.ToInt32(dr["EmployeeAttributesTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeAttributes> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeAttributes> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeAttributes");
    //            if (ds.Tables["EmployeeAttributes"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeAttributes>();
    //                foreach (DataRow dr in ds.Tables["EmployeeAttributes"].Rows)
    //                {
    //                    EmployeeAttributes am = new EmployeeAttributes();
    //                    am.EA_Title = Convert.ToString(dr["EA_Title"]);
    //                    am.EA_Status = Convert.ToString(dr["EA_Status"]);
    //                    am.EmployeeAttributesTID = Convert.ToInt32(dr["EmployeeAttributesTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeAttributes findByPrimaryKey(int EmployeeAttributesTID)
    //    {
    //        EmployeeAttributes am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM EmployeeAttributes a WHERE a.EmployeeAttributesTID = " + EmployeeAttributesTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeAttributes");
    //            if (ds.Tables["EmployeeAttributes"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeAttributes"].Rows[0];
    //                am = new EmployeeAttributes();
    //                am.EA_Title = Convert.ToString(dr["EA_Title"]);
    //                am.EA_Status = Convert.ToString(dr["EA_Status"]);
    //                am.EmployeeAttributesTID = Convert.ToInt32(dr["EmployeeAttributesTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String EA_Title, String EA_Status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(EA_Title) ? "''" : "N'" + Regex.Replace(EA_Title, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(EA_Status) ? "''" : "N'" + Regex.Replace(EA_Status, "'", "''") + "'"));

    //            String sqlCmd = "insert into EmployeeAttributes(EA_Title,EA_Status) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int EmployeeAttributesTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from EmployeeAttributes where EmployeeAttributesTID = " + EmployeeAttributesTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String EA_Title, String EA_Status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("EA_Title=" + (String.IsNullOrEmpty(EA_Title) ? "''" : "N'" + Regex.Replace(EA_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("EA_Status=" + (String.IsNullOrEmpty(EA_Status) ? "''" : "N'" + Regex.Replace(EA_Status, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeeAttributes set  " + sb_value.ToString() + "  where EmployeeAttributesTID = " + this.EmployeeAttributesTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.create() : " + e.ToString());
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
    //            sb_value.Append("EA_Title=" + (String.IsNullOrEmpty(this.EA_Title) ? "''" : "N'" + Regex.Replace(this.EA_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("EA_Status=" + (String.IsNullOrEmpty(this.EA_Status) ? "''" : "N'" + Regex.Replace(this.EA_Status, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeeAttributes set  " + sb_value.ToString() + "  where EmployeeAttributesTID = " + this.EmployeeAttributesTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeAttributes");
    //            if (ds.Tables["EmployeeAttributes"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeAttributes"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributes.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


