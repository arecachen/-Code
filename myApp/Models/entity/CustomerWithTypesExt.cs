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
    //public partial class CustomerWithTypesExt : CustomerWithTypes
    //{
    //    public string createForString(int custID, int custTypeID)
    //    {
    //        string sqlCmd = "";
    //        try
    //        {
    //            sqlCmd = "insert into CustomerWithTypes(custID,custTypeID) values (" + custID + "," + custTypeID + ");";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.createForString() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }


    //    public string DeleteForString(int CustomerWithTypeTID)
    //    {
    //        String sqlCmd = "";
    //        try
    //        {
    //            sqlCmd = "delete from CustomerWithTypes where CustomerWithTypeTID = " + CustomerWithTypeTID + "; ";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.DeleteForString() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }
    //}
}