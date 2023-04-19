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
    //public partial class CarWithEquipment
    //{
     
    //    public Collection<CarWithEquipment> findAll()
    //    {
    //        Collection<CarWithEquipment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarWithEquipment order by carWithEquipment asc", "CarWithEquipment");
    //            if (ds.Tables["CarWithEquipment"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarWithEquipment>();
    //                foreach (DataRow dr in ds.Tables["CarWithEquipment"].Rows)
    //                {
    //                    CarWithEquipment am = new CarWithEquipment();
    //                    am.carWithEquipment = Convert.ToInt32(dr["carWithEquipment"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.carEquipID = Convert.ToInt32(dr["carEquipID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarWithEquipment> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarWithEquipment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarWithEquipment");
    //            if (ds.Tables["CarWithEquipment"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarWithEquipment>();
    //                foreach (DataRow dr in ds.Tables["CarWithEquipment"].Rows)
    //                {
    //                    CarWithEquipment am = new CarWithEquipment();
    //                    am.carWithEquipment = Convert.ToInt32(dr["carWithEquipment"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.carEquipID = Convert.ToInt32(dr["carEquipID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarWithEquipment findByPrimaryKey(int carWithEquipment)
    //    {
    //        CarWithEquipment am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarWithEquipment a WHERE a.carWithEquipment = " + carWithEquipment;
    //            DataSet ds = my.select(sqlCmd, "CarWithEquipment");
    //            if (ds.Tables["CarWithEquipment"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarWithEquipment"].Rows[0];
    //                am = new CarWithEquipment();
    //                am.carWithEquipment = Convert.ToInt32(dr["carWithEquipment"]);
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.carEquipID = Convert.ToInt32(dr["carEquipID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String carID, int carEquipID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarWithEquipment(carID,carEquipID) values ('" + carID + "'," + carEquipID + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carWithEquipment)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarWithEquipment where carWithEquipment = " + carWithEquipment;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String carID, int carEquipID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarWithEquipment set carID ='" + carID + "',carEquipID =" + carEquipID + " where carWithEquipment = " + this.carWithEquipment;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarWithEquipment set carID ='" + this.carID + "',carEquipID =" + this.carEquipID + " where carWithEquipment = " + this.carWithEquipment;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarWithEquipment");
    //            if (ds.Tables["CarWithEquipment"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarWithEquipment"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarWithEquipment.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


