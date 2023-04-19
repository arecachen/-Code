using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

using Howgreater.util;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class CarWithEquipmentExt : CarWithEquipment 
    //{
    //    public int updateByCarID(String carID, int carEquipID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarWithEquipment set carEquipID =" + carEquipID + " where carID = " + carID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}
}