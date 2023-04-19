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
    //public partial class EmployeePaymentRecordExt : EmployeePaymentRecord
    //{
    //    public string createByEmployeePaymentRecord(EmployeePaymentRecord epr)
    //    {
    //        String sqlCmd = "";
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(epr.employeeID + ",");
    //            sb_value.Append(epr.employeeSalaryID + ",");
    //            sb_value.Append(epr.payYear + ",");
    //            sb_value.Append(epr.payMonth + ",");
    //            sb_value.Append(epr.RegularTrip + ",");
    //            sb_value.Append(epr.IrregularTrip + ",");
    //            sb_value.Append(epr.IrregularTip + ",");
    //            sb_value.Append(epr.PerformanceAmount + ",");
    //            sb_value.Append(epr.InsuranceAmount + ",");
    //            sb_value.Append(epr.BorrowAmount + ",");
    //            sb_value.Append(epr.LeaveAmount + ",");
    //            sb_value.Append(epr.AddAmount + ",");
    //            sb_value.Append(epr.DeductionAmount + ",");
    //            sb_value.Append(epr.TotalSalary + ",");
    //            sb_value.Append(epr.TotalPayable + ",");
    //            sb_value.Append((String.IsNullOrEmpty(epr.memo) ? "null" : "N'" + Regex.Replace(epr.memo, "'", "''") + "'") + ",");
    //            sb_value.Append(epr.PaymentDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(epr.status) ? "''" : "N'" + Regex.Replace(epr.status, "'", "''") + "'"));

    //            sqlCmd = "insert into EmployeePaymentRecord(employeeID,employeeSalaryID,payYear,payMonth,RegularTrip,IrregularTrip,IrregularTip,PerformanceAmount,InsuranceAmount,BorrowAmount,LeaveAmount,AddAmount,DeductionAmount,TotalSalary,TotalPayable,memo,PaymentDate,status) values (" + sb_value.ToString() + ")";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.create() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }

    //    public string updateByEmployeePaymentRecord(EmployeePaymentRecord epr)
    //    {
    //        String sqlCmd = "";
    //        try
    //        {
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("employeeID =" + epr.employeeID + ",");
    //            sb_value.Append("employeeSalaryID =" + epr.employeeSalaryID + ",");
    //            sb_value.Append("payYear =" + epr.payYear + ",");
    //            sb_value.Append("payMonth =" + epr.payMonth + ",");
    //            sb_value.Append("RegularTrip =" + epr.RegularTrip + ",");
    //            sb_value.Append("IrregularTrip =" + epr.IrregularTrip + ",");
    //            sb_value.Append("IrregularTip =" + epr.IrregularTip + ",");
    //            sb_value.Append("PerformanceAmount =" + epr.PerformanceAmount + ",");
    //            sb_value.Append("InsuranceAmount =" + epr.InsuranceAmount + ",");
    //            sb_value.Append("BorrowAmount =" + epr.BorrowAmount + ",");
    //            sb_value.Append("LeaveAmount =" + epr.LeaveAmount + ",");
    //            sb_value.Append("AddAmount =" + epr.AddAmount + ",");
    //            sb_value.Append("DeductionAmount =" + epr.DeductionAmount + ",");
    //            sb_value.Append("TotalSalary =" + epr.TotalSalary + ",");
    //            sb_value.Append("TotalPayable =" + epr.TotalPayable + ",");
    //            sb_value.Append("memo=" + (String.IsNullOrEmpty(epr.memo) ? "null" : "N'" + Regex.Replace(epr.memo, "'", "''") + "'") + ",");
    //            sb_value.Append("PaymentDate =" + epr.PaymentDate + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(epr.status) ? "''" : "N'" + Regex.Replace(epr.status, "'", "''") + "'"));

    //            sqlCmd = "update EmployeePaymentRecord set  " + sb_value.ToString() + "  where employeePaymentRecordTID = " + epr.employeePaymentRecordTID + "; ";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.update() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }

    //    public EmployeePaymentRecord findByEmpIDonDate(int empID, int year, int month)
    //    {
    //        EmployeePaymentRecord am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeePaymentRecord a WHERE a.employeeID = " + empID + " AND payYear = " + year + " AND payMonth = " + month + " ";
    //            DataSet ds = my.select(sqlCmd, "EmployeePaymentRecord");
    //            if (ds.Tables["EmployeePaymentRecord"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeePaymentRecord"].Rows[0];
    //                am = new EmployeePaymentRecord();
    //                am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                am.payYear = Convert.ToInt32(dr["payYear"]);
    //                am.payMonth = Convert.ToInt32(dr["payMonth"]);
    //                am.RegularTrip = Convert.ToInt32(dr["RegularTrip"]);
    //                am.IrregularTrip = Convert.ToInt32(dr["IrregularTrip"]);
    //                am.IrregularTip = Convert.ToInt32(dr["IrregularTip"]);
    //                am.PerformanceAmount = Convert.ToInt32(dr["PerformanceAmount"]);
    //                am.InsuranceAmount = Convert.ToInt32(dr["InsuranceAmount"]);
    //                am.BorrowAmount = Convert.ToInt32(dr["BorrowAmount"]);
    //                am.LeaveAmount = Convert.ToInt32(dr["LeaveAmount"]);
    //                am.AddAmount = Convert.ToInt32(dr["AddAmount"]);
    //                am.DeductionAmount = Convert.ToInt32(dr["DeductionAmount"]);
    //                am.TotalSalary = Convert.ToInt32(dr["TotalSalary"]);
    //                am.TotalPayable = Convert.ToInt32(dr["TotalPayable"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.PaymentDate = Convert.ToInt64(dr["PaymentDate"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.employeePaymentRecordTID = Convert.ToInt32(dr["employeePaymentRecordTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }
    //}
}