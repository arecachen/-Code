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
    //public partial class OrderCarFile
    //{

    //    public Collection<OrderCarFile> findAll()
    //    {
    //        Collection<OrderCarFile> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderCarFile order by OrderCarFileTID asc", "OrderCarFile");
    //            if (ds.Tables["OrderCarFile"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarFile>();
    //                foreach (DataRow dr in ds.Tables["OrderCarFile"].Rows)
    //                {
    //                    OrderCarFile am = new OrderCarFile();
    //                    am.RelName = Convert.ToString(dr["RelName"]);
    //                    am.SysName = Convert.ToString(dr["SysName"]);
    //                    am.OrderCarID = Convert.ToInt32(dr["OrderCarID"]);
    //                    am.OrderCarFileTID = Convert.ToInt32(dr["OrderCarFileTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarFile> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarFile> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarFile");
    //            if (ds.Tables["OrderCarFile"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarFile>();
    //                foreach (DataRow dr in ds.Tables["OrderCarFile"].Rows)
    //                {
    //                    OrderCarFile am = new OrderCarFile();
    //                    am.RelName = Convert.ToString(dr["RelName"]);
    //                    am.SysName = Convert.ToString(dr["SysName"]);
    //                    am.OrderCarID = Convert.ToInt32(dr["OrderCarID"]);
    //                    am.OrderCarFileTID = Convert.ToInt32(dr["OrderCarFileTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarFile findByPrimaryKey(int OrderCarFileTID)
    //    {
    //        OrderCarFile am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderCarFile a WHERE a.OrderCarFileTID = " + OrderCarFileTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarFile");
    //            if (ds.Tables["OrderCarFile"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarFile"].Rows[0];
    //                am = new OrderCarFile();
    //                am.RelName = Convert.ToString(dr["RelName"]);
    //                am.SysName = Convert.ToString(dr["SysName"]);
    //                am.OrderCarID = Convert.ToInt32(dr["OrderCarID"]);
    //                am.OrderCarFileTID = Convert.ToInt32(dr["OrderCarFileTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String RelName, String SysName, int OrderCarID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarFile(RelName,SysName,OrderCarID) values ('" + RelName + "','" + SysName + "'," + OrderCarID + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarFileTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderCarFile where OrderCarFileTID = " + OrderCarFileTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String RelName, String SysName, int OrderCarID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarFile set RelName ='" + RelName + "',SysName ='" + SysName + "',OrderCarID =" + OrderCarID + " where OrderCarFileTID = " + this.OrderCarFileTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarFile set RelName ='" + this.RelName + "',SysName ='" + this.SysName + "',OrderCarID =" + this.OrderCarID + " where OrderCarFileTID = " + this.OrderCarFileTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarFile");
    //            if (ds.Tables["OrderCarFile"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarFile"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarFile.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


