using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Howgreater.util;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class EmployeeMainExt : EmployeeMain
    //{
    //    public int create(String empID, String empNID, String empName, long empDOB, String empSex, String empMainContact, String empSecondContact, String empDuty, String empGrade, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into EmployeeMain(empID,empNID,empName,empDOB,empSex,empMainContact,empSecondContact,empDuty,empGrade,memo,status) values ('" + empID + "','" + empNID + "','" + empName + "'," + empDOB + ",'" + empSex + "','" + empMainContact + "','" + empSecondContact + "','" + empDuty + "','" + empGrade + "','" + memo + "','" + status + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public List<int> getAllIndex()
    //    {
    //        MssqlTool sql = new MssqlTool();
    //        String sqlCmd = "Select employeeTID from EmployeeMain";
    //        DataTable keyword = sql.findByKeywordDateTable(sqlCmd);
    //        List<int> tmp = new List<int>();
    //        for (int i = 0; i < keyword.Rows.Count; i++)
    //        {
    //            tmp.Add(Convert.ToInt32(keyword.Rows[i][0].ToString()));
    //        }
    //        return tmp;
    //    }
    //    public int getNoDriverTID()
    //    {
    //        MssqlTool sql = new MssqlTool();
    //        String sqlCmd = "Select employeeTID from EmployeeMain where status = 'noDriver' ";
    //        DataTable keyword = sql.findByKeywordDateTable(sqlCmd);
    //        if (keyword != null && keyword.Rows.Count > 0)
    //        {
    //            return Convert.ToInt32(keyword.Rows[0]["employeeTID"]);
    //        }
    //        else
    //        {
    //            return -999;
    //        }
    //    }
    //}
}