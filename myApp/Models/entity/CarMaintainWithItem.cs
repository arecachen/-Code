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
    //public partial class CarMaintainWithItem
    //{
 
    //    public Collection<CarMaintainWithItem> findAll()
    //    {
    //        Collection<CarMaintainWithItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CarMaintainWithItem order by carMaintainWithItemTID asc", "CarMaintainWithItem");
    //            if (ds.Tables["CarMaintainWithItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMaintainWithItem>();
    //                foreach (DataRow dr in ds.Tables["CarMaintainWithItem"].Rows)
    //                {
    //                    CarMaintainWithItem am = new CarMaintainWithItem();
    //                    am.carMaintainID = Convert.ToInt32(dr["carMaintainID"]);
    //                    am.carMaintainItemID = Convert.ToInt32(dr["carMaintainItemID"]);
    //                    am.mtnStatus = Convert.ToString(dr["mtnStatus"]);
    //                    am.mtnFaultyDesc = Convert.ToString(dr["mtnFaultyDesc"]);
    //                    am.mtnResolve = Convert.ToInt32(dr["mtnResolve"]);
    //                    am.mtnCost = Convert.ToInt32(dr["mtnCost"]);
    //                    am.mtnShowOnReport = Convert.ToInt32(dr["mtnShowOnReport"]);
    //                    am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                    am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                    am.mtnChecked = dr["mtnChecked"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnChecked"]);
    //                    am.mtnResolveCheck = dr["mtnResolveCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnResolveCheck"]);
    //                    am.carMaintainWithItemTID = Convert.ToInt32(dr["carMaintainWithItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarMaintainWithItem> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarMaintainWithItem> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarMaintainWithItem");
    //            if (ds.Tables["CarMaintainWithItem"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMaintainWithItem>();
    //                foreach (DataRow dr in ds.Tables["CarMaintainWithItem"].Rows)
    //                {
    //                    CarMaintainWithItem am = new CarMaintainWithItem();
    //                    am.carMaintainID = Convert.ToInt32(dr["carMaintainID"]);
    //                    am.carMaintainItemID = Convert.ToInt32(dr["carMaintainItemID"]);
    //                    am.mtnStatus = Convert.ToString(dr["mtnStatus"]);
    //                    am.mtnFaultyDesc = Convert.ToString(dr["mtnFaultyDesc"]);
    //                    am.mtnResolve = Convert.ToInt32(dr["mtnResolve"]);
    //                    am.mtnCost = Convert.ToInt32(dr["mtnCost"]);
    //                    am.mtnShowOnReport = Convert.ToInt32(dr["mtnShowOnReport"]);
    //                    am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                    am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                    am.mtnChecked = dr["mtnChecked"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnChecked"]);
    //                    am.mtnResolveCheck = dr["mtnResolveCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnResolveCheck"]);
    //                    am.carMaintainWithItemTID = Convert.ToInt32(dr["carMaintainWithItemTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarMaintainWithItem findByPrimaryKey(int carMaintainWithItemTID)
    //    {
    //        CarMaintainWithItem am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CarMaintainWithItem a WHERE a.carMaintainWithItemTID = " + carMaintainWithItemTID;
    //            DataSet ds = my.select(sqlCmd, "CarMaintainWithItem");
    //            if (ds.Tables["CarMaintainWithItem"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarMaintainWithItem"].Rows[0];
    //                am = new CarMaintainWithItem();
    //                am.carMaintainID = Convert.ToInt32(dr["carMaintainID"]);
    //                am.carMaintainItemID = Convert.ToInt32(dr["carMaintainItemID"]);
    //                am.mtnStatus = Convert.ToString(dr["mtnStatus"]);
    //                am.mtnFaultyDesc = Convert.ToString(dr["mtnFaultyDesc"]);
    //                am.mtnResolve = Convert.ToInt32(dr["mtnResolve"]);
    //                am.mtnCost = Convert.ToInt32(dr["mtnCost"]);
    //                am.mtnShowOnReport = Convert.ToInt32(dr["mtnShowOnReport"]);
    //                am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                am.mtnChecked = dr["mtnChecked"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnChecked"]);
    //                am.mtnResolveCheck = dr["mtnResolveCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnResolveCheck"]);
    //                am.carMaintainWithItemTID = Convert.ToInt32(dr["carMaintainWithItemTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int carMaintainID, int carMaintainItemID, String mtnStatus, String mtnFaultyDesc, int mtnResolve, double mtnCost, int mtnShowOnReport, double nextCheckMile, long nextCheckDate, int mtnChecked, int mtnResolveCheck)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(carMaintainID + ",");
    //            sb_value.Append(carMaintainItemID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(mtnStatus) ? "''" : "N'" + Regex.Replace(mtnStatus, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(mtnFaultyDesc) ? "null" : "N'" + Regex.Replace(mtnFaultyDesc, "'", "''") + "'") + ",");
    //            sb_value.Append(mtnResolve + ",");
    //            sb_value.Append(mtnCost + ",");
    //            sb_value.Append(mtnShowOnReport + ",");
    //            sb_value.Append(nextCheckMile + ",");
    //            sb_value.Append(nextCheckDate + ",");
    //            sb_value.Append(mtnChecked + ",");
    //            sb_value.Append(mtnResolveCheck);

    //            String sqlCmd = "insert into CarMaintainWithItem(carMaintainID,carMaintainItemID,mtnStatus,mtnFaultyDesc,mtnResolve,mtnCost,mtnShowOnReport,nextCheckMile,nextCheckDate,mtnChecked,mtnResolveCheck) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carMaintainWithItemTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CarMaintainWithItem where carMaintainWithItemTID = " + carMaintainWithItemTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int carMaintainID, int carMaintainItemID, String mtnStatus, String mtnFaultyDesc, int mtnResolve, double mtnCost, int mtnShowOnReport, double nextCheckMile, long nextCheckDate, int mtnChecked, int mtnResolveCheck)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("carMaintainID =" + carMaintainID + ",");
    //            sb_value.Append("carMaintainItemID =" + carMaintainItemID + ",");
    //            sb_value.Append("mtnStatus=" + (String.IsNullOrEmpty(mtnStatus) ? "''" : "N'" + Regex.Replace(mtnStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnFaultyDesc=" + (String.IsNullOrEmpty(mtnFaultyDesc) ? "null" : "N'" + Regex.Replace(mtnFaultyDesc, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnResolve =" + mtnResolve + ",");
    //            sb_value.Append("mtnCost =" + mtnCost + ",");
    //            sb_value.Append("mtnShowOnReport =" + mtnShowOnReport + ",");
    //            sb_value.Append("nextCheckMile =" + nextCheckMile + ",");
    //            sb_value.Append("nextCheckDate =" + nextCheckDate + ",");
    //            sb_value.Append("mtnChecked =" + mtnChecked + ",");
    //            sb_value.Append("mtnResolveCheck =" + mtnResolveCheck);

    //            String sqlCmd = "update CarMaintainWithItem set  " + sb_value.ToString() + "  where carMaintainWithItemTID = " + this.carMaintainWithItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.create() : " + e.ToString());
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
    //            sb_value.Append("carMaintainID =" + this.carMaintainID + ",");
    //            sb_value.Append("carMaintainItemID =" + this.carMaintainItemID + ",");
    //            sb_value.Append("mtnStatus=" + (String.IsNullOrEmpty(this.mtnStatus) ? "''" : "N'" + Regex.Replace(this.mtnStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnFaultyDesc=" + (String.IsNullOrEmpty(this.mtnFaultyDesc) ? "null" : "N'" + Regex.Replace(this.mtnFaultyDesc, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnResolve =" + this.mtnResolve + ",");
    //            sb_value.Append("mtnCost =" + this.mtnCost + ",");
    //            sb_value.Append("mtnShowOnReport =" + this.mtnShowOnReport + ",");
    //            sb_value.Append("nextCheckMile =" + this.nextCheckMile + ",");
    //            sb_value.Append("nextCheckDate =" + this.nextCheckDate + ",");
    //            sb_value.Append("mtnChecked =" + this.mtnChecked + ",");
    //            sb_value.Append("mtnResolveCheck =" + this.mtnResolveCheck);

    //            String sqlCmd = "update CarMaintainWithItem set  " + sb_value.ToString() + "  where carMaintainWithItemTID = " + this.carMaintainWithItemTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarMaintainWithItem");
    //            if (ds.Tables["CarMaintainWithItem"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarMaintainWithItem"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithItem.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


