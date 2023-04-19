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
    //public partial class CarFuelRecord
    //{
        
    //    public Collection<CarFuelRecord> findAll()
    //    {
    //        Collection<CarFuelRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarFuelRecord order by carFuelRecordTID asc", "CarFuelRecord");
    //            if (ds.Tables["CarFuelRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarFuelRecord>();
    //                foreach (DataRow dr in ds.Tables["CarFuelRecord"].Rows)
    //                {
    //                    CarFuelRecord am = new CarFuelRecord();
    //                    am.carFuelRecordTID = Convert.ToInt32(dr["carFuelRecordTID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.carRecordTime = Convert.ToInt64(dr["carRecordTime"]);
    //                    am.fuelDatetime = Convert.ToInt64(dr["fuelDatetime"]);
    //                    am.fuelMile = Convert.ToInt64(dr["fuelMile"]);
    //                    am.fuelFilled = Convert.ToInt32(dr["fuelFilled"]);
    //                    am.fuelCost = Convert.ToInt32(dr["fuelCost"]);
    //                    am.fuelCorpID = Convert.ToInt32(dr["fuelCorpID"]);
    //                    am.fuelMemo = Convert.ToString(dr["fuelMemo"]);
    //                    am.fuelKmPerLiter = dr["fuelKmPerLiter"] == DBNull.Value ? -999 : Convert.ToInt32(dr["fuelKmPerLiter"]);
    //                    am.fuelCostPerKm = dr["fuelCostPerKm"] == DBNull.Value ? -999 : Convert.ToInt32(dr["fuelCostPerKm"]);
    //                    am.fuelMissedLastTime = Convert.ToInt32(dr["fuelMissedLastTime"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarFuelRecord> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarFuelRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarFuelRecord");
    //            if (ds.Tables["CarFuelRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarFuelRecord>();
    //                foreach (DataRow dr in ds.Tables["CarFuelRecord"].Rows)
    //                {
    //                    CarFuelRecord am = new CarFuelRecord();
    //                    am.carFuelRecordTID = Convert.ToInt32(dr["carFuelRecordTID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.carRecordTime = Convert.ToInt64(dr["carRecordTime"]);
    //                    am.fuelDatetime = Convert.ToInt64(dr["fuelDatetime"]);
    //                    am.fuelMile = Convert.ToInt64(dr["fuelMile"]);
    //                    am.fuelFilled = Convert.ToInt32(dr["fuelFilled"]);
    //                    am.fuelCost = Convert.ToInt32(dr["fuelCost"]);
    //                    am.fuelCorpID = Convert.ToInt32(dr["fuelCorpID"]);
    //                    am.fuelMemo = Convert.ToString(dr["fuelMemo"]);
    //                    am.fuelKmPerLiter = dr["fuelKmPerLiter"] == DBNull.Value ? -999 : Convert.ToInt32(dr["fuelKmPerLiter"]);
    //                    am.fuelCostPerKm = dr["fuelCostPerKm"] == DBNull.Value ? -999 : Convert.ToInt32(dr["fuelCostPerKm"]);
    //                    am.fuelMissedLastTime = Convert.ToInt32(dr["fuelMissedLastTime"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarFuelRecord findByPrimaryKey(int carFuelRecordTID)
    //    {
    //        CarFuelRecord am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarFuelRecord a WHERE a.carFuelRecordTID = " + carFuelRecordTID;
    //            DataSet ds = my.select(sqlCmd, "CarFuelRecord");
    //            if (ds.Tables["CarFuelRecord"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarFuelRecord"].Rows[0];
    //                am = new CarFuelRecord();
    //                am.carFuelRecordTID = Convert.ToInt32(dr["carFuelRecordTID"]);
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.carRecordTime = Convert.ToInt64(dr["carRecordTime"]);
    //                am.fuelDatetime = Convert.ToInt64(dr["fuelDatetime"]);
    //                am.fuelMile = Convert.ToInt64(dr["fuelMile"]);
    //                am.fuelFilled = Convert.ToInt32(dr["fuelFilled"]);
    //                am.fuelCost = Convert.ToInt32(dr["fuelCost"]);
    //                am.fuelCorpID = Convert.ToInt32(dr["fuelCorpID"]);
    //                am.fuelMemo = Convert.ToString(dr["fuelMemo"]);
    //                am.fuelKmPerLiter = dr["fuelKmPerLiter"] == DBNull.Value ? -999 : Convert.ToInt32(dr["fuelKmPerLiter"]);
    //                am.fuelCostPerKm = dr["fuelCostPerKm"] == DBNull.Value ? -999 : Convert.ToInt32(dr["fuelCostPerKm"]);
    //                am.fuelMissedLastTime = Convert.ToInt32(dr["fuelMissedLastTime"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String carID, long carRecordTime, long fuelDatetime, long fuelMile, double fuelFilled, double fuelCost, int fuelCorpID, String fuelMemo, double fuelKmPerLiter, double fuelCostPerKm, int fuelMissedLastTime)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarFuelRecord(carID,carRecordTime,fuelDatetime,fuelMile,fuelFilled,fuelCost,fuelCorpID,fuelMemo,fuelKmPerLiter,fuelCostPerKm,fuelMissedLastTime) values ('" + carID + "'," + carRecordTime + "," + fuelDatetime + "," + fuelMile + "," + fuelFilled + "," + fuelCost + "," + fuelCorpID + ",'" + fuelMemo + "'," + fuelKmPerLiter + "," + fuelCostPerKm + "," + fuelMissedLastTime + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carFuelRecordTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarFuelRecord where carFuelRecordTID = " + carFuelRecordTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String carID, long carRecordTime, long fuelDatetime, long fuelMile, double fuelFilled, double fuelCost, int fuelCorpID, String fuelMemo, double fuelKmPerLiter, double fuelCostPerKm, int fuelMissedLastTime)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarFuelRecord set carID ='" + carID + "',carRecordTime =" + carRecordTime + ",fuelDatetime =" + fuelDatetime + ",fuelMile =" + fuelMile + ",fuelFilled =" + fuelFilled + ",fuelCost =" + fuelCost + ",fuelCorpID =" + fuelCorpID + ",fuelMemo ='" + fuelMemo + "',fuelKmPerLiter =" + fuelKmPerLiter + ",fuelCostPerKm =" + fuelCostPerKm + ",fuelMissedLastTime =" + fuelMissedLastTime + " where carFuelRecordTID = " + this.carFuelRecordTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarFuelRecord set carID ='" + this.carID + "',carRecordTime =" + this.carRecordTime + ",fuelDatetime =" + this.fuelDatetime + ",fuelMile =" + this.fuelMile + ",fuelFilled =" + this.fuelFilled + ",fuelCost =" + this.fuelCost + ",fuelCorpID =" + this.fuelCorpID + ",fuelMemo ='" + this.fuelMemo + "',fuelKmPerLiter =" + this.fuelKmPerLiter + ",fuelCostPerKm =" + this.fuelCostPerKm + ",fuelMissedLastTime =" + this.fuelMissedLastTime + " where carFuelRecordTID = " + this.carFuelRecordTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarFuelRecord");
    //            if (ds.Tables["CarFuelRecord"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarFuelRecord"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecord.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


