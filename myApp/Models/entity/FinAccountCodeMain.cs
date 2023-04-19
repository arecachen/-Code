using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace hsintongERP2022.Models
{

    //public partial class FinAccountCodeMain
    //{
       
    //    public Collection<FinAccountCodeMain> findAll()
    //    {
    //        Collection<FinAccountCodeMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from FinAccountCodeMain order by FinAccountCodeMainTID asc", "FinAccountCodeMain");
    //            if (ds.Tables["FinAccountCodeMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<FinAccountCodeMain>();
    //                foreach (DataRow dr in ds.Tables["FinAccountCodeMain"].Rows)
    //                {
    //                    FinAccountCodeMain am = new FinAccountCodeMain();
    //                    am.FinAccCode = Convert.ToString(dr["FinAccCode"]);
    //                    am.FinAccName = Convert.ToString(dr["FinAccName"]);
    //                    am.FinAccDirection = Convert.ToString(dr["FinAccDirection"]);
    //                    am.FinAccOrder = Convert.ToInt32(dr["FinAccOrder"]);
    //                    am.FinAccountCodeMainTID = Convert.ToInt32(dr["FinAccountCodeMainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<FinAccountCodeMain> findByKeyword(String sqlCmd)
    //    {
    //        Collection<FinAccountCodeMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FinAccountCodeMain");
    //            if (ds.Tables["FinAccountCodeMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<FinAccountCodeMain>();
    //                foreach (DataRow dr in ds.Tables["FinAccountCodeMain"].Rows)
    //                {
    //                    FinAccountCodeMain am = new FinAccountCodeMain();
    //                    am.FinAccCode = Convert.ToString(dr["FinAccCode"]);
    //                    am.FinAccName = Convert.ToString(dr["FinAccName"]);
    //                    am.FinAccDirection = Convert.ToString(dr["FinAccDirection"]);
    //                    am.FinAccOrder = Convert.ToInt32(dr["FinAccOrder"]);
    //                    am.FinAccountCodeMainTID = Convert.ToInt32(dr["FinAccountCodeMainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public FinAccountCodeMain findByPrimaryKey(int FinAccountCodeMainTID)
    //    {
    //        FinAccountCodeMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM FinAccountCodeMain a WHERE a.FinAccountCodeMainTID = " + FinAccountCodeMainTID;
    //            DataSet ds = my.select(sqlCmd, "FinAccountCodeMain");
    //            if (ds.Tables["FinAccountCodeMain"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["FinAccountCodeMain"].Rows[0];
    //                am = new FinAccountCodeMain();
    //                am.FinAccCode = Convert.ToString(dr["FinAccCode"]);
    //                am.FinAccName = Convert.ToString(dr["FinAccName"]);
    //                am.FinAccDirection = Convert.ToString(dr["FinAccDirection"]);
    //                am.FinAccOrder = Convert.ToInt32(dr["FinAccOrder"]);
    //                am.FinAccountCodeMainTID = Convert.ToInt32(dr["FinAccountCodeMainTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String FinAccCode, String FinAccName, String FinAccDirection, int FinAccOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into FinAccountCodeMain(FinAccCode,FinAccName,FinAccDirection,FinAccOrder) values (N'" + FinAccCode + "',N'" + FinAccName + "',N'" + FinAccDirection + "'," + FinAccOrder + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int FinAccountCodeMainTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from FinAccountCodeMain where FinAccountCodeMainTID = " + FinAccountCodeMainTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String FinAccCode, String FinAccName, String FinAccDirection, int FinAccOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FinAccountCodeMain set FinAccCode =N'" + FinAccCode + "',FinAccName =N'" + FinAccName + "',FinAccDirection =N'" + FinAccDirection + "',FinAccOrder =" + FinAccOrder + " where FinAccountCodeMainTID = " + this.FinAccountCodeMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FinAccountCodeMain set FinAccCode =N'" + this.FinAccCode + "',FinAccName =N'" + this.FinAccName + "',FinAccDirection =N'" + this.FinAccDirection + "',FinAccOrder =" + this.FinAccOrder + " where FinAccountCodeMainTID = " + this.FinAccountCodeMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FinAccountCodeMain");
    //            if (ds.Tables["FinAccountCodeMain"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["FinAccountCodeMain"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinAccountCodeMain.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
  
}


