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
    //public partial class OrderCarJobExt : OrderCarJob
    //{
    //    public string updateReturnSql(OrderCarJob ocj)
    //    {
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("carOrderInfoID =" + ocj.carOrderInfoID + ",");
    //            sb_value.Append("carOrderRegularInfoID =" + ocj.carOrderRegularInfoID + ",");
    //            sb_value.Append("SourceOrderCarJobID =" + ocj.SourceOrderCarJobID + ",");
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(ocj.carID) ? "''" : "N'" + Regex.Replace(ocj.carID, "'", "''") + "'") + ",");
    //            sb_value.Append("driver =" + ocj.driver + ",");
    //            sb_value.Append("carType=" + (String.IsNullOrEmpty(ocj.carType) ? "null" : "N'" + Regex.Replace(ocj.carType, "'", "''") + "'") + ",");
    //            sb_value.Append("useDate =" + ocj.useDate + ",");
    //            sb_value.Append("carStartHour =" + ocj.carStartHour + ",");
    //            sb_value.Append("carStartMin =" + ocj.carStartMin + ",");
    //            sb_value.Append("carEndHour =" + ocj.carEndHour + ",");
    //            sb_value.Append("carEndMin =" + ocj.carEndMin + ",");
    //            sb_value.Append("apptType=" + (String.IsNullOrEmpty(ocj.apptType) ? "''" : "N'" + Regex.Replace(ocj.apptType, "'", "''") + "'") + ",");
    //            sb_value.Append("apptMemo=" + (String.IsNullOrEmpty(ocj.apptMemo) ? "''" : "N'" + Regex.Replace(ocj.apptMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("apptJobMemo=" + (String.IsNullOrEmpty(ocj.apptJobMemo) ? "null" : "N'" + Regex.Replace(ocj.apptJobMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("unpickMemo=" + (String.IsNullOrEmpty(ocj.unpickMemo) ? "null" : "N'" + Regex.Replace(ocj.unpickMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("apptSalary =" + ocj.apptSalary + ",");
    //            sb_value.Append("apptCharge =" + ocj.apptCharge + ",");
    //            sb_value.Append("isTakeApart =" + ocj.isTakeApart + ",");
    //            sb_value.Append("cost =" + ocj.cost + ",");
    //            sb_value.Append("SalaryTips =" + ocj.SalaryTips + ",");
    //            sb_value.Append("SalaryTrip =" + ocj.SalaryTrip + ",");
    //            sb_value.Append("finalStatus=" + (String.IsNullOrEmpty(ocj.finalStatus) ? "''" : "N'" + Regex.Replace(ocj.finalStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("JobSource=" + (String.IsNullOrEmpty(ocj.JobSource) ? "''" : "N'" + Regex.Replace(ocj.JobSource, "'", "''") + "'") + ",");
    //            sb_value.Append("CheckinLocation=" + (String.IsNullOrEmpty(ocj.CheckinLocation) ? "null" : "N'" + Regex.Replace(ocj.CheckinLocation, "'", "''") + "'"));

    //            String sqlCmd = "update OrderCarJob set  " + sb_value.ToString() + "  where OrderCarJobTID = " + ocj.OrderCarJobTID + "; ";
    //            return sqlCmd;
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.update() : " + e.ToString());
    //        }
    //        return "";
    //    }

    //    public void DeleteNotInInfo()
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        sb.Append(" delete from OrderCarJob where OrderCarJobTID in ");
    //        sb.Append(" (Select OrderCarJobTID from OrderCarJob where carOrderInfoID not in ");
    //        sb.Append(" (Select OrderCarInfoTID from OrderCarInfo )) ");

    //        int result = new MssqlTool().delete(sb.ToString());

    //        return;
    //    }

    //    public String createByString(int carOrderInfoID, int carOrderRegularInfoID, int SourceOrderCarJobID, String carID, int driver, String carType, long useDate, int carStartHour, int carStartMin, int carEndHour, int carEndMin, String apptType, String apptMemo, String apptJobMemo, String unpickMemo, int apptSalary, int apptCharge, int isTakeApart, double cost, double SalaryTips, double SalaryTrip, String finalStatus, String JobSource, String CheckinLocation)
    //    {
    //        String sqlCmd = "";
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

    //            sqlCmd = "insert into OrderCarJob(carOrderInfoID,carOrderRegularInfoID,SourceOrderCarJobID,carID,driver,carType,useDate,carStartHour,carStartMin,carEndHour,carEndMin,apptType,apptMemo,apptJobMemo,unpickMemo,apptSalary,apptCharge,isTakeApart,cost,SalaryTips,SalaryTrip,finalStatus,JobSource,CheckinLocation) values (" + sb_value.ToString() + ")";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJob.create() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }

    //    public String DeleteByString(int OrderCarJobTID)
    //    {
    //        String sqlCmd = "";
    //        try
    //        {
    //            sqlCmd = "delete from OrderCarJob where OrderCarJobTID = " + OrderCarJobTID + ";";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobExt.DeleteByString() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }
    //}
}