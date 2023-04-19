using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Howgreater.util;
using System.Data;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class CarMainExt : CarMain 
    //{
    //    public int updateByCarID(String CarID, int carManuYear, int carManuMonth, String carMake, int carSite, String carSize, long purchaseDate, double purchaseAmount, double purchaseMile, long SellDate, int driver, String memo, int busAllian, int maintainMileRange, int maintainDaysRange, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarMain set carManuYear =" + carManuYear + ",carManuMonth =" + carManuMonth + ",carMake ='" + carMake + "',carSite =" + carSite + ",carSize ='" + carSize + "',purchaseDate =" + purchaseDate + ",purchaseAmount =" + purchaseAmount + ",purchaseMile =" + purchaseMile + ",SellDate =" + SellDate + ",driver =" + driver + ",memo ='" + memo + "', busAllian = " + busAllian + ", maintainMileRange = " + maintainMileRange + ", maintainDaysRange = " + maintainDaysRange + ", status ='" + status + "' where CarID = '" + CarID + "';";
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }

    //    public EmployeeMain findDriverInfo(String carID)
    //    {
    //        EmployeeMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeeMain a WHERE a.employeeTID = (Select top 1 driver from CarMain where CarID='" + carID + "')";
    //            DataSet ds = my.select(sqlCmd, "EmployeeMain");
    //            if (ds.Tables["EmployeeMain"].Rows.Count >= 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeMain"].Rows[0];
    //                am = new EmployeeMain();
    //                am.employeeTID = Convert.ToInt32(dr["employeeTID"]);
    //                am.empID = Convert.ToString(dr["empID"]);
    //                am.empNID = Convert.ToString(dr["empNID"]);
    //                am.empName = Convert.ToString(dr["empName"]);
    //                am.empDOB = Convert.ToInt64(dr["empDOB"]);
    //                am.empSex = Convert.ToString(dr["empSex"]);
    //                am.empMainContact = Convert.ToString(dr["empMainContact"]);
    //                am.empSecondContact = Convert.ToString(dr["empSecondContact"]);
    //                am.empDuty = Convert.ToString(dr["empDuty"]);
    //                am.empGrade = Convert.ToString(dr["empGrade"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }

    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CatMainExt.findDriverInfo() : " + e.ToString());
    //        }
    //        return am;
    //    }

    //    //Replace by entity.carFuelrecordExt.cs
    //    //public Int64 lastMileInSystem(String CarID)
    //    //{
    //    //    String sqlCmd = "Select Max(fuelMile) as lastMile from CarFuelRecord where carID='"+CarID+"'";

    //    //    Int64 count = 0;
    //    //    try
    //    //    {
    //    //        MssqlTool my = new MssqlTool();
    //    //        DataSet ds = my.select(sqlCmd, "CarFuelRecord");
    //    //        if (ds.Tables["CarFuelRecord"].Rows.Count > 0)
    //    //        {
    //    //            DataRow dr = ds.Tables["CarFuelRecord"].Rows[0];
    //    //            count = Convert.ToInt64(dr[0]);
    //    //        }
    //    //    }
    //    //    catch (Exception e)
    //    //    {
    //    //        count = 0;
    //    //        new log().wiriteSystemLog("hsintongERP2022.Models.CarMainExt.lastMileInSystem() : " + e.ToString());
    //    //    }
    //    //    return count;
    //    //}
    //}
}