using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class CarFuelRecordExt : CarFuelRecord
    //{
    //    public CarFuelRecord findByCarID(String carID)
    //    {
    //        CarFuelRecord am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarFuelRecord a WHERE a.carID = '" + carID + "'";
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecordExt.findByCarID() : " + e.ToString());
    //        }
    //        return am;
    //    }

    //    public CarFuelRecord findLastRecordByCarID(String carID)
    //    {
    //        CarFuelRecord am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select Top 1 * FROM CarFuelRecord a WHERE a.carID = '" + carID + "'  order by fuelDatetime desc, fuelmile desc"; 
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecordExt.findByCarID() : " + e.ToString());
    //        }
    //        return am;
    //    }

    //    public Int64 findLastFuelRecordByCarID(String carID)
    //    {
    //        String sqlCmd = "select Top 1 * FROM CarFuelRecord a WHERE a.carID = '" + carID + "'  order by fuelDatetime desc, fuelmile desc"; 

    //        Int64 count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarFuelRecord");
    //            if (ds.Tables["CarFuelRecord"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarFuelRecord"].Rows[0];
    //                count = Convert.ToInt64(dr["fuelMile"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFuelRecordExt.lastMileInSystem() : " + e.ToString());
    //        }
    //        return count;
    //    }

    //}
}