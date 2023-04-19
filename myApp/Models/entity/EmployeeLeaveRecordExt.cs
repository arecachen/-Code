using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class EmployeeLeaveRecordExt : EmployeeLeaveRecord
    //{
    //    public String updateExt(EmployeeLeaveRecord el)
    //    {
    //        String sqlCmd = "";
    //        try
    //        {
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("employeeID =" + el.employeeID + ",");
    //            sb_value.Append("employeePaymentRecordID =" + el.employeePaymentRecordID + ",");
    //            sb_value.Append("applyDate =" + el.applyDate + ",");
    //            sb_value.Append("leaveDate =" + el.leaveDate + ",");
    //            sb_value.Append("leaveTimeStartHour =" + el.leaveTimeStartHour + ",");
    //            sb_value.Append("leaveTimeStartMin =" + el.leaveTimeStartMin + ",");
    //            sb_value.Append("leaveTimeEndHour =" + el.leaveTimeEndHour + ",");
    //            sb_value.Append("leaveTimeEndMin =" + el.leaveTimeEndMin + ",");
    //            sb_value.Append("leaveReason=" + (String.IsNullOrEmpty(el.leaveReason) ? "null" : "N'" + Regex.Replace(el.leaveReason, "'", "''") + "'") + ",");
    //            sb_value.Append("salaryDeduct =" + el.salaryDeduct + ",");
    //            sb_value.Append("leaveType=" + (String.IsNullOrEmpty(el.leaveType) ? "''" : "N'" + Regex.Replace(el.leaveType, "'", "''") + "'") + ",");
    //            sb_value.Append("leaveApplyStatus=" + (String.IsNullOrEmpty(el.leaveApplyStatus) ? "''" : "N'" + Regex.Replace(el.leaveApplyStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("salaryDeductStatus =" + el.salaryDeductStatus + ",");
    //            sb_value.Append("salaryDeductDate =" + el.salaryDeductDate + ",");
    //            sb_value.Append("leaveEndDate =" + el.leaveEndDate + ",");
    //            sb_value.Append("leaveTotalHour =" + el.leaveTotalHour);

    //            sqlCmd = "update EmployeeLeaveRecord set  " + sb_value.ToString() + "  where employeeLeaveTID = " + el.employeeLeaveTID + ";";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.update() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }
    //}
}