using Howgreater.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    //public partial class ViewCarMaintainTrackingMaintainItemsExt : view_CarMaintainTracking_MaintainItems
    //{
    //    public int CountOfProductsWithThisItemName { get; set; }
    //    public bool IsFirstRowWithThisItemName { get; set; }

    //    public List<ViewCarMaintainTrackingMaintainItemsExt> findTopByCarID(String carID, int topRecord = 6)
    //    {
    //        List<ViewCarMaintainTrackingMaintainItemsExt> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "Select * from view_CarMaintainTracking_MaintainItems WHERE CarID = '" + carID + "'  " +
    //                    "AND carMaintainTID IN (Select Top 6 carMaintainTID  FROM CarMaintaince WHERE CarID = '" + carID + "' order by maintainDate DESC)  " +
    //                    "ORDER By maintainDate Desc ";
    //            DataSet ds = my.select(sqlCmd, "view_CarMaintainTracking_MaintainItemsExt");
    //            if (ds.Tables["view_CarMaintainTracking_MaintainItemsExt"].Rows.Count > 0)
    //            {
    //                c = new List<ViewCarMaintainTrackingMaintainItemsExt>();
    //                foreach (DataRow dr in ds.Tables["view_CarMaintainTracking_MaintainItemsExt"].Rows)
    //                {

    //                    ViewCarMaintainTrackingMaintainItemsExt am = new ViewCarMaintainTrackingMaintainItemsExt();
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
    //}



}