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
    //public partial class CarDuty
    //{

    //    public Collection<CarDuty> findAll()
    //    {
    //        Collection<CarDuty> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarDuty order by CarDutyTID asc", "CarDuty");
    //            if (ds.Tables["CarDuty"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarDuty>();
    //                foreach (DataRow dr in ds.Tables["CarDuty"].Rows)
    //                {
    //                    CarDuty am = new CarDuty();
    //                    am.DutyName = Convert.ToString(dr["DutyName"]);
    //                    am.DutyOrder = Convert.ToInt32(dr["DutyOrder"]);
    //                    am.DutyStatus = Convert.ToString(dr["DutyStatus"]);
    //                    am.CarDutyTID = Convert.ToInt32(dr["CarDutyTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarDuty> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarDuty> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarDuty");
    //            if (ds.Tables["CarDuty"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarDuty>();
    //                foreach (DataRow dr in ds.Tables["CarDuty"].Rows)
    //                {
    //                    CarDuty am = new CarDuty();
    //                    am.DutyName = Convert.ToString(dr["DutyName"]);
    //                    am.DutyOrder = Convert.ToInt32(dr["DutyOrder"]);
    //                    am.DutyStatus = Convert.ToString(dr["DutyStatus"]);
    //                    am.CarDutyTID = Convert.ToInt32(dr["CarDutyTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarDuty findByPrimaryKey(int CarDutyTID)
    //    {
    //        CarDuty am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarDuty a WHERE a.CarDutyTID = " + CarDutyTID;
    //            DataSet ds = my.select(sqlCmd, "CarDuty");
    //            if (ds.Tables["CarDuty"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarDuty"].Rows[0];
    //                am = new CarDuty();
    //                am.DutyName = Convert.ToString(dr["DutyName"]);
    //                am.DutyOrder = Convert.ToInt32(dr["DutyOrder"]);
    //                am.DutyStatus = Convert.ToString(dr["DutyStatus"]);
    //                am.CarDutyTID = Convert.ToInt32(dr["CarDutyTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String DutyName, int DutyOrder, String DutyStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarDuty(DutyName,DutyOrder,DutyStatus) values ('" + DutyName + "'," + DutyOrder + ",'" + DutyStatus + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int CarDutyTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarDuty where CarDutyTID = " + CarDutyTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String DutyName, int DutyOrder, String DutyStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarDuty set DutyName ='" + DutyName + "',DutyOrder =" + DutyOrder + ",DutyStatus ='" + DutyStatus + "' where CarDutyTID = " + this.CarDutyTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarDuty set DutyName ='" + this.DutyName + "',DutyOrder =" + this.DutyOrder + ",DutyStatus ='" + this.DutyStatus + "' where CarDutyTID = " + this.CarDutyTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarDuty");
    //            if (ds.Tables["CarDuty"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarDuty"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarDuty.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


