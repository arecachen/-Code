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
    //public partial class view_CarMaintainTracking_MaintainItems
    //{
        
    //    public Collection<view_CarMaintainTracking_MaintainItems> findAll()
    //    {
    //        Collection<view_CarMaintainTracking_MaintainItems> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from view_CarMaintainTracking_MaintainItems order by CarID asc", "view_CarMaintainTracking_MaintainItems");
    //            if (ds.Tables["view_CarMaintainTracking_MaintainItems"].Rows.Count > 0)
    //            {
    //                c = new Collection<view_CarMaintainTracking_MaintainItems>();
    //                foreach (DataRow dr in ds.Tables["view_CarMaintainTracking_MaintainItems"].Rows)
    //                {
    //                    view_CarMaintainTracking_MaintainItems am = new view_CarMaintainTracking_MaintainItems();
    //                    am.CarID = Convert.ToString(dr["CarID"]);
    //                    am.carManuYear = Convert.ToInt32(dr["carManuYear"]);
    //                    am.carManuMonth = Convert.ToInt32(dr["carManuMonth"]);
    //                    am.carMake = Convert.ToString(dr["carMake"]);
    //                    am.purchaseDate = dr["purchaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["purchaseDate"]);
    //                    am.driver = dr["driver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["driver"]);
    //                    am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                    am.carStatus = Convert.ToString(dr["carStatus"]);
    //                    am.empName = Convert.ToString(dr["empName"]);
    //                    am.carMaintainWithItemTID = Convert.ToInt32(dr["carMaintainWithItemTID"]);
    //                    am.carMaintainItemID = Convert.ToInt32(dr["carMaintainItemID"]);
    //                    am.itemName = Convert.ToString(dr["itemName"]);
    //                    am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                    am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                    am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                    am.mtnStatus = Convert.ToString(dr["mtnStatus"]);
    //                    am.mtnStatusText = Convert.ToString(dr["mtnStatusText"]);
    //                    am.mtnFaultyDesc = Convert.ToString(dr["mtnFaultyDesc"]);
    //                    am.mtnResolve = Convert.ToInt32(dr["mtnResolve"]);
    //                    am.mtnResolveText = Convert.ToString(dr["mtnResolveText"]);
    //                    am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                    am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                    am.mtnChecked = dr["mtnChecked"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnChecked"]);
    //                    am.mtnResolveCheck = dr["mtnResolveCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnResolveCheck"]);
    //                    am.lastMile = Convert.ToInt64(dr["lastMile"]);
    //                    am.mileToCheck = dr["mileToCheck"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["mileToCheck"]);
    //                    am.carMaintainTID = Convert.ToInt32(dr["carMaintainTID"]);
    //                    am.maintainDate = Convert.ToInt64(dr["maintainDate"]);
    //                    am.maintainMile = Convert.ToDecimal(dr["maintainMile"]);
    //                    am.fileCreateDate = dr["fileCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["fileCreateDate"]);
    //                    am.maintainType = Convert.ToString(dr["maintainType"]);
    //                    am.maintainMemo = Convert.ToString(dr["maintainMemo"]);
    //                    am.driverName = Convert.ToString(dr["driverName"]);
    //                    am.corpName = Convert.ToString(dr["corpName"]);
    //                    am.maintainPerformBy = Convert.ToString(dr["maintainPerformBy"]);
    //                    am.ticketID = Convert.ToString(dr["ticketID"]);
    //                    am.mtnCost = Convert.ToInt32(dr["mtnCost"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<view_CarMaintainTracking_MaintainItems> findByKeyword(String sqlCmd)
    //    {
    //        Collection<view_CarMaintainTracking_MaintainItems> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "view_CarMaintainTracking_MaintainItems");
    //            if (ds.Tables["view_CarMaintainTracking_MaintainItems"].Rows.Count > 0)
    //            {
    //                c = new Collection<view_CarMaintainTracking_MaintainItems>();
    //                foreach (DataRow dr in ds.Tables["view_CarMaintainTracking_MaintainItems"].Rows)
    //                {
    //                    view_CarMaintainTracking_MaintainItems am = new view_CarMaintainTracking_MaintainItems();
    //                    am.CarID = Convert.ToString(dr["CarID"]);
    //                    am.carManuYear = Convert.ToInt32(dr["carManuYear"]);
    //                    am.carManuMonth = Convert.ToInt32(dr["carManuMonth"]);
    //                    am.carMake = Convert.ToString(dr["carMake"]);
    //                    am.purchaseDate = dr["purchaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["purchaseDate"]);
    //                    am.driver = dr["driver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["driver"]);
    //                    am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                    am.carStatus = Convert.ToString(dr["carStatus"]);
    //                    am.empName = Convert.ToString(dr["empName"]);
    //                    am.carMaintainWithItemTID = Convert.ToInt32(dr["carMaintainWithItemTID"]);
    //                    am.carMaintainItemID = Convert.ToInt32(dr["carMaintainItemID"]);
    //                    am.itemName = Convert.ToString(dr["itemName"]);
    //                    am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                    am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                    am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                    am.mtnStatus = Convert.ToString(dr["mtnStatus"]);
    //                    am.mtnStatusText = Convert.ToString(dr["mtnStatusText"]);
    //                    am.mtnFaultyDesc = Convert.ToString(dr["mtnFaultyDesc"]);
    //                    am.mtnResolve = Convert.ToInt32(dr["mtnResolve"]);
    //                    am.mtnResolveText = Convert.ToString(dr["mtnResolveText"]);
    //                    am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                    am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                    am.mtnChecked = dr["mtnChecked"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnChecked"]);
    //                    am.mtnResolveCheck = dr["mtnResolveCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnResolveCheck"]);
    //                    am.lastMile = Convert.ToInt64(dr["lastMile"]);
    //                    am.mileToCheck = dr["mileToCheck"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["mileToCheck"]);
    //                    am.carMaintainTID = Convert.ToInt32(dr["carMaintainTID"]);
    //                    am.maintainDate = Convert.ToInt64(dr["maintainDate"]);
    //                    am.maintainMile = Convert.ToDecimal(dr["maintainMile"]);
    //                    am.fileCreateDate = dr["fileCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["fileCreateDate"]);
    //                    am.maintainType = Convert.ToString(dr["maintainType"]);
    //                    am.maintainMemo = Convert.ToString(dr["maintainMemo"]);
    //                    am.driverName = Convert.ToString(dr["driverName"]);
    //                    am.corpName = Convert.ToString(dr["corpName"]);
    //                    am.maintainPerformBy = Convert.ToString(dr["maintainPerformBy"]);
    //                    am.ticketID = Convert.ToString(dr["ticketID"]);
    //                    am.mtnCost = Convert.ToInt32(dr["mtnCost"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public view_CarMaintainTracking_MaintainItems findByPrimaryKey(string CarID)
    //    {
    //        view_CarMaintainTracking_MaintainItems am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM view_CarMaintainTracking_MaintainItems a WHERE a.CarID = '" + CarID + "';";
    //            DataSet ds = my.select(sqlCmd, "view_CarMaintainTracking_MaintainItems");
    //            if (ds.Tables["view_CarMaintainTracking_MaintainItems"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["view_CarMaintainTracking_MaintainItems"].Rows[0];
    //                am = new view_CarMaintainTracking_MaintainItems();
    //                am.CarID = Convert.ToString(dr["CarID"]);
    //                am.carManuYear = Convert.ToInt32(dr["carManuYear"]);
    //                am.carManuMonth = Convert.ToInt32(dr["carManuMonth"]);
    //                am.carMake = Convert.ToString(dr["carMake"]);
    //                am.purchaseDate = dr["purchaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["purchaseDate"]);
    //                am.driver = dr["driver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["driver"]);
    //                am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                am.carStatus = Convert.ToString(dr["carStatus"]);
    //                am.empName = Convert.ToString(dr["empName"]);
    //                am.carMaintainWithItemTID = Convert.ToInt32(dr["carMaintainWithItemTID"]);
    //                am.carMaintainItemID = Convert.ToInt32(dr["carMaintainItemID"]);
    //                am.itemName = Convert.ToString(dr["itemName"]);
    //                am.itemMemo = Convert.ToString(dr["itemMemo"]);
    //                am.itemShowOnReport = Convert.ToInt32(dr["itemShowOnReport"]);
    //                am.itemStatus = Convert.ToString(dr["itemStatus"]);
    //                am.mtnStatus = Convert.ToString(dr["mtnStatus"]);
    //                am.mtnStatusText = Convert.ToString(dr["mtnStatusText"]);
    //                am.mtnFaultyDesc = Convert.ToString(dr["mtnFaultyDesc"]);
    //                am.mtnResolve = Convert.ToInt32(dr["mtnResolve"]);
    //                am.mtnResolveText = Convert.ToString(dr["mtnResolveText"]);
    //                am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                am.mtnChecked = dr["mtnChecked"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnChecked"]);
    //                am.mtnResolveCheck = dr["mtnResolveCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["mtnResolveCheck"]);
    //                am.lastMile = Convert.ToInt64(dr["lastMile"]);
    //                am.mileToCheck = dr["mileToCheck"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["mileToCheck"]);
    //                am.carMaintainTID = Convert.ToInt32(dr["carMaintainTID"]);
    //                am.maintainDate = Convert.ToInt64(dr["maintainDate"]);
    //                am.maintainMile = Convert.ToDecimal(dr["maintainMile"]);
    //                am.fileCreateDate = dr["fileCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["fileCreateDate"]);
    //                am.maintainType = Convert.ToString(dr["maintainType"]);
    //                am.maintainMemo = Convert.ToString(dr["maintainMemo"]);
    //                am.driverName = Convert.ToString(dr["driverName"]);
    //                am.corpName = Convert.ToString(dr["corpName"]);
    //                am.maintainPerformBy = Convert.ToString(dr["maintainPerformBy"]);
    //                am.ticketID = Convert.ToString(dr["ticketID"]);
    //                am.mtnCost = Convert.ToInt32(dr["mtnCost"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String CarID, int carManuYear, int carManuMonth, String carMake, long purchaseDate, int driver, int busAllian, String carStatus, String empName, int carMaintainWithItemTID, int carMaintainItemID, String itemName, String itemMemo, int itemShowOnReport, String itemStatus, String mtnStatus, String mtnStatusText, String mtnFaultyDesc, int mtnResolve, String mtnResolveText, double nextCheckMile, long nextCheckDate, int mtnChecked, int mtnResolveCheck, long lastMile, double mileToCheck, int carMaintainTID, long maintainDate, double maintainMile, long fileCreateDate, String maintainType, String maintainMemo, String driverName, String corpName, String maintainPerformBy, String ticketID, double mtnCost)
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
    //            sb_value.Append(purchaseDate + ",");
    //            sb_value.Append(driver + ",");
    //            sb_value.Append(busAllian + ",");
    //            sb_value.Append((String.IsNullOrEmpty(carStatus) ? "''" : "N'" + Regex.Replace(carStatus, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(empName) ? "''" : "N'" + Regex.Replace(empName, "'", "''") + "'") + ",");
    //            sb_value.Append(carMaintainWithItemTID + ",");
    //            sb_value.Append(carMaintainItemID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(itemName) ? "''" : "N'" + Regex.Replace(itemName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(itemMemo) ? "null" : "N'" + Regex.Replace(itemMemo, "'", "''") + "'") + ",");
    //            sb_value.Append(itemShowOnReport + ",");
    //            sb_value.Append((String.IsNullOrEmpty(itemStatus) ? "''" : "N'" + Regex.Replace(itemStatus, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(mtnStatus) ? "''" : "N'" + Regex.Replace(mtnStatus, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(mtnStatusText) ? "''" : "N'" + Regex.Replace(mtnStatusText, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(mtnFaultyDesc) ? "null" : "N'" + Regex.Replace(mtnFaultyDesc, "'", "''") + "'") + ",");
    //            sb_value.Append(mtnResolve + ",");
    //            sb_value.Append((String.IsNullOrEmpty(mtnResolveText) ? "''" : "N'" + Regex.Replace(mtnResolveText, "'", "''") + "'") + ",");
    //            sb_value.Append(nextCheckMile + ",");
    //            sb_value.Append(nextCheckDate + ",");
    //            sb_value.Append(mtnChecked + ",");
    //            sb_value.Append(mtnResolveCheck + ",");
    //            sb_value.Append(lastMile + ",");
    //            sb_value.Append(mileToCheck + ",");
    //            sb_value.Append(carMaintainTID + ",");
    //            sb_value.Append(maintainDate + ",");
    //            sb_value.Append(maintainMile + ",");
    //            sb_value.Append(fileCreateDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(maintainType) ? "''" : "N'" + Regex.Replace(maintainType, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(maintainMemo) ? "null" : "N'" + Regex.Replace(maintainMemo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(driverName) ? "''" : "N'" + Regex.Replace(driverName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(corpName) ? "''" : "N'" + Regex.Replace(corpName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(maintainPerformBy) ? "null" : "N'" + Regex.Replace(maintainPerformBy, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(ticketID) ? "null" : "N'" + Regex.Replace(ticketID, "'", "''") + "'") + ",");
    //            sb_value.Append(mtnCost);

    //            String sqlCmd = "insert into view_CarMaintainTracking_MaintainItems(CarID,carManuYear,carManuMonth,carMake,purchaseDate,driver,busAllian,carStatus,empName,carMaintainWithItemTID,carMaintainItemID,itemName,itemMemo,itemShowOnReport,itemStatus,mtnStatus,mtnStatusText,mtnFaultyDesc,mtnResolve,mtnResolveText,nextCheckMile,nextCheckDate,mtnChecked,mtnResolveCheck,lastMile,mileToCheck,carMaintainTID,maintainDate,maintainMile,fileCreateDate,maintainType,maintainMemo,driverName,corpName,maintainPerformBy,ticketID,mtnCost) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(string CarID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from view_CarMaintainTracking_MaintainItems where CarID = '" + CarID + "';";
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String CarID, int carManuYear, int carManuMonth, String carMake, long purchaseDate, int driver, int busAllian, String carStatus, String empName, int carMaintainWithItemTID, int carMaintainItemID, String itemName, String itemMemo, int itemShowOnReport, String itemStatus, String mtnStatus, String mtnStatusText, String mtnFaultyDesc, int mtnResolve, String mtnResolveText, double nextCheckMile, long nextCheckDate, int mtnChecked, int mtnResolveCheck, long lastMile, double mileToCheck, int carMaintainTID, long maintainDate, double maintainMile, long fileCreateDate, String maintainType, String maintainMemo, String driverName, String corpName, String maintainPerformBy, String ticketID, double mtnCost)
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
    //            sb_value.Append("purchaseDate =" + purchaseDate + ",");
    //            sb_value.Append("driver =" + driver + ",");
    //            sb_value.Append("busAllian =" + busAllian + ",");
    //            sb_value.Append("carStatus=" + (String.IsNullOrEmpty(carStatus) ? "''" : "N'" + Regex.Replace(carStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("empName=" + (String.IsNullOrEmpty(empName) ? "''" : "N'" + Regex.Replace(empName, "'", "''") + "'") + ",");
    //            sb_value.Append("carMaintainWithItemTID =" + carMaintainWithItemTID + ",");
    //            sb_value.Append("carMaintainItemID =" + carMaintainItemID + ",");
    //            sb_value.Append("itemName=" + (String.IsNullOrEmpty(itemName) ? "''" : "N'" + Regex.Replace(itemName, "'", "''") + "'") + ",");
    //            sb_value.Append("itemMemo=" + (String.IsNullOrEmpty(itemMemo) ? "null" : "N'" + Regex.Replace(itemMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("itemShowOnReport =" + itemShowOnReport + ",");
    //            sb_value.Append("itemStatus=" + (String.IsNullOrEmpty(itemStatus) ? "''" : "N'" + Regex.Replace(itemStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnStatus=" + (String.IsNullOrEmpty(mtnStatus) ? "''" : "N'" + Regex.Replace(mtnStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnStatusText=" + (String.IsNullOrEmpty(mtnStatusText) ? "''" : "N'" + Regex.Replace(mtnStatusText, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnFaultyDesc=" + (String.IsNullOrEmpty(mtnFaultyDesc) ? "null" : "N'" + Regex.Replace(mtnFaultyDesc, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnResolve =" + mtnResolve + ",");
    //            sb_value.Append("mtnResolveText=" + (String.IsNullOrEmpty(mtnResolveText) ? "''" : "N'" + Regex.Replace(mtnResolveText, "'", "''") + "'") + ",");
    //            sb_value.Append("nextCheckMile =" + nextCheckMile + ",");
    //            sb_value.Append("nextCheckDate =" + nextCheckDate + ",");
    //            sb_value.Append("mtnChecked =" + mtnChecked + ",");
    //            sb_value.Append("mtnResolveCheck =" + mtnResolveCheck + ",");
    //            sb_value.Append("lastMile =" + lastMile + ",");
    //            sb_value.Append("mileToCheck =" + mileToCheck + ",");
    //            sb_value.Append("carMaintainTID =" + carMaintainTID + ",");
    //            sb_value.Append("maintainDate =" + maintainDate + ",");
    //            sb_value.Append("maintainMile =" + maintainMile + ",");
    //            sb_value.Append("fileCreateDate =" + fileCreateDate + ",");
    //            sb_value.Append("maintainType=" + (String.IsNullOrEmpty(maintainType) ? "''" : "N'" + Regex.Replace(maintainType, "'", "''") + "'") + ",");
    //            sb_value.Append("maintainMemo=" + (String.IsNullOrEmpty(maintainMemo) ? "null" : "N'" + Regex.Replace(maintainMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("driverName=" + (String.IsNullOrEmpty(driverName) ? "''" : "N'" + Regex.Replace(driverName, "'", "''") + "'") + ",");
    //            sb_value.Append("corpName=" + (String.IsNullOrEmpty(corpName) ? "''" : "N'" + Regex.Replace(corpName, "'", "''") + "'") + ",");
    //            sb_value.Append("maintainPerformBy=" + (String.IsNullOrEmpty(maintainPerformBy) ? "null" : "N'" + Regex.Replace(maintainPerformBy, "'", "''") + "'") + ",");
    //            sb_value.Append("ticketID=" + (String.IsNullOrEmpty(ticketID) ? "null" : "N'" + Regex.Replace(ticketID, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnCost =" + mtnCost);

    //            String sqlCmd = "update view_CarMaintainTracking_MaintainItems set  " + sb_value.ToString() + "  where CarID = N'" + this.CarID + "';";
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.create() : " + e.ToString());
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
    //            sb_value.Append("purchaseDate =" + this.purchaseDate + ",");
    //            sb_value.Append("driver =" + this.driver + ",");
    //            sb_value.Append("busAllian =" + this.busAllian + ",");
    //            sb_value.Append("carStatus=" + (String.IsNullOrEmpty(this.carStatus) ? "''" : "N'" + Regex.Replace(this.carStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("empName=" + (String.IsNullOrEmpty(this.empName) ? "''" : "N'" + Regex.Replace(this.empName, "'", "''") + "'") + ",");
    //            sb_value.Append("carMaintainWithItemTID =" + this.carMaintainWithItemTID + ",");
    //            sb_value.Append("carMaintainItemID =" + this.carMaintainItemID + ",");
    //            sb_value.Append("itemName=" + (String.IsNullOrEmpty(this.itemName) ? "''" : "N'" + Regex.Replace(this.itemName, "'", "''") + "'") + ",");
    //            sb_value.Append("itemMemo=" + (String.IsNullOrEmpty(this.itemMemo) ? "null" : "N'" + Regex.Replace(this.itemMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("itemShowOnReport =" + this.itemShowOnReport + ",");
    //            sb_value.Append("itemStatus=" + (String.IsNullOrEmpty(this.itemStatus) ? "''" : "N'" + Regex.Replace(this.itemStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnStatus=" + (String.IsNullOrEmpty(this.mtnStatus) ? "''" : "N'" + Regex.Replace(this.mtnStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnStatusText=" + (String.IsNullOrEmpty(this.mtnStatusText) ? "''" : "N'" + Regex.Replace(this.mtnStatusText, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnFaultyDesc=" + (String.IsNullOrEmpty(this.mtnFaultyDesc) ? "null" : "N'" + Regex.Replace(this.mtnFaultyDesc, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnResolve =" + this.mtnResolve + ",");
    //            sb_value.Append("mtnResolveText=" + (String.IsNullOrEmpty(this.mtnResolveText) ? "''" : "N'" + Regex.Replace(this.mtnResolveText, "'", "''") + "'") + ",");
    //            sb_value.Append("nextCheckMile =" + this.nextCheckMile + ",");
    //            sb_value.Append("nextCheckDate =" + this.nextCheckDate + ",");
    //            sb_value.Append("mtnChecked =" + this.mtnChecked + ",");
    //            sb_value.Append("mtnResolveCheck =" + this.mtnResolveCheck + ",");
    //            sb_value.Append("lastMile =" + this.lastMile + ",");
    //            sb_value.Append("mileToCheck =" + this.mileToCheck + ",");
    //            sb_value.Append("carMaintainTID =" + this.carMaintainTID + ",");
    //            sb_value.Append("maintainDate =" + this.maintainDate + ",");
    //            sb_value.Append("maintainMile =" + this.maintainMile + ",");
    //            sb_value.Append("fileCreateDate =" + this.fileCreateDate + ",");
    //            sb_value.Append("maintainType=" + (String.IsNullOrEmpty(this.maintainType) ? "''" : "N'" + Regex.Replace(this.maintainType, "'", "''") + "'") + ",");
    //            sb_value.Append("maintainMemo=" + (String.IsNullOrEmpty(this.maintainMemo) ? "null" : "N'" + Regex.Replace(this.maintainMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("driverName=" + (String.IsNullOrEmpty(this.driverName) ? "''" : "N'" + Regex.Replace(this.driverName, "'", "''") + "'") + ",");
    //            sb_value.Append("corpName=" + (String.IsNullOrEmpty(this.corpName) ? "''" : "N'" + Regex.Replace(this.corpName, "'", "''") + "'") + ",");
    //            sb_value.Append("maintainPerformBy=" + (String.IsNullOrEmpty(this.maintainPerformBy) ? "null" : "N'" + Regex.Replace(this.maintainPerformBy, "'", "''") + "'") + ",");
    //            sb_value.Append("ticketID=" + (String.IsNullOrEmpty(this.ticketID) ? "null" : "N'" + Regex.Replace(this.ticketID, "'", "''") + "'") + ",");
    //            sb_value.Append("mtnCost =" + this.mtnCost);

    //            String sqlCmd = "update view_CarMaintainTracking_MaintainItems set  " + sb_value.ToString() + "  where CarID = N'" + this.CarID + "';";
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "view_CarMaintainTracking_MaintainItems");
    //            if (ds.Tables["view_CarMaintainTracking_MaintainItems"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["view_CarMaintainTracking_MaintainItems"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCarMaintainTrackingMaintainItems.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


