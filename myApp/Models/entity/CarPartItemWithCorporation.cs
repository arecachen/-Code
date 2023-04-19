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
    //public partial class CarPartItemWithCorporation
    //{
        
    //    public Collection<CarPartItemWithCorporation> findAll()
    //    {
    //        Collection<CarPartItemWithCorporation> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarPartItemWithCorporation order by CarPartItemWithCorporationTID asc", "CarPartItemWithCorporation");
    //            if (ds.Tables["CarPartItemWithCorporation"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarPartItemWithCorporation>();
    //                foreach (DataRow dr in ds.Tables["CarPartItemWithCorporation"].Rows)
    //                {
    //                    CarPartItemWithCorporation am = new CarPartItemWithCorporation();
    //                    am.carPartItemID = Convert.ToInt32(dr["carPartItemID"]);
    //                    am.corporationID = Convert.ToInt32(dr["corporationID"]);
    //                    am.CarPartItemWithCorporationTID = Convert.ToInt32(dr["CarPartItemWithCorporationTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarPartItemWithCorporation> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarPartItemWithCorporation> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarPartItemWithCorporation");
    //            if (ds.Tables["CarPartItemWithCorporation"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarPartItemWithCorporation>();
    //                foreach (DataRow dr in ds.Tables["CarPartItemWithCorporation"].Rows)
    //                {
    //                    CarPartItemWithCorporation am = new CarPartItemWithCorporation();
    //                    am.carPartItemID = Convert.ToInt32(dr["carPartItemID"]);
    //                    am.corporationID = Convert.ToInt32(dr["corporationID"]);
    //                    am.CarPartItemWithCorporationTID = Convert.ToInt32(dr["CarPartItemWithCorporationTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarPartItemWithCorporation findByPrimaryKey(int CarPartItemWithCorporationTID)
    //    {
    //        CarPartItemWithCorporation am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarPartItemWithCorporation a WHERE a.CarPartItemWithCorporationTID = " + CarPartItemWithCorporationTID;
    //            DataSet ds = my.select(sqlCmd, "CarPartItemWithCorporation");
    //            if (ds.Tables["CarPartItemWithCorporation"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarPartItemWithCorporation"].Rows[0];
    //                am = new CarPartItemWithCorporation();
    //                am.carPartItemID = Convert.ToInt32(dr["carPartItemID"]);
    //                am.corporationID = Convert.ToInt32(dr["corporationID"]);
    //                am.CarPartItemWithCorporationTID = Convert.ToInt32(dr["CarPartItemWithCorporationTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int carPartItemID, int corporationID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarPartItemWithCorporation(carPartItemID,corporationID) values (" + carPartItemID + "," + corporationID + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int CarPartItemWithCorporationTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarPartItemWithCorporation where CarPartItemWithCorporationTID = " + CarPartItemWithCorporationTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int carPartItemID, int corporationID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarPartItemWithCorporation set carPartItemID =" + carPartItemID + ",corporationID =" + corporationID + " where CarPartItemWithCorporationTID = " + this.CarPartItemWithCorporationTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarPartItemWithCorporation set carPartItemID =" + this.carPartItemID + ",corporationID =" + this.corporationID + " where CarPartItemWithCorporationTID = " + this.CarPartItemWithCorporationTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarPartItemWithCorporation");
    //            if (ds.Tables["CarPartItemWithCorporation"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarPartItemWithCorporation"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporation.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


