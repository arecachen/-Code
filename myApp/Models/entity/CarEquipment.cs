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
    
    //public partial class CarEquipment
    //{

    //    public Collection<CarEquipment> findAll()
    //    {
    //        Collection<CarEquipment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarEquipment order by carEquipTID asc", "CarEquipment");
    //            if (ds.Tables["CarEquipment"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarEquipment>();
    //                foreach (DataRow dr in ds.Tables["CarEquipment"].Rows)
    //                {
    //                    CarEquipment am = new CarEquipment();
    //                    am.carEquipTID = Convert.ToInt32(dr["carEquipTID"]);
    //                    am.equipName = Convert.ToString(dr["equipName"]);
    //                    am.assetNo = Convert.ToString(dr["assetNo"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarEquipment> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarEquipment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarEquipment");
    //            if (ds.Tables["CarEquipment"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarEquipment>();
    //                foreach (DataRow dr in ds.Tables["CarEquipment"].Rows)
    //                {
    //                    CarEquipment am = new CarEquipment();
    //                    am.carEquipTID = Convert.ToInt32(dr["carEquipTID"]);
    //                    am.equipName = Convert.ToString(dr["equipName"]);
    //                    am.assetNo = Convert.ToString(dr["assetNo"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarEquipment findByPrimaryKey(int carEquipTID)
    //    {
    //        CarEquipment am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarEquipment a WHERE a.carEquipTID = " + carEquipTID;
    //            DataSet ds = my.select(sqlCmd, "CarEquipment");
    //            if (ds.Tables["CarEquipment"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarEquipment"].Rows[0];
    //                am = new CarEquipment();
    //                am.carEquipTID = Convert.ToInt32(dr["carEquipTID"]);
    //                am.equipName = Convert.ToString(dr["equipName"]);
    //                am.assetNo = Convert.ToString(dr["assetNo"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String equipName, String assetNo, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarEquipment(equipName,assetNo,memo,status) values ('" + equipName + "','" + assetNo + "','" + memo + "','" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carEquipTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarEquipment where carEquipTID = " + carEquipTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String equipName, String assetNo, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarEquipment set equipName ='" + equipName + "',assetNo ='" + assetNo + "',memo ='" + memo + "',status ='" + status + "' where carEquipTID = " + this.carEquipTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarEquipment set equipName ='" + this.equipName + "',assetNo ='" + this.assetNo + "',memo ='" + this.memo + "',status ='" + this.status + "' where carEquipTID = " + this.carEquipTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarEquipment");
    //            if (ds.Tables["CarEquipment"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarEquipment"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarEquipment.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
  
}


