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
   
    //public partial class EmployeeLeaveRecord
    //{
  
    //    #region Sql
    //    public Collection<EmployeeLeaveRecord> findAll()
    //    {
    //        Collection<EmployeeLeaveRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from EmployeeLeaveRecord order by employeeLeaveTID asc", "EmployeeLeaveRecord");
    //            if (ds.Tables["EmployeeLeaveRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeLeaveRecord>();
    //                foreach (DataRow dr in ds.Tables["EmployeeLeaveRecord"].Rows)
    //                {
    //                    EmployeeLeaveRecord am = new EmployeeLeaveRecord();
    //                    am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                    am.employeePaymentRecordID = Convert.ToInt32(dr["employeePaymentRecordID"]);
    //                    am.applyDate = dr["applyDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["applyDate"]);
    //                    am.leaveDate = Convert.ToInt64(dr["leaveDate"]);
    //                    am.leaveTimeStartHour = Convert.ToInt32(dr["leaveTimeStartHour"]);
    //                    am.leaveTimeStartMin = Convert.ToInt32(dr["leaveTimeStartMin"]);
    //                    am.leaveTimeEndHour = Convert.ToInt32(dr["leaveTimeEndHour"]);
    //                    am.leaveTimeEndMin = Convert.ToInt32(dr["leaveTimeEndMin"]);
    //                    am.leaveReason = Convert.ToString(dr["leaveReason"]);
    //                    am.salaryDeduct = Convert.ToInt32(dr["salaryDeduct"]);
    //                    am.leaveType = Convert.ToString(dr["leaveType"]);
    //                    am.leaveApplyStatus = Convert.ToString(dr["leaveApplyStatus"]);
    //                    am.salaryDeductStatus = Convert.ToInt32(dr["salaryDeductStatus"]);
    //                    am.salaryDeductDate = Convert.ToInt64(dr["salaryDeductDate"]);
    //                    am.leaveEndDate = Convert.ToInt64(dr["leaveEndDate"]);
    //                    am.leaveTotalHour = Convert.ToInt32(dr["leaveTotalHour"]);
    //                    am.employeeLeaveTID = Convert.ToInt32(dr["employeeLeaveTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeLeaveRecord> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeLeaveRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeLeaveRecord");
    //            if (ds.Tables["EmployeeLeaveRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeLeaveRecord>();
    //                foreach (DataRow dr in ds.Tables["EmployeeLeaveRecord"].Rows)
    //                {
    //                    EmployeeLeaveRecord am = new EmployeeLeaveRecord();
    //                    am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                    am.employeePaymentRecordID = Convert.ToInt32(dr["employeePaymentRecordID"]);
    //                    am.applyDate = dr["applyDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["applyDate"]);
    //                    am.leaveDate = Convert.ToInt64(dr["leaveDate"]);
    //                    am.leaveTimeStartHour = Convert.ToInt32(dr["leaveTimeStartHour"]);
    //                    am.leaveTimeStartMin = Convert.ToInt32(dr["leaveTimeStartMin"]);
    //                    am.leaveTimeEndHour = Convert.ToInt32(dr["leaveTimeEndHour"]);
    //                    am.leaveTimeEndMin = Convert.ToInt32(dr["leaveTimeEndMin"]);
    //                    am.leaveReason = Convert.ToString(dr["leaveReason"]);
    //                    am.salaryDeduct = Convert.ToInt32(dr["salaryDeduct"]);
    //                    am.leaveType = Convert.ToString(dr["leaveType"]);
    //                    am.leaveApplyStatus = Convert.ToString(dr["leaveApplyStatus"]);
    //                    am.salaryDeductStatus = Convert.ToInt32(dr["salaryDeductStatus"]);
    //                    am.salaryDeductDate = Convert.ToInt64(dr["salaryDeductDate"]);
    //                    am.leaveEndDate = Convert.ToInt64(dr["leaveEndDate"]);
    //                    am.leaveTotalHour = Convert.ToInt32(dr["leaveTotalHour"]);
    //                    am.employeeLeaveTID = Convert.ToInt32(dr["employeeLeaveTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeLeaveRecord findByPrimaryKey(int employeeLeaveTID)
    //    {
    //        EmployeeLeaveRecord am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM EmployeeLeaveRecord a WHERE a.employeeLeaveTID = " + employeeLeaveTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeLeaveRecord");
    //            if (ds.Tables["EmployeeLeaveRecord"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeLeaveRecord"].Rows[0];
    //                am = new EmployeeLeaveRecord();
    //                am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                am.employeePaymentRecordID = Convert.ToInt32(dr["employeePaymentRecordID"]);
    //                am.applyDate = dr["applyDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["applyDate"]);
    //                am.leaveDate = Convert.ToInt64(dr["leaveDate"]);
    //                am.leaveTimeStartHour = Convert.ToInt32(dr["leaveTimeStartHour"]);
    //                am.leaveTimeStartMin = Convert.ToInt32(dr["leaveTimeStartMin"]);
    //                am.leaveTimeEndHour = Convert.ToInt32(dr["leaveTimeEndHour"]);
    //                am.leaveTimeEndMin = Convert.ToInt32(dr["leaveTimeEndMin"]);
    //                am.leaveReason = Convert.ToString(dr["leaveReason"]);
    //                am.salaryDeduct = Convert.ToInt32(dr["salaryDeduct"]);
    //                am.leaveType = Convert.ToString(dr["leaveType"]);
    //                am.leaveApplyStatus = Convert.ToString(dr["leaveApplyStatus"]);
    //                am.salaryDeductStatus = Convert.ToInt32(dr["salaryDeductStatus"]);
    //                am.salaryDeductDate = Convert.ToInt64(dr["salaryDeductDate"]);
    //                am.leaveEndDate = Convert.ToInt64(dr["leaveEndDate"]);
    //                am.leaveTotalHour = Convert.ToInt32(dr["leaveTotalHour"]);
    //                am.employeeLeaveTID = Convert.ToInt32(dr["employeeLeaveTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int employeeID, int employeePaymentRecordID, long applyDate, long leaveDate, int leaveTimeStartHour, int leaveTimeStartMin, int leaveTimeEndHour, int leaveTimeEndMin, String leaveReason, double salaryDeduct, String leaveType, String leaveApplyStatus, int salaryDeductStatus, long salaryDeductDate, long leaveEndDate, int leaveTotalHour)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(employeeID + ",");
    //            sb_value.Append(employeePaymentRecordID + ",");
    //            sb_value.Append(applyDate + ",");
    //            sb_value.Append(leaveDate + ",");
    //            sb_value.Append(leaveTimeStartHour + ",");
    //            sb_value.Append(leaveTimeStartMin + ",");
    //            sb_value.Append(leaveTimeEndHour + ",");
    //            sb_value.Append(leaveTimeEndMin + ",");
    //            sb_value.Append((String.IsNullOrEmpty(leaveReason) ? "null" : "N'" + Regex.Replace(leaveReason, "'", "''") + "'") + ",");
    //            sb_value.Append(salaryDeduct + ",");
    //            sb_value.Append((String.IsNullOrEmpty(leaveType) ? "''" : "N'" + Regex.Replace(leaveType, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(leaveApplyStatus) ? "''" : "N'" + Regex.Replace(leaveApplyStatus, "'", "''") + "'") + ",");
    //            sb_value.Append(salaryDeductStatus + ",");
    //            sb_value.Append(salaryDeductDate + ",");
    //            sb_value.Append(leaveEndDate + ",");
    //            sb_value.Append(leaveTotalHour);

    //            String sqlCmd = "insert into EmployeeLeaveRecord(employeeID,employeePaymentRecordID,applyDate,leaveDate,leaveTimeStartHour,leaveTimeStartMin,leaveTimeEndHour,leaveTimeEndMin,leaveReason,salaryDeduct,leaveType,leaveApplyStatus,salaryDeductStatus,salaryDeductDate,leaveEndDate,leaveTotalHour) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int employeeLeaveTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from EmployeeLeaveRecord where employeeLeaveTID = " + employeeLeaveTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.delete() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int DeleteByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int employeeID, int employeePaymentRecordID, long applyDate, long leaveDate, int leaveTimeStartHour, int leaveTimeStartMin, int leaveTimeEndHour, int leaveTimeEndMin, String leaveReason, decimal salaryDeduct, String leaveType, String leaveApplyStatus, int salaryDeductStatus, long salaryDeductDate, long leaveEndDate, int leaveTotalHour)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("employeeID =" + employeeID + ",");
    //            sb_value.Append("employeePaymentRecordID =" + employeePaymentRecordID + ",");
    //            sb_value.Append("applyDate =" + applyDate + ",");
    //            sb_value.Append("leaveDate =" + leaveDate + ",");
    //            sb_value.Append("leaveTimeStartHour =" + leaveTimeStartHour + ",");
    //            sb_value.Append("leaveTimeStartMin =" + leaveTimeStartMin + ",");
    //            sb_value.Append("leaveTimeEndHour =" + leaveTimeEndHour + ",");
    //            sb_value.Append("leaveTimeEndMin =" + leaveTimeEndMin + ",");
    //            sb_value.Append("leaveReason=" + (String.IsNullOrEmpty(leaveReason) ? "null" : "N'" + Regex.Replace(leaveReason, "'", "''") + "'") + ",");
    //            sb_value.Append("salaryDeduct =" + salaryDeduct + ",");
    //            sb_value.Append("leaveType=" + (String.IsNullOrEmpty(leaveType) ? "''" : "N'" + Regex.Replace(leaveType, "'", "''") + "'") + ",");
    //            sb_value.Append("leaveApplyStatus=" + (String.IsNullOrEmpty(leaveApplyStatus) ? "''" : "N'" + Regex.Replace(leaveApplyStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("salaryDeductStatus =" + salaryDeductStatus + ",");
    //            sb_value.Append("salaryDeductDate =" + salaryDeductDate + ",");
    //            sb_value.Append("leaveEndDate =" + leaveEndDate + ",");
    //            sb_value.Append("leaveTotalHour =" + leaveTotalHour);

    //            String sqlCmd = "update EmployeeLeaveRecord set  " + sb_value.ToString() + "  where employeeLeaveTID = " + this.employeeLeaveTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("employeeID =" + this.employeeID + ",");
    //            sb_value.Append("employeePaymentRecordID =" + this.employeePaymentRecordID + ",");
    //            sb_value.Append("applyDate =" + this.applyDate + ",");
    //            sb_value.Append("leaveDate =" + this.leaveDate + ",");
    //            sb_value.Append("leaveTimeStartHour =" + this.leaveTimeStartHour + ",");
    //            sb_value.Append("leaveTimeStartMin =" + this.leaveTimeStartMin + ",");
    //            sb_value.Append("leaveTimeEndHour =" + this.leaveTimeEndHour + ",");
    //            sb_value.Append("leaveTimeEndMin =" + this.leaveTimeEndMin + ",");
    //            sb_value.Append("leaveReason=" + (String.IsNullOrEmpty(this.leaveReason) ? "null" : "N'" + Regex.Replace(this.leaveReason, "'", "''") + "'") + ",");
    //            sb_value.Append("salaryDeduct =" + this.salaryDeduct + ",");
    //            sb_value.Append("leaveType=" + (String.IsNullOrEmpty(this.leaveType) ? "''" : "N'" + Regex.Replace(this.leaveType, "'", "''") + "'") + ",");
    //            sb_value.Append("leaveApplyStatus=" + (String.IsNullOrEmpty(this.leaveApplyStatus) ? "''" : "N'" + Regex.Replace(this.leaveApplyStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("salaryDeductStatus =" + this.salaryDeductStatus + ",");
    //            sb_value.Append("salaryDeductDate =" + this.salaryDeductDate + ",");
    //            sb_value.Append("leaveEndDate =" + this.leaveEndDate + ",");
    //            sb_value.Append("leaveTotalHour =" + this.leaveTotalHour);

    //            String sqlCmd = "update EmployeeLeaveRecord set  " + sb_value.ToString() + "  where employeeLeaveTID = " + this.employeeLeaveTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeLeaveRecord");
    //            if (ds.Tables["EmployeeLeaveRecord"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeLeaveRecord"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeLeaveRecord.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }

    //    #endregion Sql
    //}

}


