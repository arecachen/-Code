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
    //public partial class EmployeeDepartment
    //{
    //    //public String ED_Title { get; set; } //不可空值,部門名稱 
    //    //public String ED_Status { get; set; } //不可空值,狀態, 啟用:Active、停用:Inactive 
    //    //public int EmployeeDepartmentTID { get; set; } //不可空值, 
    //    public Collection<EmployeeDepartment> findAll()
    //    {
    //        Collection<EmployeeDepartment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from EmployeeDepartment order by EmployeeDepartmentTID asc", "EmployeeDepartment");
    //            if (ds.Tables["EmployeeDepartment"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeDepartment>();
    //                foreach (DataRow dr in ds.Tables["EmployeeDepartment"].Rows)
    //                {
    //                    EmployeeDepartment am = new EmployeeDepartment();
    //                    am.ED_Title = Convert.ToString(dr["ED_Title"]);
    //                    am.ED_Status = Convert.ToString(dr["ED_Status"]);
    //                    am.EmployeeDepartmentTID = Convert.ToInt32(dr["EmployeeDepartmentTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeDepartment> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeDepartment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeDepartment");
    //            if (ds.Tables["EmployeeDepartment"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeDepartment>();
    //                foreach (DataRow dr in ds.Tables["EmployeeDepartment"].Rows)
    //                {
    //                    EmployeeDepartment am = new EmployeeDepartment();
    //                    am.ED_Title = Convert.ToString(dr["ED_Title"]);
    //                    am.ED_Status = Convert.ToString(dr["ED_Status"]);
    //                    am.EmployeeDepartmentTID = Convert.ToInt32(dr["EmployeeDepartmentTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeDepartment findByPrimaryKey(int EmployeeDepartmentTID)
    //    {
    //        EmployeeDepartment am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM EmployeeDepartment a WHERE a.EmployeeDepartmentTID = " + EmployeeDepartmentTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeDepartment");
    //            if (ds.Tables["EmployeeDepartment"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeDepartment"].Rows[0];
    //                am = new EmployeeDepartment();
    //                am.ED_Title = Convert.ToString(dr["ED_Title"]);
    //                am.ED_Status = Convert.ToString(dr["ED_Status"]);
    //                am.EmployeeDepartmentTID = Convert.ToInt32(dr["EmployeeDepartmentTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String ED_Title, String ED_Status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(ED_Title) ? "''" : "N'" + Regex.Replace(ED_Title, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(ED_Status) ? "''" : "N'" + Regex.Replace(ED_Status, "'", "''") + "'"));

    //            String sqlCmd = "insert into EmployeeDepartment(ED_Title,ED_Status) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int EmployeeDepartmentTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from EmployeeDepartment where EmployeeDepartmentTID = " + EmployeeDepartmentTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String ED_Title, String ED_Status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("ED_Title=" + (String.IsNullOrEmpty(ED_Title) ? "''" : "N'" + Regex.Replace(ED_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("ED_Status=" + (String.IsNullOrEmpty(ED_Status) ? "''" : "N'" + Regex.Replace(ED_Status, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeeDepartment set  " + sb_value.ToString() + "  where EmployeeDepartmentTID = " + this.EmployeeDepartmentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.create() : " + e.ToString());
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
    //            sb_value.Append("ED_Title=" + (String.IsNullOrEmpty(this.ED_Title) ? "''" : "N'" + Regex.Replace(this.ED_Title, "'", "''") + "'") + ",");
    //            sb_value.Append("ED_Status=" + (String.IsNullOrEmpty(this.ED_Status) ? "''" : "N'" + Regex.Replace(this.ED_Status, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeeDepartment set  " + sb_value.ToString() + "  where EmployeeDepartmentTID = " + this.EmployeeDepartmentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeDepartment");
    //            if (ds.Tables["EmployeeDepartment"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeDepartment"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeDepartment.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


