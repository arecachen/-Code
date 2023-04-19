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
    //public partial class EmployeeAdvPaymentExt : EmployeeAdvPayment
    //{
    //    public String updateExt(EmployeeAdvPayment ea)
    //    {
    //        String sqlCmd = "";
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("employeeID =" + ea.employeeID + ",");
    //            sb_value.Append("empContact=" + (String.IsNullOrEmpty(ea.empContact) ? "''" : "N'" + Regex.Replace(ea.empContact, "'", "''") + "'") + ",");
    //            sb_value.Append("empCashDatetime =" + ea.empCashDatetime + ",");
    //            sb_value.Append("empCashAmount =" + ea.empCashAmount + ",");
    //            sb_value.Append("empCashMemo=" + (String.IsNullOrEmpty(ea.empCashMemo) ? "null" : "N'" + Regex.Replace(ea.empCashMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("empRepaid =" + ea.empRepaid + ",");
    //            sb_value.Append("empRepaidSalaryID =" + ea.empPaymentRecordID + ",");
    //            sb_value.Append("empRepaidDate =" + ea.empRepaidDate + ",");
    //            sb_value.Append("cashRecordBy =" + ea.cashRecordBy + ",");
    //            sb_value.Append("cashUpdateBy =" + ea.cashUpdateBy + ",");
    //            sb_value.Append("cashRecordDatetime =" + ea.cashRecordDatetime + ",");
    //            sb_value.Append("cashLastUpadteDatetime =" + ea.cashLastUpadteDatetime);

    //            sqlCmd = "update EmployeeAdvPayment set  " + sb_value.ToString() + "  where employeeAdvPaymentTID = " + ea.employeeAdvPaymentTID + ";";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.update() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }
    //}
}