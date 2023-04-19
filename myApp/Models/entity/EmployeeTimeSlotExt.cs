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
    //public partial class EmployeeTimeSlotExt : EmployeeTimeSlot
    //{
    //    public string updateEmplyeeTimeSlot(EmployeeTimeSlot ets)
    //    {
    //        String sqlCmd = "";
    //        try
    //        {
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("EmployeeSalaryID =" + ets.EmployeeSalaryID + ",");
    //            sb_value.Append("EmployeeMainID =" + ets.EmployeeMainID + ",");
    //            sb_value.Append("OrderCarRegularClassID =" + ets.OrderCarRegularClassID + ",");
    //            sb_value.Append("StartHourSlot =" + ets.StartHourSlot + ",");
    //            sb_value.Append("StartMinuteSlot =" + ets.StartMinuteSlot + ",");
    //            sb_value.Append("EndHourSlot =" + ets.EndHourSlot + ",");
    //            sb_value.Append("EndMinuteSlot =" + ets.EndMinuteSlot);

    //            sqlCmd = "update EmployeeTimeSlot set  " + sb_value.ToString() + "  where EmployeeTimeSlotTID = " + ets.EmployeeTimeSlotTID + ";";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.update() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }
    //}
}