using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class OrderRegularExt : OrderRegular
    //{
    //    public int create(int orderCarID, String payTerm, String payPeriod, double payAmount, double payTermAmount, int payPeriodCount, int orderCostScheduleID)
    //    {
    //        int count = 0;
    //        String orderCostScheduleIDString = "NULL";
    //        if (orderCostScheduleID != -999)
    //            orderCostScheduleIDString = orderCostScheduleID.ToString();
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderRegular(orderCarID,payTerm,payPeriod,payAmount,payTermAmount,payPeriodCount,orderCostScheduleID) values (" + orderCarID + ",'" + payTerm + "','" + payPeriod + "'," + payAmount + "," + payTermAmount + "," + payPeriodCount + "," + orderCostScheduleIDString + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderRegular.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}
}