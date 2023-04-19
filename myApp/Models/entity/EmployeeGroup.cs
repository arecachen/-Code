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
    //public partial class EmployeeGroup
    //{
    //    //public String EG_Title { get; set; } //不可空值,群組名稱 
    //    //public String EG_Status { get; set; } //不可空值,狀態, 啟用:Active、停用:Inactive 
    //    //public int EmployeeGroupTID { get; set; } //不可空值, 
    //    public Collection<EmployeeGroup> findAll()
    //    {
    //        Collection<EmployeeGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from EmployeeGroup order by EmployeeGroupTID asc", "EmployeeGroup");
    //            if (ds.Tables["EmployeeGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeGroup>();
    //                foreach (DataRow dr in ds.Tables["EmployeeGroup"].Rows)
    //                {
    //                    EmployeeGroup am = new EmployeeGroup();
    //                    am.EG_Title = Convert.ToString(dr["EG_Title"]);
    //                    am.EG_Status = Convert.ToString(dr["EG_Status"]);
    //                    am.EmployeeGroupTID = Convert.ToInt32(dr["EmployeeGroupTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeGroup> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeGroup");
    //            if (ds.Tables["EmployeeGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeGroup>();
    //                foreach (DataRow dr in ds.Tables["EmployeeGroup"].Rows)
    //                {
    //                    EmployeeGroup am = new EmployeeGroup();
    //                    am.EG_Title = Convert.ToString(dr["EG_Title"]);
    //                    am.EG_Status = Convert.ToString(dr["EG_Status"]);
    //                    am.EmployeeGroupTID = Convert.ToInt32(dr["EmployeeGroupTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeGroup findByPrimaryKey(int EmployeeGroupTID)
    //    {
    //        EmployeeGroup am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM EmployeeGroup a WHERE a.EmployeeGroupTID = " + EmployeeGroupTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeGroup");
    //            if (ds.Tables["EmployeeGroup"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeGroup"].Rows[0];
    //                am = new EmployeeGroup();
    //                am.EG_Title = Convert.ToString(dr["EG_Title"]);
    //                am.EG_Status = Convert.ToString(dr["EG_Status"]);
    //                am.EmployeeGroupTID = Convert.ToInt32(dr["EmployeeGroupTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String EG_Title, String EG_Status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(EG_Title) ? "''" : "N'" + Regex.Replace(EG_Title, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(EG_Status) ? "''" : "N'" + Regex.Replace(EG_Status, "'", "''") + "'"));

    //            String sqlCmd = "insert into EmployeeGroup(EG_Title,EG_Status) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int EmployeeGroupTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from EmployeeGroup where EmployeeGroupTID = " + EmployeeGroupTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String EG_Title, String EG_Status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("EG_Title=" + (String.IsNullOrEmpty(EG_Title) ? "''" : "N'" + Regex.Replace(EG_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("EG_Status=" + (String.IsNullOrEmpty(EG_Status) ? "''" : "N'" + Regex.Replace(EG_Status, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeeGroup set  " + sb_value.ToString() + "  where EmployeeGroupTID = " + this.EmployeeGroupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.create() : " + e.ToString());
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
    //            sb_value.Append("EG_Title=" + (String.IsNullOrEmpty(this.EG_Title) ? "''" : "N'" + Regex.Replace(this.EG_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("EG_Status=" + (String.IsNullOrEmpty(this.EG_Status) ? "''" : "N'" + Regex.Replace(this.EG_Status, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeeGroup set  " + sb_value.ToString() + "  where EmployeeGroupTID = " + this.EmployeeGroupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeGroup");
    //            if (ds.Tables["EmployeeGroup"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeGroup"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeGroup.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


