using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

using Howgreater.util;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class CustomerUniCodeExt : CustomerUniCode //新增CustomerContact並回傳CustomerContact.customerContactTID
    //{
    //    public int createBackIdentity(int custID, String uniCode, String uniName)
    //    {
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CustomerUniCode(custID,uniCode,uniName) values (" + custID + ",'" + uniCode + "','" + uniName + "')";
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