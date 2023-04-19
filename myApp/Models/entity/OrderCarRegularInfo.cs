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
    //public partial class OrderCarRegularInfo
    //{
       
    //    public Collection<OrderCarRegularInfo> findAll()
    //    {
    //        Collection<OrderCarRegularInfo> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarRegularInfo order by OrderCarRegularInfoTID asc", "OrderCarRegularInfo");
    //            if (ds.Tables["OrderCarRegularInfo"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularInfo>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularInfo"].Rows)
    //                {
    //                    OrderCarRegularInfo am = new OrderCarRegularInfo();
    //                    am.OrderCarRegularID = Convert.ToInt32(dr["OrderCarRegularID"]);
    //                    am.rentWorkTitle = Convert.ToString(dr["rentWorkTitle"]);
    //                    am.CarType = Convert.ToString(dr["CarType"]);
    //                    am.rentStartDate = Convert.ToInt64(dr["rentStartDate"]);
    //                    am.rentEndDate = Convert.ToInt64(dr["rentEndDate"]);
    //                    am.rentArriveHour = Convert.ToInt32(dr["rentArriveHour"]);
    //                    am.rentArriveMinute = Convert.ToInt32(dr["rentArriveMinute"]);
    //                    am.journey = Convert.ToString(dr["journey"]);
    //                    am.CycleType = Convert.ToString(dr["CycleType"]);
    //                    am.CycleCount = Convert.ToInt32(dr["CycleCount"]);
    //                    am.BaseDate = Convert.ToString(dr["BaseDate"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.Memo = Convert.ToString(dr["Memo"]);
    //                    am.InfoType = Convert.ToString(dr["InfoType"]);
    //                    am.OrderCarRegularInfoTID = Convert.ToInt32(dr["OrderCarRegularInfoTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarRegularInfo> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarRegularInfo> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularInfo");
    //            if (ds.Tables["OrderCarRegularInfo"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegularInfo>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegularInfo"].Rows)
    //                {
    //                    OrderCarRegularInfo am = new OrderCarRegularInfo();
    //                    am.OrderCarRegularID = Convert.ToInt32(dr["OrderCarRegularID"]);
    //                    am.rentWorkTitle = Convert.ToString(dr["rentWorkTitle"]);
    //                    am.CarType = Convert.ToString(dr["CarType"]);
    //                    am.rentStartDate = Convert.ToInt64(dr["rentStartDate"]);
    //                    am.rentEndDate = Convert.ToInt64(dr["rentEndDate"]);
    //                    am.rentArriveHour = Convert.ToInt32(dr["rentArriveHour"]);
    //                    am.rentArriveMinute = Convert.ToInt32(dr["rentArriveMinute"]);
    //                    am.journey = Convert.ToString(dr["journey"]);
    //                    am.CycleType = Convert.ToString(dr["CycleType"]);
    //                    am.CycleCount = Convert.ToInt32(dr["CycleCount"]);
    //                    am.BaseDate = Convert.ToString(dr["BaseDate"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.Memo = Convert.ToString(dr["Memo"]);
    //                    am.InfoType = Convert.ToString(dr["InfoType"]);
    //                    am.OrderCarRegularInfoTID = Convert.ToInt32(dr["OrderCarRegularInfoTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarRegularInfo findByPrimaryKey(int OrderCarRegularInfoTID)
    //    {
    //        OrderCarRegularInfo am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarRegularInfo a WHERE a.OrderCarRegularInfoTID = " + OrderCarRegularInfoTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularInfo");
    //            if (ds.Tables["OrderCarRegularInfo"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularInfo"].Rows[0];
    //                am = new OrderCarRegularInfo();
    //                am.OrderCarRegularID = Convert.ToInt32(dr["OrderCarRegularID"]);
    //                am.rentWorkTitle = Convert.ToString(dr["rentWorkTitle"]);
    //                am.CarType = Convert.ToString(dr["CarType"]);
    //                am.rentStartDate = Convert.ToInt64(dr["rentStartDate"]);
    //                am.rentEndDate = Convert.ToInt64(dr["rentEndDate"]);
    //                am.rentArriveHour = Convert.ToInt32(dr["rentArriveHour"]);
    //                am.rentArriveMinute = Convert.ToInt32(dr["rentArriveMinute"]);
    //                am.journey = Convert.ToString(dr["journey"]);
    //                am.CycleType = Convert.ToString(dr["CycleType"]);
    //                am.CycleCount = Convert.ToInt32(dr["CycleCount"]);
    //                am.BaseDate = Convert.ToString(dr["BaseDate"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.Memo = Convert.ToString(dr["Memo"]);
    //                am.InfoType = Convert.ToString(dr["InfoType"]);
    //                am.OrderCarRegularInfoTID = Convert.ToInt32(dr["OrderCarRegularInfoTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int OrderCarRegularID, String rentWorkTitle, String CarType, long rentStartDate, long rentEndDate, int rentArriveHour, int rentArriveMinute, String journey, String CycleType, int CycleCount, String BaseDate, String status, String Memo, String InfoType)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(OrderCarRegularID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(rentWorkTitle) ? "''" : "N'" + Regex.Replace(rentWorkTitle, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CarType) ? "''" : "N'" + Regex.Replace(CarType, "'", "''") + "'") + ",");
    //            sb_value.Append(rentStartDate + ",");
    //            sb_value.Append(rentEndDate + ",");
    //            sb_value.Append(rentArriveHour + ",");
    //            sb_value.Append(rentArriveMinute + ",");
    //            sb_value.Append((String.IsNullOrEmpty(journey) ? "null" : "N'" + Regex.Replace(journey, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(CycleType) ? "''" : "N'" + Regex.Replace(CycleType, "'", "''") + "'") + ",");
    //            sb_value.Append(CycleCount + ",");
    //            sb_value.Append((String.IsNullOrEmpty(BaseDate) ? "''" : "N'" + Regex.Replace(BaseDate, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(Memo) ? "null" : "N'" + Regex.Replace(Memo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(InfoType) ? "''" : "N'" + Regex.Replace(InfoType, "'", "''") + "'"));

    //            String sqlCmd = "insert into OrderCarRegularInfo(OrderCarRegularID,rentWorkTitle,CarType,rentStartDate,rentEndDate,rentArriveHour,rentArriveMinute,journey,CycleType,CycleCount,BaseDate,status,Memo,InfoType) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarRegularInfoTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarRegularInfo where OrderCarRegularInfoTID = " + OrderCarRegularInfoTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int OrderCarRegularID, String rentWorkTitle, String CarType, long rentStartDate, long rentEndDate, int rentArriveHour, int rentArriveMinute, String journey, String CycleType, int CycleCount, String BaseDate, String status, String Memo, String InfoType)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("OrderCarRegularID =" + OrderCarRegularID + ",");
    //            sb_value.Append("rentWorkTitle=" + (String.IsNullOrEmpty(rentWorkTitle) ? "''" : "N'" + Regex.Replace(rentWorkTitle, "'", "''") + "'") + ",");
    //            sb_value.Append("CarType=" + (String.IsNullOrEmpty(CarType) ? "''" : "N'" + Regex.Replace(CarType, "'", "''") + "'") + ",");
    //            sb_value.Append("rentStartDate =" + rentStartDate + ",");
    //            sb_value.Append("rentEndDate =" + rentEndDate + ",");
    //            sb_value.Append("rentArriveHour =" + rentArriveHour + ",");
    //            sb_value.Append("rentArriveMinute =" + rentArriveMinute + ",");
    //            sb_value.Append("journey=" + (String.IsNullOrEmpty(journey) ? "null" : "N'" + Regex.Replace(journey, "'", "''") + "'") + ",");
    //            sb_value.Append("CycleType=" + (String.IsNullOrEmpty(CycleType) ? "''" : "N'" + Regex.Replace(CycleType, "'", "''") + "'") + ",");
    //            sb_value.Append("CycleCount =" + CycleCount + ",");
    //            sb_value.Append("BaseDate=" + (String.IsNullOrEmpty(BaseDate) ? "''" : "N'" + Regex.Replace(BaseDate, "'", "''") + "'") + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'") + ",");
    //            sb_value.Append("Memo=" + (String.IsNullOrEmpty(Memo) ? "null" : "N'" + Regex.Replace(Memo, "'", "''") + "'") + ",");
    //            sb_value.Append("InfoType=" + (String.IsNullOrEmpty(InfoType) ? "''" : "N'" + Regex.Replace(InfoType, "'", "''") + "'"));

    //            String sqlCmd = "update OrderCarRegularInfo set  " + sb_value.ToString() + "  where OrderCarRegularInfoTID = " + this.OrderCarRegularInfoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.create() : " + e.ToString());
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
    //            sb_value.Append("OrderCarRegularID =" + this.OrderCarRegularID + ",");
    //            sb_value.Append("rentWorkTitle=" + (String.IsNullOrEmpty(this.rentWorkTitle) ? "''" : "N'" + Regex.Replace(this.rentWorkTitle, "'", "''") + "'") + ",");
    //            sb_value.Append("CarType=" + (String.IsNullOrEmpty(this.CarType) ? "''" : "N'" + Regex.Replace(this.CarType, "'", "''") + "'") + ",");
    //            sb_value.Append("rentStartDate =" + this.rentStartDate + ",");
    //            sb_value.Append("rentEndDate =" + this.rentEndDate + ",");
    //            sb_value.Append("rentArriveHour =" + this.rentArriveHour + ",");
    //            sb_value.Append("rentArriveMinute =" + this.rentArriveMinute + ",");
    //            sb_value.Append("journey=" + (String.IsNullOrEmpty(this.journey) ? "null" : "N'" + Regex.Replace(this.journey, "'", "''") + "'") + ",");
    //            sb_value.Append("CycleType=" + (String.IsNullOrEmpty(this.CycleType) ? "''" : "N'" + Regex.Replace(this.CycleType, "'", "''") + "'") + ",");
    //            sb_value.Append("CycleCount =" + this.CycleCount + ",");
    //            sb_value.Append("BaseDate=" + (String.IsNullOrEmpty(this.BaseDate) ? "''" : "N'" + Regex.Replace(this.BaseDate, "'", "''") + "'") + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(this.status) ? "''" : "N'" + Regex.Replace(this.status, "'", "''") + "'") + ",");
    //            sb_value.Append("Memo=" + (String.IsNullOrEmpty(this.Memo) ? "null" : "N'" + Regex.Replace(this.Memo, "'", "''") + "'") + ",");
    //            sb_value.Append("InfoType=" + (String.IsNullOrEmpty(this.InfoType) ? "''" : "N'" + Regex.Replace(this.InfoType, "'", "''") + "'"));

    //            String sqlCmd = "update OrderCarRegularInfo set  " + sb_value.ToString() + "  where OrderCarRegularInfoTID = " + this.OrderCarRegularInfoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegularInfo");
    //            if (ds.Tables["OrderCarRegularInfo"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegularInfo"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularInfo.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


