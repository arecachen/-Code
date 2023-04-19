using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{

    //public partial class EmployeePaymentRecord
    //{

    //    public Collection<EmployeePaymentRecord> findAll()
    //    {
    //        Collection<EmployeePaymentRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from EmployeePaymentRecord order by employeePaymentRecordTID asc", "EmployeePaymentRecord");
    //            if (ds.Tables["EmployeePaymentRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeePaymentRecord>();
    //                foreach (DataRow dr in ds.Tables["EmployeePaymentRecord"].Rows)
    //                {
    //                    EmployeePaymentRecord am = new EmployeePaymentRecord();
    //                    am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                    am.employeeSalaryID = Convert.ToInt32(dr["employeeSalaryID"]);
    //                    am.payYear = Convert.ToInt32(dr["payYear"]);
    //                    am.payMonth = Convert.ToInt32(dr["payMonth"]);
    //                    am.RegularTrip = Convert.ToInt32(dr["RegularTrip"]);
    //                    am.IrregularTrip = Convert.ToInt32(dr["IrregularTrip"]);
    //                    am.IrregularTip = Convert.ToInt32(dr["IrregularTip"]);
    //                    am.PerformanceAmount = Convert.ToInt32(dr["PerformanceAmount"]);
    //                    am.InsuranceAmount = Convert.ToInt32(dr["InsuranceAmount"]);
    //                    am.BorrowAmount = Convert.ToInt32(dr["BorrowAmount"]);
    //                    am.LeaveAmount = Convert.ToInt32(dr["LeaveAmount"]);
    //                    am.AddAmount = Convert.ToInt32(dr["AddAmount"]);
    //                    am.DeductionAmount = Convert.ToInt32(dr["DeductionAmount"]);
    //                    am.TotalSalary = Convert.ToInt32(dr["TotalSalary"]);
    //                    am.TotalPayable = Convert.ToInt32(dr["TotalPayable"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.PaymentDate = Convert.ToInt64(dr["PaymentDate"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.employeePaymentRecordTID = Convert.ToInt32(dr["employeePaymentRecordTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }
    //    public Collection<EmployeePaymentRecord> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeePaymentRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeePaymentRecord");
    //            if (ds.Tables["EmployeePaymentRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeePaymentRecord>();
    //                foreach (DataRow dr in ds.Tables["EmployeePaymentRecord"].Rows)
    //                {
    //                    EmployeePaymentRecord am = new EmployeePaymentRecord();
    //                    am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                    am.employeeSalaryID = Convert.ToInt32(dr["employeeSalaryID"]);
    //                    am.payYear = Convert.ToInt32(dr["payYear"]);
    //                    am.payMonth = Convert.ToInt32(dr["payMonth"]);
    //                    am.RegularTrip = Convert.ToInt32(dr["RegularTrip"]);
    //                    am.IrregularTrip = Convert.ToInt32(dr["IrregularTrip"]);
    //                    am.IrregularTip = Convert.ToInt32(dr["IrregularTip"]);
    //                    am.PerformanceAmount = Convert.ToInt32(dr["PerformanceAmount"]);
    //                    am.InsuranceAmount = Convert.ToInt32(dr["InsuranceAmount"]);
    //                    am.BorrowAmount = Convert.ToInt32(dr["BorrowAmount"]);
    //                    am.LeaveAmount = Convert.ToInt32(dr["LeaveAmount"]);
    //                    am.AddAmount = Convert.ToInt32(dr["AddAmount"]);
    //                    am.DeductionAmount = Convert.ToInt32(dr["DeductionAmount"]);
    //                    am.TotalSalary = Convert.ToInt32(dr["TotalSalary"]);
    //                    am.TotalPayable = Convert.ToInt32(dr["TotalPayable"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.PaymentDate = Convert.ToInt64(dr["PaymentDate"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.employeePaymentRecordTID = Convert.ToInt32(dr["employeePaymentRecordTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }
    //    public EmployeePaymentRecord findByPrimaryKey(int employeePaymentRecordTID)
    //    {
    //        EmployeePaymentRecord am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeePaymentRecord a WHERE a.employeePaymentRecordTID = " + employeePaymentRecordTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeePaymentRecord");
    //            if (ds.Tables["EmployeePaymentRecord"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeePaymentRecord"].Rows[0];
    //                am = new EmployeePaymentRecord();
    //                am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                am.employeeSalaryID = Convert.ToInt32(dr["employeeSalaryID"]);
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
    //    public int create(int employeeID, int employeeSalaryID, int payYear, int payMonth, double RegularTrip, double IrregularTrip, double IrregularTip, double PerformanceAmount, double InsuranceAmount, double BorrowAmount, double LeaveAmount, double AddAmount, double DeductionAmount, double TotalSalary, double TotalPayable, String memo, long PaymentDate, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(employeeID + ",");
    //            sb_value.Append(employeeSalaryID + ",");
    //            sb_value.Append(payYear + ",");
    //            sb_value.Append(payMonth + ",");
    //            sb_value.Append(RegularTrip + ",");
    //            sb_value.Append(IrregularTrip + ",");
    //            sb_value.Append(IrregularTip + ",");
    //            sb_value.Append(PerformanceAmount + ",");
    //            sb_value.Append(InsuranceAmount + ",");
    //            sb_value.Append(BorrowAmount + ",");
    //            sb_value.Append(LeaveAmount + ",");
    //            sb_value.Append(AddAmount + ",");
    //            sb_value.Append(DeductionAmount + ",");
    //            sb_value.Append(TotalSalary + ",");
    //            sb_value.Append(TotalPayable + ",");
    //            sb_value.Append((String.IsNullOrEmpty(memo) ? "null" : "N'" + Regex.Replace(memo, "'", "''") + "'") + ",");
    //            sb_value.Append(PaymentDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'"));

    //            String sqlCmd = "insert into EmployeePaymentRecord(employeeID,employeeSalaryID,payYear,payMonth,RegularTrip,IrregularTrip,IrregularTip,PerformanceAmount,InsuranceAmount,BorrowAmount,LeaveAmount,AddAmount,DeductionAmount,TotalSalary,TotalPayable,memo,PaymentDate,status) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public int Delete(int employeePaymentRecordTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from EmployeePaymentRecord where employeePaymentRecordTID = " + employeePaymentRecordTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.delete() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public int DeleteByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public int update(int employeeID, int employeeSalaryID, int payYear, int payMonth, double RegularTrip, double IrregularTrip, double IrregularTip, double PerformanceAmount, double InsuranceAmount, double BorrowAmount, double LeaveAmount, double AddAmount, double DeductionAmount, double TotalSalary, double TotalPayable, String memo, long PaymentDate, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("employeeID =" + employeeID + ",");
    //            sb_value.Append("employeeSalaryID =" + employeeSalaryID + ",");
    //            sb_value.Append("payYear =" + payYear + ",");
    //            sb_value.Append("payMonth =" + payMonth + ",");
    //            sb_value.Append("RegularTrip =" + RegularTrip + ",");
    //            sb_value.Append("IrregularTrip =" + IrregularTrip + ",");
    //            sb_value.Append("IrregularTip =" + IrregularTip + ",");
    //            sb_value.Append("PerformanceAmount =" + PerformanceAmount + ",");
    //            sb_value.Append("InsuranceAmount =" + InsuranceAmount + ",");
    //            sb_value.Append("BorrowAmount =" + BorrowAmount + ",");
    //            sb_value.Append("LeaveAmount =" + LeaveAmount + ",");
    //            sb_value.Append("AddAmount =" + AddAmount + ",");
    //            sb_value.Append("DeductionAmount =" + DeductionAmount + ",");
    //            sb_value.Append("TotalSalary =" + TotalSalary + ",");
    //            sb_value.Append("TotalPayable =" + TotalPayable + ",");
    //            sb_value.Append("memo=" + (String.IsNullOrEmpty(memo) ? "null" : "N'" + Regex.Replace(memo, "'", "''") + "'") + ",");
    //            sb_value.Append("PaymentDate =" + PaymentDate + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeePaymentRecord set  " + sb_value.ToString() + "  where employeePaymentRecordTID = " + this.employeePaymentRecordTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("employeeID =" + this.employeeID + ",");
    //            sb_value.Append("employeeSalaryID =" + this.employeeSalaryID + ",");
    //            sb_value.Append("payYear =" + this.payYear + ",");
    //            sb_value.Append("payMonth =" + this.payMonth + ",");
    //            sb_value.Append("RegularTrip =" + this.RegularTrip + ",");
    //            sb_value.Append("IrregularTrip =" + this.IrregularTrip + ",");
    //            sb_value.Append("IrregularTip =" + this.IrregularTip + ",");
    //            sb_value.Append("PerformanceAmount =" + this.PerformanceAmount + ",");
    //            sb_value.Append("InsuranceAmount =" + this.InsuranceAmount + ",");
    //            sb_value.Append("BorrowAmount =" + this.BorrowAmount + ",");
    //            sb_value.Append("LeaveAmount =" + this.LeaveAmount + ",");
    //            sb_value.Append("AddAmount =" + this.AddAmount + ",");
    //            sb_value.Append("DeductionAmount =" + this.DeductionAmount + ",");
    //            sb_value.Append("TotalSalary =" + this.TotalSalary + ",");
    //            sb_value.Append("TotalPayable =" + this.TotalPayable + ",");
    //            sb_value.Append("memo=" + (String.IsNullOrEmpty(this.memo) ? "null" : "N'" + Regex.Replace(this.memo, "'", "''") + "'") + ",");
    //            sb_value.Append("PaymentDate =" + this.PaymentDate + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(this.status) ? "''" : "N'" + Regex.Replace(this.status, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeePaymentRecord set  " + sb_value.ToString() + "  where employeePaymentRecordTID = " + this.employeePaymentRecordTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.update() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeePaymentRecord");
    //            if (ds.Tables["EmployeePaymentRecord"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeePaymentRecord"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeePaymentRecord.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}

}


