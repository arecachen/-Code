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
    //public partial class OrderCarInfoPayRecordExt : OrderCarInfoPayRecord
    //{
    //    public int create(int orderCarInfoID, long paymentReceiveDate, double paymentAmount, int paymentInFull, String payDriveType, double payDriverAmount)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarInfoPayRecord(orderCarInfoID,paymentReceiveDate,paymentAmount,paymentInFull,payDriveType,payDriverAmount) values (" + orderCarInfoID + "," + paymentReceiveDate + "," + paymentAmount + "," + paymentInFull + ",'" + payDriveType + "'," + payDriverAmount + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}
}