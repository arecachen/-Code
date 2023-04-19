using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace hsintongERP2022.Models
{
   
    //public partial class CarCertType
    //{

    //    public Collection<CarCertType> findAll()
    //    {
    //        Collection<CarCertType> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarCertType order by carCertTypeTID asc", "CarCertType");
    //            if (ds.Tables["CarCertType"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarCertType>();
    //                foreach (DataRow dr in ds.Tables["CarCertType"].Rows)
    //                {
    //                    CarCertType am = new CarCertType();
    //                    am.carCertName = Convert.ToString(dr["carCertName"]);
    //                    am.carCertAlertDay = Convert.ToInt32(dr["carCertAlertDay"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.carCertTypeTID = Convert.ToInt32(dr["carCertTypeTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarCertType> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarCertType> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarCertType");
    //            if (ds.Tables["CarCertType"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarCertType>();
    //                foreach (DataRow dr in ds.Tables["CarCertType"].Rows)
    //                {
    //                    CarCertType am = new CarCertType();
    //                    am.carCertName = Convert.ToString(dr["carCertName"]);
    //                    am.carCertAlertDay = Convert.ToInt32(dr["carCertAlertDay"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.carCertTypeTID = Convert.ToInt32(dr["carCertTypeTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarCertType findByPrimaryKey(int carCertTypeTID)
    //    {
    //        CarCertType am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarCertType a WHERE a.carCertTypeTID = " + carCertTypeTID;
    //            DataSet ds = my.select(sqlCmd, "CarCertType");
    //            if (ds.Tables["CarCertType"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarCertType"].Rows[0];
    //                am = new CarCertType();
    //                am.carCertName = Convert.ToString(dr["carCertName"]);
    //                am.carCertAlertDay = Convert.ToInt32(dr["carCertAlertDay"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.carCertTypeTID = Convert.ToInt32(dr["carCertTypeTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String carCertName, int carCertAlertDay, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarCertType(carCertName,carCertAlertDay,memo,status) values ('" + carCertName + "'," + carCertAlertDay + ",'" + memo + "','" + status + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carCertTypeTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarCertType where carCertTypeTID = " + carCertTypeTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String carCertName, int carCertAlertDay, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarCertType set carCertName ='" + carCertName + "',carCertAlertDay =" + carCertAlertDay + ",memo ='" + memo + "',status ='" + status + "' where carCertTypeTID = " + this.carCertTypeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarCertType set carCertName ='" + this.carCertName + "',carCertAlertDay =" + this.carCertAlertDay + ",memo ='" + this.memo + "',status ='" + this.status + "' where carCertTypeTID = " + this.carCertTypeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarCertType");
    //            if (ds.Tables["CarCertType"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarCertType"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertType.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}

    
}


