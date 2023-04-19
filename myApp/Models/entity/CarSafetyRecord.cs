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
    //public partial class CarSafetyRecord
    //{
  
    //    public Collection<CarSafetyRecord> findAll()
    //    {
    //        Collection<CarSafetyRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarSafetyRecord order by carSafetyCheckTID asc", "CarSafetyRecord");
    //            if (ds.Tables["CarSafetyRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarSafetyRecord>();
    //                foreach (DataRow dr in ds.Tables["CarSafetyRecord"].Rows)
    //                {
    //                    CarSafetyRecord am = new CarSafetyRecord();
    //                    am.carSafetyCheckTID = Convert.ToInt32(dr["carSafetyCheckTID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.checkBy = Convert.ToInt32(dr["checkBy"]);
    //                    am.checkDate = Convert.ToInt64(dr["checkDate"]);
    //                    am.chkDocument = Convert.ToString(dr["chkDocument"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarSafetyRecord> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarSafetyRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarSafetyRecord");
    //            if (ds.Tables["CarSafetyRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarSafetyRecord>();
    //                foreach (DataRow dr in ds.Tables["CarSafetyRecord"].Rows)
    //                {
    //                    CarSafetyRecord am = new CarSafetyRecord();
    //                    am.carSafetyCheckTID = Convert.ToInt32(dr["carSafetyCheckTID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.checkBy = Convert.ToInt32(dr["checkBy"]);
    //                    am.checkDate = Convert.ToInt64(dr["checkDate"]);
    //                    am.chkDocument = Convert.ToString(dr["chkDocument"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarSafetyRecord findByPrimaryKey(int carSafetyCheckTID)
    //    {
    //        CarSafetyRecord am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarSafetyRecord a WHERE a.carSafetyCheckTID = " + carSafetyCheckTID;
    //            DataSet ds = my.select(sqlCmd, "CarSafetyRecord");
    //            if (ds.Tables["CarSafetyRecord"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarSafetyRecord"].Rows[0];
    //                am = new CarSafetyRecord();
    //                am.carSafetyCheckTID = Convert.ToInt32(dr["carSafetyCheckTID"]);
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.checkBy = Convert.ToInt32(dr["checkBy"]);
    //                am.checkDate = Convert.ToInt64(dr["checkDate"]);
    //                am.chkDocument = Convert.ToString(dr["chkDocument"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String carID, int checkBy, long checkDate, String chkDocument, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarSafetyRecord(carID,checkBy,checkDate,chkDocument,status) values ('" + carID + "'," + checkBy + "," + checkDate + ",'" + chkDocument + "','" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carSafetyCheckTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarSafetyRecord where carSafetyCheckTID = " + carSafetyCheckTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String carID, int checkBy, long checkDate, String chkDocument, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarSafetyRecord set carID ='" + carID + "',checkBy =" + checkBy + ",checkDate =" + checkDate + ",chkDocument ='" + chkDocument + "',status ='" + status + "' where carSafetyCheckTID = " + this.carSafetyCheckTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarSafetyRecord set carID ='" + this.carID + "',checkBy =" + this.checkBy + ",checkDate =" + this.checkDate + ",chkDocument ='" + this.chkDocument + "',status ='" + this.status + "' where carSafetyCheckTID = " + this.carSafetyCheckTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarSafetyRecord");
    //            if (ds.Tables["CarSafetyRecord"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarSafetyRecord"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarSafetyRecord.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


