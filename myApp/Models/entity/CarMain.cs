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
    
    //public partial class CarMain
    //{

    //    public Collection<CarMain> findAll()
    //    {
    //        Collection<CarMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CarMain order by CarID asc", "CarMain");
    //            if (ds.Tables["CarMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMain>();
    //                foreach (DataRow dr in ds.Tables["CarMain"].Rows)
    //                {
    //                    CarMain am = new CarMain();
    //                    am.CarID = Convert.ToString(dr["CarID"]);
    //                    am.carManuYear = Convert.ToInt32(dr["carManuYear"]);
    //                    am.carManuMonth = Convert.ToInt32(dr["carManuMonth"]);
    //                    am.carMake = Convert.ToString(dr["carMake"]);
    //                    am.carSite = Convert.ToInt32(dr["carSite"]);
    //                    am.carSize = Convert.ToString(dr["carSize"]);
    //                    am.purchaseDate = dr["purchaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["purchaseDate"]);
    //                    am.purchaseAmount = dr["purchaseAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["purchaseAmount"]);
    //                    am.purchaseMile = dr["purchaseMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["purchaseMile"]);
    //                    am.SellDate = dr["SellDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["SellDate"]);
    //                    am.driver = dr["driver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["driver"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                    am.carDept = Convert.ToInt32(dr["carDept"]);
    //                    am.carGroup = Convert.ToInt32(dr["carGroup"]);
    //                    am.maintainMileRange = Convert.ToInt32(dr["maintainMileRange"]);
    //                    am.maintainDaysRange = Convert.ToInt32(dr["maintainDaysRange"]);
    //                    am.CompanyBelong = Convert.ToString(dr["CompanyBelong"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarMain> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarMain");
    //            if (ds.Tables["CarMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMain>();
    //                foreach (DataRow dr in ds.Tables["CarMain"].Rows)
    //                {
    //                    CarMain am = new CarMain();
    //                    am.CarID = Convert.ToString(dr["CarID"]);
    //                    am.carManuYear = Convert.ToInt32(dr["carManuYear"]);
    //                    am.carManuMonth = Convert.ToInt32(dr["carManuMonth"]);
    //                    am.carMake = Convert.ToString(dr["carMake"]);
    //                    am.carSite = Convert.ToInt32(dr["carSite"]);
    //                    am.carSize = Convert.ToString(dr["carSize"]);
    //                    am.purchaseDate = dr["purchaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["purchaseDate"]);
    //                    am.purchaseAmount = dr["purchaseAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["purchaseAmount"]);
    //                    am.purchaseMile = dr["purchaseMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["purchaseMile"]);
    //                    am.SellDate = dr["SellDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["SellDate"]);
    //                    am.driver = dr["driver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["driver"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                    am.carDept = Convert.ToInt32(dr["carDept"]);
    //                    am.carGroup = Convert.ToInt32(dr["carGroup"]);
    //                    am.maintainMileRange = Convert.ToInt32(dr["maintainMileRange"]);
    //                    am.maintainDaysRange = Convert.ToInt32(dr["maintainDaysRange"]);
    //                    am.CompanyBelong = Convert.ToString(dr["CompanyBelong"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarMain findByPrimaryKey(string CarID)
    //    {
    //        CarMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CarMain a WHERE a.CarID = '" + CarID + "';";
    //            DataSet ds = my.select(sqlCmd, "CarMain");
    //            if (ds.Tables["CarMain"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarMain"].Rows[0];
    //                am = new CarMain();
    //                am.CarID = Convert.ToString(dr["CarID"]);
    //                am.carManuYear = Convert.ToInt32(dr["carManuYear"]);
    //                am.carManuMonth = Convert.ToInt32(dr["carManuMonth"]);
    //                am.carMake = Convert.ToString(dr["carMake"]);
    //                am.carSite = Convert.ToInt32(dr["carSite"]);
    //                am.carSize = Convert.ToString(dr["carSize"]);
    //                am.purchaseDate = dr["purchaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["purchaseDate"]);
    //                am.purchaseAmount = dr["purchaseAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["purchaseAmount"]);
    //                am.purchaseMile = dr["purchaseMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["purchaseMile"]);
    //                am.SellDate = dr["SellDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["SellDate"]);
    //                am.driver = dr["driver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["driver"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                am.carDept = Convert.ToInt32(dr["carDept"]);
    //                am.carGroup = Convert.ToInt32(dr["carGroup"]);
    //                am.maintainMileRange = Convert.ToInt32(dr["maintainMileRange"]);
    //                am.maintainDaysRange = Convert.ToInt32(dr["maintainDaysRange"]);
    //                am.CompanyBelong = Convert.ToString(dr["CompanyBelong"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String CarID, int carManuYear, int carManuMonth, String carMake, int carSite, String carSize, long purchaseDate, double purchaseAmount, double purchaseMile, long SellDate, int driver, String memo, int busAllian, int carDept, int carGroup, int maintainMileRange, int maintainDaysRange, String CompanyBelong, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(CarID) ? "''" : "N'" + Regex.Replace(CarID, "'", "''") + "'") + ",");
    //            sb_value.Append(carManuYear + ",");
    //            sb_value.Append(carManuMonth + ",");
    //            sb_value.Append((String.IsNullOrEmpty(carMake) ? "''" : "N'" + Regex.Replace(carMake, "'", "''") + "'") + ",");
    //            sb_value.Append(carSite + ",");
    //            sb_value.Append((String.IsNullOrEmpty(carSize) ? "null" : "N'" + Regex.Replace(carSize, "'", "''") + "'") + ",");
    //            sb_value.Append(purchaseDate + ",");
    //            sb_value.Append(purchaseAmount + ",");
    //            sb_value.Append(purchaseMile + ",");
    //            sb_value.Append(SellDate + ",");
    //            sb_value.Append(driver + ",");
    //            sb_value.Append((String.IsNullOrEmpty(memo) ? "null" : "N'" + Regex.Replace(memo, "'", "''") + "'") + ",");
    //            sb_value.Append(busAllian + ",");
    //            sb_value.Append(carDept + ",");
    //            sb_value.Append(carGroup + ",");
    //            sb_value.Append(maintainMileRange + ",");
    //            sb_value.Append(maintainDaysRange + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CompanyBelong) ? "null" : "N'" + Regex.Replace(CompanyBelong, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'"));

    //            String sqlCmd = "insert into CarMain(CarID,carManuYear,carManuMonth,carMake,carSite,carSize,purchaseDate,purchaseAmount,purchaseMile,SellDate,driver,memo,busAllian,carDept,carGroup,maintainMileRange,maintainDaysRange,CompanyBelong,status) values (" + sb_value.ToString() + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(string CarID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CarMain where CarID = '" + CarID + "';";
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String CarID, int carManuYear, int carManuMonth, String carMake, int carSite, String carSize, long purchaseDate, double purchaseAmount, double purchaseMile, long SellDate, int driver, String memo, int busAllian, int carDept, int carGroup, int maintainMileRange, int maintainDaysRange, String CompanyBelong, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("CarID=" + (String.IsNullOrEmpty(CarID) ? "''" : "N'" + Regex.Replace(CarID, "'", "''") + "'") + ",");
    //            sb_value.Append("carManuYear =" + carManuYear + ",");
    //            sb_value.Append("carManuMonth =" + carManuMonth + ",");
    //            sb_value.Append("carMake=" + (String.IsNullOrEmpty(carMake) ? "''" : "N'" + Regex.Replace(carMake, "'", "''") + "'") + ",");
    //            sb_value.Append("carSite =" + carSite + ",");
    //            sb_value.Append("carSize=" + (String.IsNullOrEmpty(carSize) ? "null" : "N'" + Regex.Replace(carSize, "'", "''") + "'") + ",");
    //            sb_value.Append("purchaseDate =" + purchaseDate + ",");
    //            sb_value.Append("purchaseAmount =" + purchaseAmount + ",");
    //            sb_value.Append("purchaseMile =" + purchaseMile + ",");
    //            sb_value.Append("SellDate =" + SellDate + ",");
    //            sb_value.Append("driver =" + driver + ",");
    //            sb_value.Append("memo=" + (String.IsNullOrEmpty(memo) ? "null" : "N'" + Regex.Replace(memo, "'", "''") + "'") + ",");
    //            sb_value.Append("busAllian =" + busAllian + ",");
    //            sb_value.Append("carDept =" + carDept + ",");
    //            sb_value.Append("carGroup =" + carGroup + ",");
    //            sb_value.Append("maintainMileRange =" + maintainMileRange + ",");
    //            sb_value.Append("maintainDaysRange =" + maintainDaysRange + ",");
    //            sb_value.Append("CompanyBelong=" + (String.IsNullOrEmpty(CompanyBelong) ? "null" : "N'" + Regex.Replace(CompanyBelong, "'", "''") + "'") + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'"));

    //            String sqlCmd = "update CarMain set  " + sb_value.ToString() + "  where CarID = N'" + this.CarID + "';";
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.create() : " + e.ToString());
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
    //            sb_value.Append("CarID=" + (String.IsNullOrEmpty(this.CarID) ? "''" : "N'" + Regex.Replace(this.CarID, "'", "''") + "'") + ",");
    //            sb_value.Append("carManuYear =" + this.carManuYear + ",");
    //            sb_value.Append("carManuMonth =" + this.carManuMonth + ",");
    //            sb_value.Append("carMake=" + (String.IsNullOrEmpty(this.carMake) ? "''" : "N'" + Regex.Replace(this.carMake, "'", "''") + "'") + ",");
    //            sb_value.Append("carSite =" + this.carSite + ",");
    //            sb_value.Append("carSize=" + (String.IsNullOrEmpty(this.carSize) ? "null" : "N'" + Regex.Replace(this.carSize, "'", "''") + "'") + ",");
    //            sb_value.Append("purchaseDate =" + this.purchaseDate + ",");
    //            sb_value.Append("purchaseAmount =" + this.purchaseAmount + ",");
    //            sb_value.Append("purchaseMile =" + this.purchaseMile + ",");
    //            sb_value.Append("SellDate =" + this.SellDate + ",");
    //            sb_value.Append("driver =" + this.driver + ",");
    //            sb_value.Append("memo=" + (String.IsNullOrEmpty(this.memo) ? "null" : "N'" + Regex.Replace(this.memo, "'", "''") + "'") + ",");
    //            sb_value.Append("busAllian =" + this.busAllian + ",");
    //            sb_value.Append("carDept =" + this.carDept + ",");
    //            sb_value.Append("carGroup =" + this.carGroup + ",");
    //            sb_value.Append("maintainMileRange =" + this.maintainMileRange + ",");
    //            sb_value.Append("maintainDaysRange =" + this.maintainDaysRange + ",");
    //            sb_value.Append("CompanyBelong=" + (String.IsNullOrEmpty(this.CompanyBelong) ? "null" : "N'" + Regex.Replace(this.CompanyBelong, "'", "''") + "'") + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(this.status) ? "''" : "N'" + Regex.Replace(this.status, "'", "''") + "'"));

    //            String sqlCmd = "update CarMain set  " + sb_value.ToString() + "  where CarID = N'" + this.CarID + "';";
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarMain");
    //            if (ds.Tables["CarMain"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarMain"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
   

}


