using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace hsintongERP2022.Models
{
   
    //public partial class CarMaintaince
    //{
   
    //    public Collection<CarMaintaince> findAll()
    //    {
    //        Collection<CarMaintaince> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CarMaintaince order by carMaintainTID asc", "CarMaintaince");
    //            if (ds.Tables["CarMaintaince"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMaintaince>();
    //                foreach (DataRow dr in ds.Tables["CarMaintaince"].Rows)
    //                {
    //                    CarMaintaince am = new CarMaintaince();
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.ticketID = Convert.ToString(dr["ticketID"]);
    //                    am.fileCreateDate = dr["fileCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["fileCreateDate"]);
    //                    am.maintainMile = Convert.ToDecimal(dr["maintainMile"]);
    //                    am.maintainDate = Convert.ToInt64(dr["maintainDate"]);
    //                    am.maintainType = Convert.ToString(dr["maintainType"]);
    //                    am.maintainMemo = Convert.ToString(dr["maintainMemo"]);
    //                    am.corporationID = dr["corporationID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["corporationID"]);
    //                    am.maintainPerformBy = Convert.ToString(dr["maintainPerformBy"]);
    //                    am.maintainByDriver = dr["maintainByDriver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["maintainByDriver"]);
    //                    am.nextMaintainMile = dr["nextMaintainMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextMaintainMile"]);
    //                    am.nextMaintainDate = dr["nextMaintainDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextMaintainDate"]);
    //                    am.nextMaintainExecuted = dr["nextMaintainExecuted"] == DBNull.Value ? -999 : Convert.ToInt32(dr["nextMaintainExecuted"]);
    //                    am.nextMaintainMile2 = dr["nextMaintainMile2"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextMaintainMile2"]);
    //                    am.nextMaintainDate2 = dr["nextMaintainDate2"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextMaintainDate2"]);
    //                    am.nextMaintainExecuted2 = dr["nextMaintainExecuted2"] == DBNull.Value ? -999 : Convert.ToInt32(dr["nextMaintainExecuted2"]);
    //                    am.driver = Convert.ToInt32(dr["driver"]);
    //                    am.carMaintainTID = Convert.ToInt32(dr["carMaintainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarMaintaince> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarMaintaince> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarMaintaince");
    //            if (ds.Tables["CarMaintaince"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMaintaince>();
    //                foreach (DataRow dr in ds.Tables["CarMaintaince"].Rows)
    //                {
    //                    CarMaintaince am = new CarMaintaince();
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.ticketID = Convert.ToString(dr["ticketID"]);
    //                    am.fileCreateDate = dr["fileCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["fileCreateDate"]);
    //                    am.maintainMile = Convert.ToDecimal(dr["maintainMile"]);
    //                    am.maintainDate = Convert.ToInt64(dr["maintainDate"]);
    //                    am.maintainType = Convert.ToString(dr["maintainType"]);
    //                    am.maintainMemo = Convert.ToString(dr["maintainMemo"]);
    //                    am.corporationID = dr["corporationID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["corporationID"]);
    //                    am.maintainPerformBy = Convert.ToString(dr["maintainPerformBy"]);
    //                    am.maintainByDriver = dr["maintainByDriver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["maintainByDriver"]);
    //                    am.nextMaintainMile = dr["nextMaintainMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextMaintainMile"]);
    //                    am.nextMaintainDate = dr["nextMaintainDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextMaintainDate"]);
    //                    am.nextMaintainExecuted = dr["nextMaintainExecuted"] == DBNull.Value ? -999 : Convert.ToInt32(dr["nextMaintainExecuted"]);
    //                    am.nextMaintainMile2 = dr["nextMaintainMile2"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextMaintainMile2"]);
    //                    am.nextMaintainDate2 = dr["nextMaintainDate2"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextMaintainDate2"]);
    //                    am.nextMaintainExecuted2 = dr["nextMaintainExecuted2"] == DBNull.Value ? -999 : Convert.ToInt32(dr["nextMaintainExecuted2"]);
    //                    am.driver = Convert.ToInt32(dr["driver"]);
    //                    am.carMaintainTID = Convert.ToInt32(dr["carMaintainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarMaintaince findByPrimaryKey(int carMaintainTID)
    //    {
    //        CarMaintaince am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CarMaintaince a WHERE a.carMaintainTID = " + carMaintainTID;
    //            DataSet ds = my.select(sqlCmd, "CarMaintaince");
    //            if (ds.Tables["CarMaintaince"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarMaintaince"].Rows[0];
    //                am = new CarMaintaince();
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.ticketID = Convert.ToString(dr["ticketID"]);
    //                am.fileCreateDate = dr["fileCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["fileCreateDate"]);
    //                am.maintainMile = Convert.ToDecimal(dr["maintainMile"]);
    //                am.maintainDate = Convert.ToInt64(dr["maintainDate"]);
    //                am.maintainType = Convert.ToString(dr["maintainType"]);
    //                am.maintainMemo = Convert.ToString(dr["maintainMemo"]);
    //                am.corporationID = dr["corporationID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["corporationID"]);
    //                am.maintainPerformBy = Convert.ToString(dr["maintainPerformBy"]);
    //                am.maintainByDriver = dr["maintainByDriver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["maintainByDriver"]);
    //                am.nextMaintainMile = dr["nextMaintainMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextMaintainMile"]);
    //                am.nextMaintainDate = dr["nextMaintainDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextMaintainDate"]);
    //                am.nextMaintainExecuted = dr["nextMaintainExecuted"] == DBNull.Value ? -999 : Convert.ToInt32(dr["nextMaintainExecuted"]);
    //                am.nextMaintainMile2 = dr["nextMaintainMile2"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextMaintainMile2"]);
    //                am.nextMaintainDate2 = dr["nextMaintainDate2"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextMaintainDate2"]);
    //                am.nextMaintainExecuted2 = dr["nextMaintainExecuted2"] == DBNull.Value ? -999 : Convert.ToInt32(dr["nextMaintainExecuted2"]);
    //                am.driver = Convert.ToInt32(dr["driver"]);
    //                am.carMaintainTID = Convert.ToInt32(dr["carMaintainTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String carID, String ticketID, long fileCreateDate, double maintainMile, long maintainDate, String maintainType, String maintainMemo, int corporationID, String maintainPerformBy, int maintainByDriver, double nextMaintainMile, long nextMaintainDate, int nextMaintainExecuted, double nextMaintainMile2, long nextMaintainDate2, int nextMaintainExecuted2, int driver)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(carID) ? "''" : "N'" + Regex.Replace(carID, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(ticketID) ? "null" : "N'" + Regex.Replace(ticketID, "'", "''") + "'") + ",");
    //            sb_value.Append(fileCreateDate + ",");
    //            sb_value.Append(maintainMile + ",");
    //            sb_value.Append(maintainDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(maintainType) ? "''" : "N'" + Regex.Replace(maintainType, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(maintainMemo) ? "null" : "N'" + Regex.Replace(maintainMemo, "'", "''") + "'") + ",");
    //            sb_value.Append(corporationID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(maintainPerformBy) ? "null" : "N'" + Regex.Replace(maintainPerformBy, "'", "''") + "'") + ",");
    //            sb_value.Append(maintainByDriver + ",");
    //            sb_value.Append(nextMaintainMile + ",");
    //            sb_value.Append(nextMaintainDate + ",");
    //            sb_value.Append(nextMaintainExecuted + ",");
    //            sb_value.Append(nextMaintainMile2 + ",");
    //            sb_value.Append(nextMaintainDate2 + ",");
    //            sb_value.Append(nextMaintainExecuted2 + ",");
    //            sb_value.Append(driver);

    //            String sqlCmd = "insert into CarMaintaince(carID,ticketID,fileCreateDate,maintainMile,maintainDate,maintainType,maintainMemo,corporationID,maintainPerformBy,maintainByDriver,nextMaintainMile,nextMaintainDate,nextMaintainExecuted,nextMaintainMile2,nextMaintainDate2,nextMaintainExecuted2,driver) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carMaintainTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CarMaintaince where carMaintainTID = " + carMaintainTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String carID, String ticketID, long fileCreateDate, decimal maintainMile, long maintainDate, String maintainType, String maintainMemo, int corporationID, String maintainPerformBy, int maintainByDriver, decimal nextMaintainMile, long nextMaintainDate, int nextMaintainExecuted, decimal nextMaintainMile2, long nextMaintainDate2, int nextMaintainExecuted2, int driver)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(carID) ? "''" : "N'" + Regex.Replace(carID, "'", "''") + "'") + ",");
    //            sb_value.Append("ticketID=" + (String.IsNullOrEmpty(ticketID) ? "null" : "N'" + Regex.Replace(ticketID, "'", "''") + "'") + ",");
    //            sb_value.Append("fileCreateDate =" + fileCreateDate + ",");
    //            sb_value.Append("maintainMile =" + maintainMile + ",");
    //            sb_value.Append("maintainDate =" + maintainDate + ",");
    //            sb_value.Append("maintainType=" + (String.IsNullOrEmpty(maintainType) ? "''" : "N'" + Regex.Replace(maintainType, "'", "''") + "'") + ",");
    //            sb_value.Append("maintainMemo=" + (String.IsNullOrEmpty(maintainMemo) ? "null" : "N'" + Regex.Replace(maintainMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("corporationID =" + corporationID + ",");
    //            sb_value.Append("maintainPerformBy=" + (String.IsNullOrEmpty(maintainPerformBy) ? "null" : "N'" + Regex.Replace(maintainPerformBy, "'", "''") + "'") + ",");
    //            sb_value.Append("maintainByDriver =" + maintainByDriver + ",");
    //            sb_value.Append("nextMaintainMile =" + nextMaintainMile + ",");
    //            sb_value.Append("nextMaintainDate =" + nextMaintainDate + ",");
    //            sb_value.Append("nextMaintainExecuted =" + nextMaintainExecuted + ",");
    //            sb_value.Append("nextMaintainMile2 =" + nextMaintainMile2 + ",");
    //            sb_value.Append("nextMaintainDate2 =" + nextMaintainDate2 + ",");
    //            sb_value.Append("nextMaintainExecuted2 =" + nextMaintainExecuted2 + ",");
    //            sb_value.Append("driver =" + driver);

    //            String sqlCmd = "update CarMaintaince set  " + sb_value.ToString() + "  where carMaintainTID = " + this.carMaintainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.create() : " + e.ToString());
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
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(this.carID) ? "''" : "N'" + Regex.Replace(this.carID, "'", "''") + "'") + ",");
    //            sb_value.Append("ticketID=" + (String.IsNullOrEmpty(this.ticketID) ? "null" : "N'" + Regex.Replace(this.ticketID, "'", "''") + "'") + ",");
    //            sb_value.Append("fileCreateDate =" + this.fileCreateDate + ",");
    //            sb_value.Append("maintainMile =" + this.maintainMile + ",");
    //            sb_value.Append("maintainDate =" + this.maintainDate + ",");
    //            sb_value.Append("maintainType=" + (String.IsNullOrEmpty(this.maintainType) ? "''" : "N'" + Regex.Replace(this.maintainType, "'", "''") + "'") + ",");
    //            sb_value.Append("maintainMemo=" + (String.IsNullOrEmpty(this.maintainMemo) ? "null" : "N'" + Regex.Replace(this.maintainMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("corporationID =" + this.corporationID + ",");
    //            sb_value.Append("maintainPerformBy=" + (String.IsNullOrEmpty(this.maintainPerformBy) ? "null" : "N'" + Regex.Replace(this.maintainPerformBy, "'", "''") + "'") + ",");
    //            sb_value.Append("maintainByDriver =" + this.maintainByDriver + ",");
    //            sb_value.Append("nextMaintainMile =" + this.nextMaintainMile + ",");
    //            sb_value.Append("nextMaintainDate =" + this.nextMaintainDate + ",");
    //            sb_value.Append("nextMaintainExecuted =" + this.nextMaintainExecuted + ",");
    //            sb_value.Append("nextMaintainMile2 =" + this.nextMaintainMile2 + ",");
    //            sb_value.Append("nextMaintainDate2 =" + this.nextMaintainDate2 + ",");
    //            sb_value.Append("nextMaintainExecuted2 =" + this.nextMaintainExecuted2 + ",");
    //            sb_value.Append("driver =" + this.driver);

    //            String sqlCmd = "update CarMaintaince set  " + sb_value.ToString() + "  where carMaintainTID = " + this.carMaintainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarMaintaince");
    //            if (ds.Tables["CarMaintaince"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarMaintaince"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
   
}


