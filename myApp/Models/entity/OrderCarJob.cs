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
    //public partial class OrderCarJob
    //{

    //    public Collection<OrderCarJob> findAll()
    //    {
    //        Collection<OrderCarJob> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarJob order by OrderCarJobTID asc", "OrderCarJob");
    //            if (ds.Tables["OrderCarJob"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarJob>();
    //                foreach (DataRow dr in ds.Tables["OrderCarJob"].Rows)
    //                {
    //                    OrderCarJob am = new OrderCarJob();
    //                    am.carOrderInfoID = Convert.ToInt32(dr["carOrderInfoID"]);
    //                    am.carOrderRegularInfoID = Convert.ToInt32(dr["carOrderRegularInfoID"]);
    //                    am.SourceOrderCarJobID = Convert.ToInt32(dr["SourceOrderCarJobID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.driver = Convert.ToInt32(dr["driver"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.useDate = Convert.ToInt64(dr["useDate"]);
    //                    am.carStartHour = Convert.ToInt32(dr["carStartHour"]);
    //                    am.carStartMin = Convert.ToInt32(dr["carStartMin"]);
    //                    am.carEndHour = Convert.ToInt32(dr["carEndHour"]);
    //                    am.carEndMin = Convert.ToInt32(dr["carEndMin"]);
    //                    am.apptType = Convert.ToString(dr["apptType"]);
    //                    am.apptMemo = Convert.ToString(dr["apptMemo"]);
    //                    am.apptJobMemo = Convert.ToString(dr["apptJobMemo"]);
    //                    am.unpickMemo = Convert.ToString(dr["unpickMemo"]);
    //                    am.apptSalary = Convert.ToInt32(dr["apptSalary"]);
    //                    am.apptCharge = Convert.ToInt32(dr["apptCharge"]);
    //                    am.isTakeApart = Convert.ToInt32(dr["isTakeApart"]);
    //                    am.cost = Convert.ToInt32(dr["cost"]);
    //                    am.SalaryTips = Convert.ToInt32(dr["SalaryTips"]);
    //                    am.SalaryTrip = Convert.ToInt32(dr["SalaryTrip"]);
    //                    am.finalStatus = Convert.ToString(dr["finalStatus"]);
    //                    am.JobSource = Convert.ToString(dr["JobSource"]);
    //                    am.CheckinLocation = Convert.ToString(dr["CheckinLocation"]);
    //                    am.OrderCarJobTID = Convert.ToInt32(dr["OrderCarJobTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarJob> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarJob> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarJob");
    //            if (ds.Tables["OrderCarJob"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarJob>();
    //                foreach (DataRow dr in ds.Tables["OrderCarJob"].Rows)
    //                {
    //                    OrderCarJob am = new OrderCarJob();
    //                    am.carOrderInfoID = Convert.ToInt32(dr["carOrderInfoID"]);
    //                    am.carOrderRegularInfoID = Convert.ToInt32(dr["carOrderRegularInfoID"]);
    //                    am.SourceOrderCarJobID = Convert.ToInt32(dr["SourceOrderCarJobID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.driver = Convert.ToInt32(dr["driver"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.useDate = Convert.ToInt64(dr["useDate"]);
    //                    am.carStartHour = Convert.ToInt32(dr["carStartHour"]);
    //                    am.carStartMin = Convert.ToInt32(dr["carStartMin"]);
    //                    am.carEndHour = Convert.ToInt32(dr["carEndHour"]);
    //                    am.carEndMin = Convert.ToInt32(dr["carEndMin"]);
    //                    am.apptType = Convert.ToString(dr["apptType"]);
    //                    am.apptMemo = Convert.ToString(dr["apptMemo"]);
    //                    am.apptJobMemo = Convert.ToString(dr["apptJobMemo"]);
    //                    am.unpickMemo = Convert.ToString(dr["unpickMemo"]);
    //                    am.apptSalary = Convert.ToInt32(dr["apptSalary"]);
    //                    am.apptCharge = Convert.ToInt32(dr["apptCharge"]);
    //                    am.isTakeApart = Convert.ToInt32(dr["isTakeApart"]);
    //                    am.cost = Convert.ToInt32(dr["cost"]);
    //                    am.SalaryTips = Convert.ToInt32(dr["SalaryTips"]);
    //                    am.SalaryTrip = Convert.ToInt32(dr["SalaryTrip"]);
    //                    am.finalStatus = Convert.ToString(dr["finalStatus"]);
    //                    am.JobSource = Convert.ToString(dr["JobSource"]);
    //                    am.CheckinLocation = Convert.ToString(dr["CheckinLocation"]);
    //                    am.OrderCarJobTID = Convert.ToInt32(dr["OrderCarJobTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarJob findByPrimaryKey(int OrderCarJobTID)
    //    {
    //        OrderCarJob am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarJob a WHERE a.OrderCarJobTID = " + OrderCarJobTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarJob");
    //            if (ds.Tables["OrderCarJob"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarJob"].Rows[0];
    //                am = new OrderCarJob();
    //                am.carOrderInfoID = Convert.ToInt32(dr["carOrderInfoID"]);
    //                am.carOrderRegularInfoID = Convert.ToInt32(dr["carOrderRegularInfoID"]);
    //                am.SourceOrderCarJobID = Convert.ToInt32(dr["SourceOrderCarJobID"]);
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.driver = Convert.ToInt32(dr["driver"]);
    //                am.carType = Convert.ToString(dr["carType"]);
    //                am.useDate = Convert.ToInt64(dr["useDate"]);
    //                am.carStartHour = Convert.ToInt32(dr["carStartHour"]);
    //                am.carStartMin = Convert.ToInt32(dr["carStartMin"]);
    //                am.carEndHour = Convert.ToInt32(dr["carEndHour"]);
    //                am.carEndMin = Convert.ToInt32(dr["carEndMin"]);
    //                am.apptType = Convert.ToString(dr["apptType"]);
    //                am.apptMemo = Convert.ToString(dr["apptMemo"]);
    //                am.apptJobMemo = Convert.ToString(dr["apptJobMemo"]);
    //                am.unpickMemo = Convert.ToString(dr["unpickMemo"]);
    //                am.apptSalary = Convert.ToInt32(dr["apptSalary"]);
    //                am.apptCharge = Convert.ToInt32(dr["apptCharge"]);
    //                am.isTakeApart = Convert.ToInt32(dr["isTakeApart"]);
    //                am.cost = Convert.ToInt32(dr["cost"]);
    //                am.SalaryTips = Convert.ToInt32(dr["SalaryTips"]);
    //                am.SalaryTrip = Convert.ToInt32(dr["SalaryTrip"]);
    //                am.finalStatus = Convert.ToString(dr["finalStatus"]);
    //                am.JobSource = Convert.ToString(dr["JobSource"]);
    //                am.CheckinLocation = Convert.ToString(dr["CheckinLocation"]);
    //                am.OrderCarJobTID = Convert.ToInt32(dr["OrderCarJobTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int carOrderInfoID, int carOrderRegularInfoID, int SourceOrderCarJobID, String carID, int driver, String carType, long useDate, int carStartHour, int carStartMin, int carEndHour, int carEndMin, String apptType, String apptMemo, String apptJobMemo, String unpickMemo, int apptSalary, int apptCharge, int isTakeApart, double cost, double SalaryTips, double SalaryTrip, String finalStatus, String JobSource, String CheckinLocation)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(carOrderInfoID + ",");
    //            sb_value.Append(carOrderRegularInfoID + ",");
    //            sb_value.Append(SourceOrderCarJobID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(carID) ? "''" : "N'" + Regex.Replace(carID, "'", "''") + "'") + ",");
    //            sb_value.Append(driver + ",");
    //            sb_value.Append((String.IsNullOrEmpty(carType) ? "null" : "N'" + Regex.Replace(carType, "'", "''") + "'") + ",");
    //            sb_value.Append(useDate + ",");
    //            sb_value.Append(carStartHour + ",");
    //            sb_value.Append(carStartMin + ",");
    //            sb_value.Append(carEndHour + ",");
    //            sb_value.Append(carEndMin + ",");
    //            sb_value.Append((String.IsNullOrEmpty(apptType) ? "''" : "N'" + Regex.Replace(apptType, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(apptMemo) ? "''" : "N'" + Regex.Replace(apptMemo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(apptJobMemo) ? "null" : "N'" + Regex.Replace(apptJobMemo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(unpickMemo) ? "null" : "N'" + Regex.Replace(unpickMemo, "'", "''") + "'") + ",");
    //            sb_value.Append(apptSalary + ",");
    //            sb_value.Append(apptCharge + ",");
    //            sb_value.Append(isTakeApart + ",");
    //            sb_value.Append(cost + ",");
    //            sb_value.Append(SalaryTips + ",");
    //            sb_value.Append(SalaryTrip + ",");
    //            sb_value.Append((String.IsNullOrEmpty(finalStatus) ? "''" : "N'" + Regex.Replace(finalStatus, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JobSource) ? "''" : "N'" + Regex.Replace(JobSource, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CheckinLocation) ? "null" : "N'" + Regex.Replace(CheckinLocation, "'", "''") + "'"));

    //            String sqlCmd = "insert into OrderCarJob(carOrderInfoID,carOrderRegularInfoID,SourceOrderCarJobID,carID,driver,carType,useDate,carStartHour,carStartMin,carEndHour,carEndMin,apptType,apptMemo,apptJobMemo,unpickMemo,apptSalary,apptCharge,isTakeApart,cost,SalaryTips,SalaryTrip,finalStatus,JobSource,CheckinLocation) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarJobTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarJob where OrderCarJobTID = " + OrderCarJobTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int carOrderInfoID, int carOrderRegularInfoID, int SourceOrderCarJobID, String carID, int driver, String carType, long useDate, int carStartHour, int carStartMin, int carEndHour, int carEndMin, String apptType, String apptMemo, String apptJobMemo, String unpickMemo, int apptSalary, int apptCharge, int isTakeApart, double cost, double SalaryTips, double SalaryTrip, String finalStatus, String JobSource, String CheckinLocation)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("carOrderInfoID =" + carOrderInfoID + ",");
    //            sb_value.Append("carOrderRegularInfoID =" + carOrderRegularInfoID + ",");
    //            sb_value.Append("SourceOrderCarJobID =" + SourceOrderCarJobID + ",");
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(carID) ? "''" : "N'" + Regex.Replace(carID, "'", "''") + "'") + ",");
    //            sb_value.Append("driver =" + driver + ",");
    //            sb_value.Append("carType=" + (String.IsNullOrEmpty(carType) ? "null" : "N'" + Regex.Replace(carType, "'", "''") + "'") + ",");
    //            sb_value.Append("useDate =" + useDate + ",");
    //            sb_value.Append("carStartHour =" + carStartHour + ",");
    //            sb_value.Append("carStartMin =" + carStartMin + ",");
    //            sb_value.Append("carEndHour =" + carEndHour + ",");
    //            sb_value.Append("carEndMin =" + carEndMin + ",");
    //            sb_value.Append("apptType=" + (String.IsNullOrEmpty(apptType) ? "''" : "N'" + Regex.Replace(apptType, "'", "''") + "'") + ",");
    //            sb_value.Append("apptMemo=" + (String.IsNullOrEmpty(apptMemo) ? "''" : "N'" + Regex.Replace(apptMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("apptJobMemo=" + (String.IsNullOrEmpty(apptJobMemo) ? "null" : "N'" + Regex.Replace(apptJobMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("unpickMemo=" + (String.IsNullOrEmpty(unpickMemo) ? "null" : "N'" + Regex.Replace(unpickMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("apptSalary =" + apptSalary + ",");
    //            sb_value.Append("apptCharge =" + apptCharge + ",");
    //            sb_value.Append("isTakeApart =" + isTakeApart + ",");
    //            sb_value.Append("cost =" + cost + ",");
    //            sb_value.Append("SalaryTips =" + SalaryTips + ",");
    //            sb_value.Append("SalaryTrip =" + SalaryTrip + ",");
    //            sb_value.Append("finalStatus=" + (String.IsNullOrEmpty(finalStatus) ? "''" : "N'" + Regex.Replace(finalStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("JobSource=" + (String.IsNullOrEmpty(JobSource) ? "''" : "N'" + Regex.Replace(JobSource, "'", "''") + "'") + ",");
    //            sb_value.Append("CheckinLocation=" + (String.IsNullOrEmpty(CheckinLocation) ? "null" : "N'" + Regex.Replace(CheckinLocation, "'", "''") + "'"));

    //            String sqlCmd = "update OrderCarJob set  " + sb_value.ToString() + "  where OrderCarJobTID = " + this.OrderCarJobTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.create() : " + e.ToString());
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
    //            sb_value.Append("carOrderInfoID =" + this.carOrderInfoID + ",");
    //            sb_value.Append("carOrderRegularInfoID =" + this.carOrderRegularInfoID + ",");
    //            sb_value.Append("SourceOrderCarJobID =" + this.SourceOrderCarJobID + ",");
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(this.carID) ? "''" : "N'" + Regex.Replace(this.carID, "'", "''") + "'") + ",");
    //            sb_value.Append("driver =" + this.driver + ",");
    //            sb_value.Append("carType=" + (String.IsNullOrEmpty(this.carType) ? "null" : "N'" + Regex.Replace(this.carType, "'", "''") + "'") + ",");
    //            sb_value.Append("useDate =" + this.useDate + ",");
    //            sb_value.Append("carStartHour =" + this.carStartHour + ",");
    //            sb_value.Append("carStartMin =" + this.carStartMin + ",");
    //            sb_value.Append("carEndHour =" + this.carEndHour + ",");
    //            sb_value.Append("carEndMin =" + this.carEndMin + ",");
    //            sb_value.Append("apptType=" + (String.IsNullOrEmpty(this.apptType) ? "''" : "N'" + Regex.Replace(this.apptType, "'", "''") + "'") + ",");
    //            sb_value.Append("apptMemo=" + (String.IsNullOrEmpty(this.apptMemo) ? "''" : "N'" + Regex.Replace(this.apptMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("apptJobMemo=" + (String.IsNullOrEmpty(this.apptJobMemo) ? "null" : "N'" + Regex.Replace(this.apptJobMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("unpickMemo=" + (String.IsNullOrEmpty(this.unpickMemo) ? "null" : "N'" + Regex.Replace(this.unpickMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("apptSalary =" + this.apptSalary + ",");
    //            sb_value.Append("apptCharge =" + this.apptCharge + ",");
    //            sb_value.Append("isTakeApart =" + this.isTakeApart + ",");
    //            sb_value.Append("cost =" + this.cost + ",");
    //            sb_value.Append("SalaryTips =" + this.SalaryTips + ",");
    //            sb_value.Append("SalaryTrip =" + this.SalaryTrip + ",");
    //            sb_value.Append("finalStatus=" + (String.IsNullOrEmpty(this.finalStatus) ? "''" : "N'" + Regex.Replace(this.finalStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("JobSource=" + (String.IsNullOrEmpty(this.JobSource) ? "''" : "N'" + Regex.Replace(this.JobSource, "'", "''") + "'") + ",");
    //            sb_value.Append("CheckinLocation=" + (String.IsNullOrEmpty(this.CheckinLocation) ? "null" : "N'" + Regex.Replace(this.CheckinLocation, "'", "''") + "'"));

    //            String sqlCmd = "update OrderCarJob set  " + sb_value.ToString() + "  where OrderCarJobTID = " + this.OrderCarJobTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarJob");
    //            if (ds.Tables["OrderCarJob"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarJob"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


