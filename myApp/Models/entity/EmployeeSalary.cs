using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
namespace hsintongERP2022.Models
{
    //public partial class EmployeeSalary
    //{

    //    public Collection<EmployeeSalary> findAll()
    //    {
    //        Collection<EmployeeSalary> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from EmployeeSalary order by employeeSalaryTID asc", "EmployeeSalary");
    //            if (ds.Tables["EmployeeSalary"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeSalary>();
    //                foreach (DataRow dr in ds.Tables["EmployeeSalary"].Rows)
    //                {
    //                    EmployeeSalary am = new EmployeeSalary();
    //                    am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                    am.OrderCarRegularGroupID = Convert.ToInt32(dr["OrderCarRegularGroupID"]);
    //                    am.empBeginDate = Convert.ToInt64(dr["empBeginDate"]);
    //                    am.empEndDate = dr["empEndDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["empEndDate"]);
    //                    am.empSalary = Convert.ToInt32(dr["empSalary"]);
    //                    am.empAward = Convert.ToInt32(dr["empAward"]);
    //                    am.empRespBonus = Convert.ToInt32(dr["empRespBonus"]);
    //                    am.empDutyAward = Convert.ToInt32(dr["empDutyAward"]);
    //                    am.empSpecialBonus = Convert.ToInt32(dr["empSpecialBonus"]);
    //                    am.empLabourComp = Convert.ToInt32(dr["empLabourComp"]);
    //                    am.empLabourSelf = Convert.ToInt32(dr["empLabourSelf"]);
    //                    am.empNhiComp = Convert.ToInt32(dr["empNhiComp"]);
    //                    am.empNhiSelf = Convert.ToInt32(dr["empNhiSelf"]);
    //                    am.empSuperComp = Convert.ToInt32(dr["empSuperComp"]);
    //                    am.empSuperSelf = Convert.ToInt32(dr["empSuperSelf"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.empStatus = Convert.ToString(dr["empStatus"]);
    //                    am.employeeSalaryTID = Convert.ToInt32(dr["employeeSalaryTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeSalary> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeSalary> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeSalary");
    //            if (ds.Tables["EmployeeSalary"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeSalary>();
    //                foreach (DataRow dr in ds.Tables["EmployeeSalary"].Rows)
    //                {
    //                    EmployeeSalary am = new EmployeeSalary();
    //                    am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                    am.OrderCarRegularGroupID = Convert.ToInt32(dr["OrderCarRegularGroupID"]);
    //                    am.empBeginDate = Convert.ToInt64(dr["empBeginDate"]);
    //                    am.empEndDate = dr["empEndDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["empEndDate"]);
    //                    am.empSalary = Convert.ToInt32(dr["empSalary"]);
    //                    am.empAward = Convert.ToInt32(dr["empAward"]);
    //                    am.empRespBonus = Convert.ToInt32(dr["empRespBonus"]);
    //                    am.empDutyAward = Convert.ToInt32(dr["empDutyAward"]);
    //                    am.empSpecialBonus = Convert.ToInt32(dr["empSpecialBonus"]);
    //                    am.empLabourComp = Convert.ToInt32(dr["empLabourComp"]);
    //                    am.empLabourSelf = Convert.ToInt32(dr["empLabourSelf"]);
    //                    am.empNhiComp = Convert.ToInt32(dr["empNhiComp"]);
    //                    am.empNhiSelf = Convert.ToInt32(dr["empNhiSelf"]);
    //                    am.empSuperComp = Convert.ToInt32(dr["empSuperComp"]);
    //                    am.empSuperSelf = Convert.ToInt32(dr["empSuperSelf"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.empStatus = Convert.ToString(dr["empStatus"]);
    //                    am.employeeSalaryTID = Convert.ToInt32(dr["employeeSalaryTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeSalary findByPrimaryKey(int employeeSalaryTID)
    //    {
    //        EmployeeSalary am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM EmployeeSalary a WHERE a.employeeSalaryTID = " + employeeSalaryTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeSalary");
    //            if (ds.Tables["EmployeeSalary"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeSalary"].Rows[0];
    //                am = new EmployeeSalary();
    //                am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                am.OrderCarRegularGroupID = Convert.ToInt32(dr["OrderCarRegularGroupID"]);
    //                am.empBeginDate = Convert.ToInt64(dr["empBeginDate"]);
    //                am.empEndDate = dr["empEndDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["empEndDate"]);
    //                am.empSalary = Convert.ToInt32(dr["empSalary"]);
    //                am.empAward = Convert.ToInt32(dr["empAward"]);
    //                am.empRespBonus = Convert.ToInt32(dr["empRespBonus"]);
    //                am.empDutyAward = Convert.ToInt32(dr["empDutyAward"]);
    //                am.empSpecialBonus = Convert.ToInt32(dr["empSpecialBonus"]);
    //                am.empLabourComp = Convert.ToInt32(dr["empLabourComp"]);
    //                am.empLabourSelf = Convert.ToInt32(dr["empLabourSelf"]);
    //                am.empNhiComp = Convert.ToInt32(dr["empNhiComp"]);
    //                am.empNhiSelf = Convert.ToInt32(dr["empNhiSelf"]);
    //                am.empSuperComp = Convert.ToInt32(dr["empSuperComp"]);
    //                am.empSuperSelf = Convert.ToInt32(dr["empSuperSelf"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.empStatus = Convert.ToString(dr["empStatus"]);
    //                am.employeeSalaryTID = Convert.ToInt32(dr["employeeSalaryTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int employeeID, int OrderCarRegularGroupID, long empBeginDate, long empEndDate, double empSalary, double empAward, double empRespBonus, double empDutyAward, double empSpecialBonus, double empLabourComp, double empLabourSelf, double empNhiComp, double empNhiSelf, double empSuperComp, double empSuperSelf, String memo, String empStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(employeeID + ",");
    //            sb_value.Append(OrderCarRegularGroupID + ",");
    //            sb_value.Append(empBeginDate + ",");
    //            sb_value.Append(empEndDate + ",");
    //            sb_value.Append(empSalary + ",");
    //            sb_value.Append(empAward + ",");
    //            sb_value.Append(empRespBonus + ",");
    //            sb_value.Append(empDutyAward + ",");
    //            sb_value.Append(empSpecialBonus + ",");
    //            sb_value.Append(empLabourComp + ",");
    //            sb_value.Append(empLabourSelf + ",");
    //            sb_value.Append(empNhiComp + ",");
    //            sb_value.Append(empNhiSelf + ",");
    //            sb_value.Append(empSuperComp + ",");
    //            sb_value.Append(empSuperSelf + ",");
    //            sb_value.Append((String.IsNullOrEmpty(memo) ? "null" : "N'" + Regex.Replace(memo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(empStatus) ? "''" : "N'" + Regex.Replace(empStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into EmployeeSalary(employeeID,OrderCarRegularGroupID,empBeginDate,empEndDate,empSalary,empAward,empRespBonus,empDutyAward,empSpecialBonus,empLabourComp,empLabourSelf,empNhiComp,empNhiSelf,empSuperComp,empSuperSelf,memo,empStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int employeeSalaryTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from EmployeeSalary where employeeSalaryTID = " + employeeSalaryTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int employeeID, int OrderCarRegularGroupID, long empBeginDate, long empEndDate, double empSalary, double empAward, double empRespBonus, double empDutyAward, double empSpecialBonus, double empLabourComp, double empLabourSelf, double empNhiComp, double empNhiSelf, double empSuperComp, double empSuperSelf, String memo, String empStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("employeeID =" + employeeID + ",");
    //            sb_value.Append("OrderCarRegularGroupID =" + OrderCarRegularGroupID + ",");
    //            sb_value.Append("empBeginDate =" + empBeginDate + ",");
    //            sb_value.Append("empEndDate =" + empEndDate + ",");
    //            sb_value.Append("empSalary =" + empSalary + ",");
    //            sb_value.Append("empAward =" + empAward + ",");
    //            sb_value.Append("empRespBonus =" + empRespBonus + ",");
    //            sb_value.Append("empDutyAward =" + empDutyAward + ",");
    //            sb_value.Append("empSpecialBonus =" + empSpecialBonus + ",");
    //            sb_value.Append("empLabourComp =" + empLabourComp + ",");
    //            sb_value.Append("empLabourSelf =" + empLabourSelf + ",");
    //            sb_value.Append("empNhiComp =" + empNhiComp + ",");
    //            sb_value.Append("empNhiSelf =" + empNhiSelf + ",");
    //            sb_value.Append("empSuperComp =" + empSuperComp + ",");
    //            sb_value.Append("empSuperSelf =" + empSuperSelf + ",");
    //            sb_value.Append("memo=" + (String.IsNullOrEmpty(memo) ? "null" : "N'" + Regex.Replace(memo, "'", "''") + "'") + ",");
    //            sb_value.Append("empStatus=" + (String.IsNullOrEmpty(empStatus) ? "''" : "N'" + Regex.Replace(empStatus, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeeSalary set  " + sb_value.ToString() + "  where employeeSalaryTID = " + this.employeeSalaryTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.create() : " + e.ToString());
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
    //            sb_value.Append("OrderCarRegularGroupID =" + this.OrderCarRegularGroupID + ",");
    //            sb_value.Append("empBeginDate =" + this.empBeginDate + ",");
    //            sb_value.Append("empEndDate =" + this.empEndDate + ",");
    //            sb_value.Append("empSalary =" + this.empSalary + ",");
    //            sb_value.Append("empAward =" + this.empAward + ",");
    //            sb_value.Append("empRespBonus =" + this.empRespBonus + ",");
    //            sb_value.Append("empDutyAward =" + this.empDutyAward + ",");
    //            sb_value.Append("empSpecialBonus =" + this.empSpecialBonus + ",");
    //            sb_value.Append("empLabourComp =" + this.empLabourComp + ",");
    //            sb_value.Append("empLabourSelf =" + this.empLabourSelf + ",");
    //            sb_value.Append("empNhiComp =" + this.empNhiComp + ",");
    //            sb_value.Append("empNhiSelf =" + this.empNhiSelf + ",");
    //            sb_value.Append("empSuperComp =" + this.empSuperComp + ",");
    //            sb_value.Append("empSuperSelf =" + this.empSuperSelf + ",");
    //            sb_value.Append("memo=" + (String.IsNullOrEmpty(this.memo) ? "null" : "N'" + Regex.Replace(this.memo, "'", "''") + "'") + ",");
    //            sb_value.Append("empStatus=" + (String.IsNullOrEmpty(this.empStatus) ? "''" : "N'" + Regex.Replace(this.empStatus, "'", "''") + "'"));

    //            String sqlCmd = "update EmployeeSalary set  " + sb_value.ToString() + "  where employeeSalaryTID = " + this.employeeSalaryTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeSalary");
    //            if (ds.Tables["EmployeeSalary"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeSalary"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


