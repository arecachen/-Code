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
    //public partial class StatusTable
    //{
       
    //    public Collection<StatusTable> findAll()
    //    {
    //        Collection<StatusTable> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from StatusTable order by statusTID asc", "StatusTable");
    //            if (ds.Tables["StatusTable"].Rows.Count > 0)
    //            {
    //                c = new Collection<StatusTable>();
    //                foreach (DataRow dr in ds.Tables["StatusTable"].Rows)
    //                {
    //                    StatusTable am = new StatusTable();
    //                    am.statusTID = Convert.ToInt32(dr["statusTID"]);
    //                    am.statusGroup = Convert.ToString(dr["statusGroup"]);
    //                    am.statusValue = Convert.ToString(dr["statusValue"]);
    //                    am.statusText = Convert.ToString(dr["statusText"]);
    //                    am.statusOrder = Convert.ToInt32(dr["statusOrder"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<StatusTable> findByKeyword(String sqlCmd)
    //    {
    //        Collection<StatusTable> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "StatusTable");
    //            if (ds.Tables["StatusTable"].Rows.Count > 0)
    //            {
    //                c = new Collection<StatusTable>();
    //                foreach (DataRow dr in ds.Tables["StatusTable"].Rows)
    //                {
    //                    StatusTable am = new StatusTable();
    //                    am.statusTID = Convert.ToInt32(dr["statusTID"]);
    //                    am.statusGroup = Convert.ToString(dr["statusGroup"]);
    //                    am.statusValue = Convert.ToString(dr["statusValue"]);
    //                    am.statusText = Convert.ToString(dr["statusText"]);
    //                    am.statusOrder = Convert.ToInt32(dr["statusOrder"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public StatusTable findByPrimaryKey(int statusTID)
    //    {
    //        StatusTable am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM StatusTable a WHERE a.statusTID = " + statusTID;
    //            DataSet ds = my.select(sqlCmd, "StatusTable");
    //            if (ds.Tables["StatusTable"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["StatusTable"].Rows[0];
    //                am = new StatusTable();
    //                am.statusTID = Convert.ToInt32(dr["statusTID"]);
    //                am.statusGroup = Convert.ToString(dr["statusGroup"]);
    //                am.statusValue = Convert.ToString(dr["statusValue"]);
    //                am.statusText = Convert.ToString(dr["statusText"]);
    //                am.statusOrder = Convert.ToInt32(dr["statusOrder"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String statusGroup, String statusValue, String statusText, int statusOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into StatusTable(statusGroup,statusValue,statusText,statusOrder) values ('" + statusGroup + "','" + statusValue + "','" + statusText + "'," + statusOrder + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int statusTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from StatusTable where statusTID = " + statusTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String statusGroup, String statusValue, String statusText, int statusOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update StatusTable set statusGroup ='" + statusGroup + "',statusValue ='" + statusValue + "',statusText ='" + statusText + "',statusOrder =" + statusOrder + " where statusTID = " + this.statusTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update StatusTable set statusGroup ='" + this.statusGroup + "',statusValue ='" + this.statusValue + "',statusText ='" + this.statusText + "',statusOrder =" + this.statusOrder + " where statusTID = " + this.statusTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "StatusTable");
    //            if (ds.Tables["StatusTable"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["StatusTable"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.StatusTable.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


