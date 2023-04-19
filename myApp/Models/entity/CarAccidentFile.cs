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
    //public partial class CarAccidentFile
    //{

    //    public Collection<CarAccidentFile> findAll()
    //    {
    //        Collection<CarAccidentFile> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CarAccidentFile order by CarAccidentFileTID asc", "CarAccidentFile");
    //            if (ds.Tables["CarAccidentFile"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarAccidentFile>();
    //                foreach (DataRow dr in ds.Tables["CarAccidentFile"].Rows)
    //                {
    //                    CarAccidentFile am = new CarAccidentFile();
    //                    am.carAccidentID = Convert.ToInt32(dr["carAccidentID"]);
    //                    am.caf_RelName = Convert.ToString(dr["caf_RelName"]);
    //                    am.caf_SysName = Convert.ToString(dr["caf_SysName"]);
    //                    am.CarAccidentFileTID = Convert.ToInt32(dr["CarAccidentFileTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarAccidentFile> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarAccidentFile> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarAccidentFile");
    //            if (ds.Tables["CarAccidentFile"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarAccidentFile>();
    //                foreach (DataRow dr in ds.Tables["CarAccidentFile"].Rows)
    //                {
    //                    CarAccidentFile am = new CarAccidentFile();
    //                    am.carAccidentID = Convert.ToInt32(dr["carAccidentID"]);
    //                    am.caf_RelName = Convert.ToString(dr["caf_RelName"]);
    //                    am.caf_SysName = Convert.ToString(dr["caf_SysName"]);
    //                    am.CarAccidentFileTID = Convert.ToInt32(dr["CarAccidentFileTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarAccidentFile findByPrimaryKey(int CarAccidentFileTID)
    //    {
    //        CarAccidentFile am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CarAccidentFile a WHERE a.CarAccidentFileTID = " + CarAccidentFileTID;
    //            DataSet ds = my.select(sqlCmd, "CarAccidentFile");
    //            if (ds.Tables["CarAccidentFile"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarAccidentFile"].Rows[0];
    //                am = new CarAccidentFile();
    //                am.carAccidentID = Convert.ToInt32(dr["carAccidentID"]);
    //                am.caf_RelName = Convert.ToString(dr["caf_RelName"]);
    //                am.caf_SysName = Convert.ToString(dr["caf_SysName"]);
    //                am.CarAccidentFileTID = Convert.ToInt32(dr["CarAccidentFileTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


      


    //    public int Delete(int CarAccidentFileTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CarAccidentFile where CarAccidentFileTID = " + CarAccidentFileTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int carAccidentID, String caf_RelName, String caf_SysName)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("carAccidentID =" + carAccidentID + ",");
    //            sb_value.Append("caf_RelName=" + (String.IsNullOrEmpty(caf_RelName) ? "''" : "N'" + Regex.Replace(caf_RelName, "'", "''") + "'") + ",");
    //            sb_value.Append("caf_SysName=" + (String.IsNullOrEmpty(caf_SysName) ? "''" : "N'" + Regex.Replace(caf_SysName, "'", "''") + "'"));

    //            String sqlCmd = "update CarAccidentFile set  " + sb_value.ToString() + "  where CarAccidentFileTID = " + this.CarAccidentFileTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.create() : " + e.ToString());
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
    //            sb_value.Append("carAccidentID =" + this.carAccidentID + ",");
    //            sb_value.Append("caf_RelName=" + (String.IsNullOrEmpty(this.caf_RelName) ? "''" : "N'" + Regex.Replace(this.caf_RelName, "'", "''") + "'") + ",");
    //            sb_value.Append("caf_SysName=" + (String.IsNullOrEmpty(this.caf_SysName) ? "''" : "N'" + Regex.Replace(this.caf_SysName, "'", "''") + "'"));

    //            String sqlCmd = "update CarAccidentFile set  " + sb_value.ToString() + "  where CarAccidentFileTID = " + this.CarAccidentFileTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarAccidentFile");
    //            if (ds.Tables["CarAccidentFile"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarAccidentFile"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


