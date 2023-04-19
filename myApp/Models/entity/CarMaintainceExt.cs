using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Howgreater.util;
namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class CarMaintainceExt : CarMaintaince
    //{
    //    public int create(String carID, String ticketID, long fileCreateDate, double maintainMile, long maintainDate, String maintainType, String maintainMemo, int corporationID, String maintainPerformBy, int maintainByDriver, double nextMaintainMile, long nextMaintainDate, int nextMaintainExecuted, double nextMaintainMile2, long nextMaintainDate2, int nextMaintainExecuted2)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarMaintaince(carID,ticketID,fileCreateDate,maintainMile,maintainDate,maintainType,maintainMemo,corporationID,maintainPerformBy,maintainByDriver,nextMaintainMile,nextMaintainDate,nextMaintainExecuted,nextMaintainMile2,nextMaintainDate2,nextMaintainExecuted2) values ('" + carID + "','" + ticketID + "'," + fileCreateDate + "," + maintainMile + "," + maintainDate + ",'" + maintainType + "','" + maintainMemo + "'," + corporationID + ",'" + maintainPerformBy + "'," + maintainByDriver + "," + nextMaintainMile + "," + nextMaintainDate + "," + nextMaintainExecuted + "," + nextMaintainMile2 + "," + nextMaintainDate2 + "," + nextMaintainExecuted2 + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintaince.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}
}