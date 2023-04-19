using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
namespace hsintongERP2022.Models
{
    //public partial class CarAppointment
    //{
    //    public Collection<CarAppointment> findAll()
    //    {
    //        Collection<CarAppointment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarAppointment order by carOrderAppointmentTID asc", "CarAppointment");
    //            if (ds.Tables["CarAppointment"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarAppointment>();
    //                foreach (DataRow dr in ds.Tables["CarAppointment"].Rows)
    //                {
    //                    CarAppointment am = new CarAppointment();
    //                    am.carOrderAppointmentTID = Convert.ToInt32(dr["carOrderAppointmentTID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.carOrderInfoID = Convert.ToInt32(dr["carOrderInfoID"]);
    //                    am.useDate = Convert.ToInt64(dr["useDate"]);
    //                    am.carStartHour = Convert.ToInt32(dr["carStartHour"]);
    //                    am.carStartMin = Convert.ToInt32(dr["carStartMin"]);
    //                    am.driver = Convert.ToInt32(dr["driver"]);
    //                    am.apptType = Convert.ToString(dr["apptType"]);
    //                    am.apptMemo = Convert.ToString(dr["apptMemo"]);
    //                    am.apptJobMemo = Convert.ToString(dr["apptJobMemo"]);
    //                    am.apptSalary = Convert.ToInt32(dr["apptSalary"]);
    //                    am.apptCharge = Convert.ToInt32(dr["apptCharge"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.final = Convert.ToInt32(dr["final"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.passengerCount = Convert.ToInt32(dr["passengerCount"]);
    //                    am.cost = Convert.ToInt32(dr["cost"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarAppointment> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarAppointment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarAppointment");
    //            if (ds.Tables["CarAppointment"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarAppointment>();
    //                foreach (DataRow dr in ds.Tables["CarAppointment"].Rows)
    //                {
    //                    CarAppointment am = new CarAppointment();
    //                    am.carOrderAppointmentTID = Convert.ToInt32(dr["carOrderAppointmentTID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.carOrderInfoID = Convert.ToInt32(dr["carOrderInfoID"]);
    //                    am.useDate = Convert.ToInt64(dr["useDate"]);
    //                    am.carStartHour = Convert.ToInt32(dr["carStartHour"]);
    //                    am.carStartMin = Convert.ToInt32(dr["carStartMin"]);
    //                    am.driver = Convert.ToInt32(dr["driver"]);
    //                    am.apptType = Convert.ToString(dr["apptType"]);
    //                    am.apptMemo = Convert.ToString(dr["apptMemo"]);
    //                    am.apptJobMemo = Convert.ToString(dr["apptJobMemo"]);
    //                    am.apptSalary = Convert.ToInt32(dr["apptSalary"]);
    //                    am.apptCharge = Convert.ToInt32(dr["apptCharge"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.final = Convert.ToInt32(dr["final"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.passengerCount = Convert.ToInt32(dr["passengerCount"]);
    //                    am.cost = Convert.ToInt32(dr["cost"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarAppointment findByPrimaryKey(int carOrderAppointmentTID)
    //    {
    //        CarAppointment am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarAppointment a WHERE a.carOrderAppointmentTID = " + carOrderAppointmentTID;
    //            DataSet ds = my.select(sqlCmd, "CarAppointment");
    //            if (ds.Tables["CarAppointment"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarAppointment"].Rows[0];
    //                am = new CarAppointment();
    //                am.carOrderAppointmentTID = Convert.ToInt32(dr["carOrderAppointmentTID"]);
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.carOrderInfoID = Convert.ToInt32(dr["carOrderInfoID"]);
    //                am.useDate = Convert.ToInt64(dr["useDate"]);
    //                am.carStartHour = Convert.ToInt32(dr["carStartHour"]);
    //                am.carStartMin = Convert.ToInt32(dr["carStartMin"]);
    //                am.driver = Convert.ToInt32(dr["driver"]);
    //                am.apptType = Convert.ToString(dr["apptType"]);
    //                am.apptMemo = Convert.ToString(dr["apptMemo"]);
    //                am.apptJobMemo = Convert.ToString(dr["apptJobMemo"]);
    //                am.apptSalary = Convert.ToInt32(dr["apptSalary"]);
    //                am.apptCharge = Convert.ToInt32(dr["apptCharge"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.final = Convert.ToInt32(dr["final"]);
    //                am.carType = Convert.ToString(dr["carType"]);
    //                am.passengerCount = Convert.ToInt32(dr["passengerCount"]);
    //                am.cost = Convert.ToInt32(dr["cost"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String carID, int carOrderInfoID, long useDate, int carStartHour, int carStartMin, int driver, String apptType, String apptMemo, String apptJobMemo, int apptSalary, int apptCharge, String status, int final, String carType, int passengerCount, double cost)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarAppointment(carID,carOrderInfoID,useDate,carStartHour,carStartMin,driver,apptType,apptMemo,apptJobMemo,apptSalary,apptCharge,status,final,carType,passengerCount,cost) values ('" + carID + "'," + carOrderInfoID + "," + useDate + "," + carStartHour + "," + carStartMin + "," + driver + ",'" + apptType + "','" + apptMemo + "','" + apptJobMemo + "'," + apptSalary + "," + apptCharge + ",'" + status + "'," + final + ",'" + carType + "'," + passengerCount + "," + cost + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carOrderAppointmentTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarAppointment where carOrderAppointmentTID = " + carOrderAppointmentTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String carID, int carOrderInfoID, long useDate, int carStartHour, int carStartMin, int driver, String apptType, String apptMemo, String apptJobMemo, int apptSalary, int apptCharge, String status, int final, String carType, int passengerCount, double cost)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarAppointment set carID ='" + carID + "',carOrderInfoID =" + carOrderInfoID + ",useDate =" + useDate + ",carStartHour =" + carStartHour + ",carStartMin =" + carStartMin + ",driver =" + driver + ",apptType ='" + apptType + "',apptMemo ='" + apptMemo + "',apptJobMemo ='" + apptJobMemo + "',apptSalary =" + apptSalary + ",apptCharge =" + apptCharge + ",status ='" + status + "',final =" + final + ",carType ='" + carType + "',passengerCount =" + passengerCount + ",cost =" + cost + " where carOrderAppointmentTID = " + this.carOrderAppointmentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarAppointment set carID ='" + this.carID + "',carOrderInfoID =" + this.carOrderInfoID + ",useDate =" + this.useDate + ",carStartHour =" + this.carStartHour + ",carStartMin =" + this.carStartMin + ",driver =" + this.driver + ",apptType ='" + this.apptType + "',apptMemo ='" + this.apptMemo + "',apptJobMemo ='" + this.apptJobMemo + "',apptSalary =" + this.apptSalary + ",apptCharge =" + this.apptCharge + ",status ='" + this.status + "',final =" + this.final + ",carType ='" + this.carType + "',passengerCount =" + this.passengerCount + ",cost =" + this.cost + " where carOrderAppointmentTID = " + this.carOrderAppointmentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarAppointment");
    //            if (ds.Tables["CarAppointment"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarAppointment"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAppointment.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


