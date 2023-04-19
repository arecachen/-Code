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
    //public partial class EmployeeTimeSlot
    //{

    //    public Collection<EmployeeTimeSlot> findAll()
    //    {
    //        Collection<EmployeeTimeSlot> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from EmployeeTimeSlot order by EmployeeTimeSlotTID asc", "EmployeeTimeSlot");
    //            if (ds.Tables["EmployeeTimeSlot"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeTimeSlot>();
    //                foreach (DataRow dr in ds.Tables["EmployeeTimeSlot"].Rows)
    //                {
    //                    EmployeeTimeSlot am = new EmployeeTimeSlot();
    //                    am.EmployeeSalaryID = Convert.ToInt32(dr["EmployeeSalaryID"]);
    //                    am.EmployeeMainID = Convert.ToInt32(dr["EmployeeMainID"]);
    //                    am.OrderCarRegularClassID = Convert.ToInt32(dr["OrderCarRegularClassID"]);
    //                    am.StartHourSlot = Convert.ToInt32(dr["StartHourSlot"]);
    //                    am.StartMinuteSlot = Convert.ToInt32(dr["StartMinuteSlot"]);
    //                    am.EndHourSlot = Convert.ToInt32(dr["EndHourSlot"]);
    //                    am.EndMinuteSlot = Convert.ToInt32(dr["EndMinuteSlot"]);
    //                    am.EmployeeTimeSlotTID = Convert.ToInt32(dr["EmployeeTimeSlotTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeTimeSlot> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeTimeSlot> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeTimeSlot");
    //            if (ds.Tables["EmployeeTimeSlot"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeTimeSlot>();
    //                foreach (DataRow dr in ds.Tables["EmployeeTimeSlot"].Rows)
    //                {
    //                    EmployeeTimeSlot am = new EmployeeTimeSlot();
    //                    am.EmployeeSalaryID = Convert.ToInt32(dr["EmployeeSalaryID"]);
    //                    am.EmployeeMainID = Convert.ToInt32(dr["EmployeeMainID"]);
    //                    am.OrderCarRegularClassID = Convert.ToInt32(dr["OrderCarRegularClassID"]);
    //                    am.StartHourSlot = Convert.ToInt32(dr["StartHourSlot"]);
    //                    am.StartMinuteSlot = Convert.ToInt32(dr["StartMinuteSlot"]);
    //                    am.EndHourSlot = Convert.ToInt32(dr["EndHourSlot"]);
    //                    am.EndMinuteSlot = Convert.ToInt32(dr["EndMinuteSlot"]);
    //                    am.EmployeeTimeSlotTID = Convert.ToInt32(dr["EmployeeTimeSlotTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeTimeSlot findByPrimaryKey(int EmployeeTimeSlotTID)
    //    {
    //        EmployeeTimeSlot am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM EmployeeTimeSlot a WHERE a.EmployeeTimeSlotTID = " + EmployeeTimeSlotTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeTimeSlot");
    //            if (ds.Tables["EmployeeTimeSlot"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeTimeSlot"].Rows[0];
    //                am = new EmployeeTimeSlot();
    //                am.EmployeeSalaryID = Convert.ToInt32(dr["EmployeeSalaryID"]);
    //                am.EmployeeMainID = Convert.ToInt32(dr["EmployeeMainID"]);
    //                am.OrderCarRegularClassID = Convert.ToInt32(dr["OrderCarRegularClassID"]);
    //                am.StartHourSlot = Convert.ToInt32(dr["StartHourSlot"]);
    //                am.StartMinuteSlot = Convert.ToInt32(dr["StartMinuteSlot"]);
    //                am.EndHourSlot = Convert.ToInt32(dr["EndHourSlot"]);
    //                am.EndMinuteSlot = Convert.ToInt32(dr["EndMinuteSlot"]);
    //                am.EmployeeTimeSlotTID = Convert.ToInt32(dr["EmployeeTimeSlotTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int EmployeeSalaryID, int EmployeeMainID, int OrderCarRegularClassID, int StartHourSlot, int StartMinuteSlot, int EndHourSlot, int EndMinuteSlot)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(EmployeeSalaryID + ",");
    //            sb_value.Append(EmployeeMainID + ",");
    //            sb_value.Append(OrderCarRegularClassID + ",");
    //            sb_value.Append(StartHourSlot + ",");
    //            sb_value.Append(StartMinuteSlot + ",");
    //            sb_value.Append(EndHourSlot + ",");
    //            sb_value.Append(EndMinuteSlot);

    //            String sqlCmd = "insert into EmployeeTimeSlot(EmployeeSalaryID,EmployeeMainID,OrderCarRegularClassID,StartHourSlot,StartMinuteSlot,EndHourSlot,EndMinuteSlot) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int EmployeeTimeSlotTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from EmployeeTimeSlot where EmployeeTimeSlotTID = " + EmployeeTimeSlotTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int EmployeeSalaryID, int EmployeeMainID, int OrderCarRegularClassID, int StartHourSlot, int StartMinuteSlot, int EndHourSlot, int EndMinuteSlot)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("EmployeeSalaryID =" + EmployeeSalaryID + ",");
    //            sb_value.Append("EmployeeMainID =" + EmployeeMainID + ",");
    //            sb_value.Append("OrderCarRegularClassID =" + OrderCarRegularClassID + ",");
    //            sb_value.Append("StartHourSlot =" + StartHourSlot + ",");
    //            sb_value.Append("StartMinuteSlot =" + StartMinuteSlot + ",");
    //            sb_value.Append("EndHourSlot =" + EndHourSlot + ",");
    //            sb_value.Append("EndMinuteSlot =" + EndMinuteSlot);

    //            String sqlCmd = "update EmployeeTimeSlot set  " + sb_value.ToString() + "  where EmployeeTimeSlotTID = " + this.EmployeeTimeSlotTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.create() : " + e.ToString());
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
    //            sb_value.Append("EmployeeSalaryID =" + this.EmployeeSalaryID + ",");
    //            sb_value.Append("EmployeeMainID =" + this.EmployeeMainID + ",");
    //            sb_value.Append("OrderCarRegularClassID =" + this.OrderCarRegularClassID + ",");
    //            sb_value.Append("StartHourSlot =" + this.StartHourSlot + ",");
    //            sb_value.Append("StartMinuteSlot =" + this.StartMinuteSlot + ",");
    //            sb_value.Append("EndHourSlot =" + this.EndHourSlot + ",");
    //            sb_value.Append("EndMinuteSlot =" + this.EndMinuteSlot);

    //            String sqlCmd = "update EmployeeTimeSlot set  " + sb_value.ToString() + "  where EmployeeTimeSlotTID = " + this.EmployeeTimeSlotTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "EmployeeTimeSlot");
    //            if (ds.Tables["EmployeeTimeSlot"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeTimeSlot"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeTimeSlot.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


