using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

using Howgreater.util;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class CustomerExt : Customer //新增Customer並回傳Customer.customerTID
    //{
    //    public int createBackIdentity(String companyName, String mainPhone, int custSourceID, String memo, String caution, int busAllian, String status)
    //    {
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into Customer(companyName,mainPhone,custSourceID,memo,caution,busAllian,status) values ('" + companyName + "','" + mainPhone + "'," + custSourceID + ",'" + memo + "','" + caution + "'," + busAllian + ",'" + status + "')";
    //            insertID = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerExt.createBackIdentity() : " + e.ToString());
    //        }
    //        return insertID;
    //    }
    //}
}