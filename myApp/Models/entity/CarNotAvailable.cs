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
    //public partial class CarNotAvailable
    //{

    //    public Collection<CarNotAvailable> findAll()
    //    {
    //        Collection<CarNotAvailable> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarNotAvailable order by carNATID asc", "CarNotAvailable");
    //            if (ds.Tables["CarNotAvailable"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarNotAvailable>();
    //                foreach (DataRow dr in ds.Tables["CarNotAvailable"].Rows)
    //                {
    //                    CarNotAvailable am = new CarNotAvailable();
    //                    am.carNATID = Convert.ToInt32(dr["carNATID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.carNADate = Convert.ToInt64(dr["carNADate"]);
    //                    am.carNAAllDay = Convert.ToInt32(dr["carNAAllDay"]);
    //                    am.carNAStartHour = Convert.ToInt32(dr["carNAStartHour"]);
    //                    am.carNAStartMin = Convert.ToInt32(dr["carNAStartMin"]);
    //                    am.carNAEndHour = Convert.ToInt32(dr["carNAEndHour"]);
    //                    am.carNAEndMin = Convert.ToInt32(dr["carNAEndMin"]);
    //                    am.carNAReason = Convert.ToString(dr["carNAReason"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarNotAvailable> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarNotAvailable> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarNotAvailable");
    //            if (ds.Tables["CarNotAvailable"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarNotAvailable>();
    //                foreach (DataRow dr in ds.Tables["CarNotAvailable"].Rows)
    //                {
    //                    CarNotAvailable am = new CarNotAvailable();
    //                    am.carNATID = Convert.ToInt32(dr["carNATID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.carNADate = Convert.ToInt64(dr["carNADate"]);
    //                    am.carNAAllDay = Convert.ToInt32(dr["carNAAllDay"]);
    //                    am.carNAStartHour = Convert.ToInt32(dr["carNAStartHour"]);
    //                    am.carNAStartMin = Convert.ToInt32(dr["carNAStartMin"]);
    //                    am.carNAEndHour = Convert.ToInt32(dr["carNAEndHour"]);
    //                    am.carNAEndMin = Convert.ToInt32(dr["carNAEndMin"]);
    //                    am.carNAReason = Convert.ToString(dr["carNAReason"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarNotAvailable findByPrimaryKey(int carNATID)
    //    {
    //        CarNotAvailable am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarNotAvailable a WHERE a.carNATID = " + carNATID;
    //            DataSet ds = my.select(sqlCmd, "CarNotAvailable");
    //            if (ds.Tables["CarNotAvailable"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarNotAvailable"].Rows[0];
    //                am = new CarNotAvailable();
    //                am.carNATID = Convert.ToInt32(dr["carNATID"]);
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.carNADate = Convert.ToInt64(dr["carNADate"]);
    //                am.carNAAllDay = Convert.ToInt32(dr["carNAAllDay"]);
    //                am.carNAStartHour = Convert.ToInt32(dr["carNAStartHour"]);
    //                am.carNAStartMin = Convert.ToInt32(dr["carNAStartMin"]);
    //                am.carNAEndHour = Convert.ToInt32(dr["carNAEndHour"]);
    //                am.carNAEndMin = Convert.ToInt32(dr["carNAEndMin"]);
    //                am.carNAReason = Convert.ToString(dr["carNAReason"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String carID, long carNADate, int carNAAllDay, int carNAStartHour, int carNAStartMin, int carNAEndHour, int carNAEndMin, String carNAReason)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarNotAvailable(carID,carNADate,carNAAllDay,carNAStartHour,carNAStartMin,carNAEndHour,carNAEndMin,carNAReason) values ('" + carID + "'," + carNADate + "," + carNAAllDay + "," + carNAStartHour + "," + carNAStartMin + "," + carNAEndHour + "," + carNAEndMin + ",'" + carNAReason + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carNATID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarNotAvailable where carNATID = " + carNATID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String carID, long carNADate, int carNAAllDay, int carNAStartHour, int carNAStartMin, int carNAEndHour, int carNAEndMin, String carNAReason)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarNotAvailable set carID ='" + carID + "',carNADate =" + carNADate + ",carNAAllDay =" + carNAAllDay + ",carNAStartHour =" + carNAStartHour + ",carNAStartMin =" + carNAStartMin + ",carNAEndHour =" + carNAEndHour + ",carNAEndMin =" + carNAEndMin + ",carNAReason ='" + carNAReason + "' where carNATID = " + this.carNATID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarNotAvailable set carID ='" + this.carID + "',carNADate =" + this.carNADate + ",carNAAllDay =" + this.carNAAllDay + ",carNAStartHour =" + this.carNAStartHour + ",carNAStartMin =" + this.carNAStartMin + ",carNAEndHour =" + this.carNAEndHour + ",carNAEndMin =" + this.carNAEndMin + ",carNAReason ='" + this.carNAReason + "' where carNATID = " + this.carNATID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarNotAvailable");
    //            if (ds.Tables["CarNotAvailable"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarNotAvailable"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarNotAvailable.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


