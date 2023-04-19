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
    //public partial class VehMantaince
    //{

    //    public Collection<VehMantaince> findAll()
    //    {
    //        Collection<VehMantaince> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from VehMantaince order by vehMaintainceTID asc", "VehMantaince");
    //            if (ds.Tables["VehMantaince"].Rows.Count > 0)
    //            {
    //                c = new Collection<VehMantaince>();
    //                foreach (DataRow dr in ds.Tables["VehMantaince"].Rows)
    //                {
    //                    VehMantaince am = new VehMantaince();
    //                    am.vehMaintainceTID = Convert.ToInt32(dr["vehMaintainceTID"]);
    //                    am.vehMtItem = Convert.ToString(dr["vehMtItem"]);
    //                    am.vehMtMemo = Convert.ToString(dr["vehMtMemo"]);
    //                    am.vehMtByMile = dr["vehMtByMile"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByMile"]);
    //                    am.vehMtByMileRange = dr["vehMtByMileRange"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByMileRange"]);
    //                    am.vehMtByDate = dr["vehMtByDate"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByDate"]);
    //                    am.vehMtByDateRangeDays = dr["vehMtByDateRangeDays"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByDateRangeDays"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<VehMantaince> findByKeyword(String sqlCmd)
    //    {
    //        Collection<VehMantaince> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "VehMantaince");
    //            if (ds.Tables["VehMantaince"].Rows.Count > 0)
    //            {
    //                c = new Collection<VehMantaince>();
    //                foreach (DataRow dr in ds.Tables["VehMantaince"].Rows)
    //                {
    //                    VehMantaince am = new VehMantaince();
    //                    am.vehMaintainceTID = Convert.ToInt32(dr["vehMaintainceTID"]);
    //                    am.vehMtItem = Convert.ToString(dr["vehMtItem"]);
    //                    am.vehMtMemo = Convert.ToString(dr["vehMtMemo"]);
    //                    am.vehMtByMile = dr["vehMtByMile"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByMile"]);
    //                    am.vehMtByMileRange = dr["vehMtByMileRange"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByMileRange"]);
    //                    am.vehMtByDate = dr["vehMtByDate"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByDate"]);
    //                    am.vehMtByDateRangeDays = dr["vehMtByDateRangeDays"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByDateRangeDays"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public VehMantaince findByPrimaryKey(int vehMaintainceTID)
    //    {
    //        VehMantaince am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM VehMantaince a WHERE a.vehMaintainceTID = " + vehMaintainceTID;
    //            DataSet ds = my.select(sqlCmd, "VehMantaince");
    //            if (ds.Tables["VehMantaince"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["VehMantaince"].Rows[0];
    //                am = new VehMantaince();
    //                am.vehMaintainceTID = Convert.ToInt32(dr["vehMaintainceTID"]);
    //                am.vehMtItem = Convert.ToString(dr["vehMtItem"]);
    //                am.vehMtMemo = Convert.ToString(dr["vehMtMemo"]);
    //                am.vehMtByMile = dr["vehMtByMile"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByMile"]);
    //                am.vehMtByMileRange = dr["vehMtByMileRange"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByMileRange"]);
    //                am.vehMtByDate = dr["vehMtByDate"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByDate"]);
    //                am.vehMtByDateRangeDays = dr["vehMtByDateRangeDays"] == DBNull.Value ? -999 : Convert.ToInt32(dr["vehMtByDateRangeDays"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String vehMtItem, String vehMtMemo, int vehMtByMile, int vehMtByMileRange, int vehMtByDate, int vehMtByDateRangeDays)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into VehMantaince(vehMtItem,vehMtMemo,vehMtByMile,vehMtByMileRange,vehMtByDate,vehMtByDateRangeDays) values ('" + vehMtItem + "','" + vehMtMemo + "'," + vehMtByMile + "," + vehMtByMileRange + "," + vehMtByDate + "," + vehMtByDateRangeDays + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int vehMaintainceTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from VehMantaince where vehMaintainceTID = " + vehMaintainceTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String vehMtItem, String vehMtMemo, int vehMtByMile, int vehMtByMileRange, int vehMtByDate, int vehMtByDateRangeDays)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update VehMantaince set vehMtItem ='" + vehMtItem + "',vehMtMemo ='" + vehMtMemo + "',vehMtByMile =" + vehMtByMile + ",vehMtByMileRange =" + vehMtByMileRange + ",vehMtByDate =" + vehMtByDate + ",vehMtByDateRangeDays =" + vehMtByDateRangeDays + " where vehMaintainceTID = " + this.vehMaintainceTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update VehMantaince set vehMtItem ='" + this.vehMtItem + "',vehMtMemo ='" + this.vehMtMemo + "',vehMtByMile =" + this.vehMtByMile + ",vehMtByMileRange =" + this.vehMtByMileRange + ",vehMtByDate =" + this.vehMtByDate + ",vehMtByDateRangeDays =" + this.vehMtByDateRangeDays + " where vehMaintainceTID = " + this.vehMaintainceTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "VehMantaince");
    //            if (ds.Tables["VehMantaince"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["VehMantaince"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.VehMantaince.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


