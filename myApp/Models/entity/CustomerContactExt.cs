using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

using Howgreater.util;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class CustomerContactExt : CustomerContact //新增CustomerContact並回傳CustomerContact.customerContactTID
    //{
    //    public int createBackIdentity(int custID, String custName, String custPhone, String custMobile, String custEmail, String custFax, String memo)
    //    {
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CustomerContact(custID,custName,custPhone,custMobile,custEmail,custFax,memo) values (" + custID + ",'" + custName + "','" + custPhone + "','" + custMobile + "','" + custEmail + "','" + custFax + "','" + memo + "')";
    //            insertID = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContactExt.createBackIdentity() : " + e.ToString());
    //        }
    //        return insertID;
    //    }
    //}
}