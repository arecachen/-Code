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
    //public partial class EmployeeSalaryExt : EmployeeSalary
    //{
    //    public EmployeeSalary findByEmpIDStatusOpen(int empID)
    //    {
    //        EmployeeSalary am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeeSalary a WHERE a.empStatus = 'open' AND a.employeeID = " + empID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeSalary");
    //            if (ds.Tables["EmployeeSalary"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeSalary"].Rows[0];
    //                am = new EmployeeSalary();
    //                am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                am.OrderCarRegularGroupID = Convert.ToInt32(dr["OrderCarRegularGroupID"]);
    //                am.empBeginDate = String.IsNullOrEmpty(dr["empBeginDate"].ToString()) ? -999 : Convert.ToInt64(dr["empBeginDate"]);
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

    //    public Boolean EmployeePaymentRecordHas(int EmployeeSalaryID)
    //    {
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeePaymentRecord a WHERE a.employeeSalaryID = " + EmployeeSalaryID;
    //            DataTable dt = new MssqlTool().findByKeywordDateTable(sqlCmd);
    //            if (dt != null && dt.Rows.Count > 0)
    //            {
    //                return false;
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalaryExt.EmployeePaymentRecordHas() : " + e.ToString());
    //        }
    //        return true;
    //    }

    //    public int createByEmployeeSalary(EmployeeSalary es)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(es.employeeID + ",");
    //            sb_value.Append(es.OrderCarRegularGroupID + ",");
    //            sb_value.Append(es.empSalary + ",");
    //            sb_value.Append(es.empAward + ",");
    //            sb_value.Append(es.empRespBonus + ",");
    //            sb_value.Append(es.empDutyAward + ",");
    //            sb_value.Append(es.empSpecialBonus + ",");
    //            sb_value.Append(es.empLabourComp + ",");
    //            sb_value.Append(es.empLabourSelf + ",");
    //            sb_value.Append(es.empNhiComp + ",");
    //            sb_value.Append(es.empNhiSelf + ",");
    //            sb_value.Append(es.empSuperComp + ",");
    //            sb_value.Append(es.empSuperSelf + ",");
    //            sb_value.Append((String.IsNullOrEmpty(es.memo) ? "null" : "N'" + Regex.Replace(es.memo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(es.empStatus) ? "null" : "N'" + Regex.Replace(es.empStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into EmployeeSalary(employeeID,OrderCarRegularGroupID,empSalary,empAward,empRespBonus,empDutyAward,empSpecialBonus,empLabourComp,empLabourSelf,empNhiComp,empNhiSelf,empSuperComp,empSuperSelf,memo,empStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeSalary.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}
}