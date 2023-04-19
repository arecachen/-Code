using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
namespace hsintongERP2022.Models
{
    //public partial class SystemMemo
    //{

    //    public Collection<SystemMemo> findAll()
    //    {
    //        Collection<SystemMemo> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from SystemMemo order by systemMemoTID asc", "SystemMemo");
    //            if (ds.Tables["SystemMemo"].Rows.Count > 0)
    //            {
    //                c = new Collection<SystemMemo>();
    //                foreach (DataRow dr in ds.Tables["SystemMemo"].Rows)
    //                {
    //                    SystemMemo am = new SystemMemo();
    //                    am.systemMemoTID = Convert.ToInt32(dr["systemMemoTID"]);
    //                    am.joMemo = Convert.ToString(dr["joMemo"]);
    //                    am.salaryMemo = Convert.ToString(dr["salaryMemo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<SystemMemo> findByKeyword(String sqlCmd)
    //    {
    //        Collection<SystemMemo> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "SystemMemo");
    //            if (ds.Tables["SystemMemo"].Rows.Count > 0)
    //            {
    //                c = new Collection<SystemMemo>();
    //                foreach (DataRow dr in ds.Tables["SystemMemo"].Rows)
    //                {
    //                    SystemMemo am = new SystemMemo();
    //                    am.systemMemoTID = Convert.ToInt32(dr["systemMemoTID"]);
    //                    am.joMemo = Convert.ToString(dr["joMemo"]);
    //                    am.salaryMemo = Convert.ToString(dr["salaryMemo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public SystemMemo findByPrimaryKey(int systemMemoTID)
    //    {
    //        SystemMemo am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM SystemMemo a WHERE a.systemMemoTID = " + systemMemoTID;
    //            DataSet ds = my.select(sqlCmd, "SystemMemo");
    //            if (ds.Tables["SystemMemo"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["SystemMemo"].Rows[0];
    //                am = new SystemMemo();
    //                am.systemMemoTID = Convert.ToInt32(dr["systemMemoTID"]);
    //                am.joMemo = Convert.ToString(dr["joMemo"]);
    //                am.salaryMemo = Convert.ToString(dr["salaryMemo"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String joMemo, String salaryMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into SystemMemo(joMemo,salaryMemo) values ('" + joMemo + "','" + salaryMemo + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int systemMemoTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from SystemMemo where systemMemoTID = " + systemMemoTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String joMemo, String salaryMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update SystemMemo set joMemo ='" + joMemo + "',salaryMemo ='" + salaryMemo + "' where systemMemoTID = " + this.systemMemoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update SystemMemo set joMemo ='" + this.joMemo + "',salaryMemo ='" + this.salaryMemo + "' where systemMemoTID = " + this.systemMemoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "SystemMemo");
    //            if (ds.Tables["SystemMemo"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["SystemMemo"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMemo.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


