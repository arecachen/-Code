using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class EmployeeAttributesExt : EmployeeAttributes
    //{
    //    public Boolean findEmployeeMainHas(int EmployeeAttributesTID)
    //    {
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM EmployeeMain a WHERE a.EmployeeAttributesID = " + EmployeeAttributesTID;
    //            DataTable dt = new MssqlTool().findByKeywordDateTable(sqlCmd);
    //            if (dt != null && dt.Rows.Count > 0)
    //            {
    //                return false;
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAttributesExt.findEmployeeMainHas() : " + e.ToString());
    //        }
    //        return true;
    //    }
    //}
}