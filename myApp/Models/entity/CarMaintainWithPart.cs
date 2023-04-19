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
    //public partial class CarMaintainWithPart
    //{
     
    //    public Collection<CarMaintainWithPart> findAll()
    //    {
    //        Collection<CarMaintainWithPart> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarMaintainWithPart order by carMaintainWithPartTID asc", "CarMaintainWithPart");
    //            if (ds.Tables["CarMaintainWithPart"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMaintainWithPart>();
    //                foreach (DataRow dr in ds.Tables["CarMaintainWithPart"].Rows)
    //                {
    //                    CarMaintainWithPart am = new CarMaintainWithPart();
    //                    am.carMaintainID = Convert.ToInt32(dr["carMaintainID"]);
    //                    am.carPartItemID = Convert.ToInt32(dr["carPartItemID"]);
    //                    am.partStatus = Convert.ToString(dr["partStatus"]);
    //                    am.partFaultyDesc = Convert.ToString(dr["partFaultyDesc"]);
    //                    am.partResolve = Convert.ToInt32(dr["partResolve"]);
    //                    am.partCost = Convert.ToInt32(dr["partCost"]);
    //                    am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                    am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                    am.carMaintainWithPartTID = Convert.ToInt32(dr["carMaintainWithPartTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarMaintainWithPart> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarMaintainWithPart> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarMaintainWithPart");
    //            if (ds.Tables["CarMaintainWithPart"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarMaintainWithPart>();
    //                foreach (DataRow dr in ds.Tables["CarMaintainWithPart"].Rows)
    //                {
    //                    CarMaintainWithPart am = new CarMaintainWithPart();
    //                    am.carMaintainID = Convert.ToInt32(dr["carMaintainID"]);
    //                    am.carPartItemID = Convert.ToInt32(dr["carPartItemID"]);
    //                    am.partStatus = Convert.ToString(dr["partStatus"]);
    //                    am.partFaultyDesc = Convert.ToString(dr["partFaultyDesc"]);
    //                    am.partResolve = Convert.ToInt32(dr["partResolve"]);
    //                    am.partCost = Convert.ToInt32(dr["partCost"]);
    //                    am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                    am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                    am.carMaintainWithPartTID = Convert.ToInt32(dr["carMaintainWithPartTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarMaintainWithPart findByPrimaryKey(int carMaintainWithPartTID)
    //    {
    //        CarMaintainWithPart am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarMaintainWithPart a WHERE a.carMaintainWithPartTID = " + carMaintainWithPartTID;
    //            DataSet ds = my.select(sqlCmd, "CarMaintainWithPart");
    //            if (ds.Tables["CarMaintainWithPart"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarMaintainWithPart"].Rows[0];
    //                am = new CarMaintainWithPart();
    //                am.carMaintainID = Convert.ToInt32(dr["carMaintainID"]);
    //                am.carPartItemID = Convert.ToInt32(dr["carPartItemID"]);
    //                am.partStatus = Convert.ToString(dr["partStatus"]);
    //                am.partFaultyDesc = Convert.ToString(dr["partFaultyDesc"]);
    //                am.partResolve = Convert.ToInt32(dr["partResolve"]);
    //                am.partCost = Convert.ToInt32(dr["partCost"]);
    //                am.nextCheckMile = dr["nextCheckMile"] == DBNull.Value ? -999 : Convert.ToDecimal(dr["nextCheckMile"]);
    //                am.nextCheckDate = dr["nextCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["nextCheckDate"]);
    //                am.carMaintainWithPartTID = Convert.ToInt32(dr["carMaintainWithPartTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int carMaintainID, int carPartItemID, String partStatus, String partFaultyDesc, int partResolve, double partCost, double nextCheckMile, long nextCheckDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarMaintainWithPart(carMaintainID,carPartItemID,partStatus,partFaultyDesc,partResolve,partCost,nextCheckMile,nextCheckDate) values (" + carMaintainID + "," + carPartItemID + ",N'" + partStatus + "',N'" + partFaultyDesc + "'," + partResolve + "," + partCost + "," + nextCheckMile + "," + nextCheckDate + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carMaintainWithPartTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarMaintainWithPart where carMaintainWithPartTID = " + carMaintainWithPartTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int carMaintainID, int carPartItemID, String partStatus, String partFaultyDesc, int partResolve, double partCost, double nextCheckMile, long nextCheckDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarMaintainWithPart set carMaintainID =" + carMaintainID + ",carPartItemID =" + carPartItemID + ",partStatus =N'" + partStatus + "',partFaultyDesc =N'" + partFaultyDesc + "',partResolve =" + partResolve + ",partCost =" + partCost + ",nextCheckMile =" + nextCheckMile + ",nextCheckDate =" + nextCheckDate + " where carMaintainWithPartTID = " + this.carMaintainWithPartTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarMaintainWithPart set carMaintainID =" + this.carMaintainID + ",carPartItemID =" + this.carPartItemID + ",partStatus =N'" + this.partStatus + "',partFaultyDesc =N'" + this.partFaultyDesc + "',partResolve =" + this.partResolve + ",partCost =" + this.partCost + ",nextCheckMile =" + this.nextCheckMile + ",nextCheckDate =" + this.nextCheckDate + " where carMaintainWithPartTID = " + this.carMaintainWithPartTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarMaintainWithPart");
    //            if (ds.Tables["CarMaintainWithPart"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarMaintainWithPart"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarMaintainWithPart.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


