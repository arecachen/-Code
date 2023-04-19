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
    //public partial class CarFinedCategory
    //{
    //    public Collection<CarFinedCategory> findAll()
    //    {
    //        Collection<CarFinedCategory> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CarFinedCategory order by CarFinedCategoryTID asc", "CarFinedCategory");
    //            if (ds.Tables["CarFinedCategory"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarFinedCategory>();
    //                foreach (DataRow dr in ds.Tables["CarFinedCategory"].Rows)
    //                {
    //                    CarFinedCategory am = new CarFinedCategory();
    //                    am.cfcTitle = Convert.ToString(dr["cfcTitle"]);
    //                    am.cfcOrder = Convert.ToString(dr["cfcOrder"]);
    //                    am.cfcStatus = Convert.ToString(dr["cfcStatus"]);
    //                    am.CarFinedCategoryTID = Convert.ToString(dr["CarFinedCategoryTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarFinedCategory> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarFinedCategory> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarFinedCategory");
    //            if (ds.Tables["CarFinedCategory"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarFinedCategory>();
    //                foreach (DataRow dr in ds.Tables["CarFinedCategory"].Rows)
    //                {
    //                    CarFinedCategory am = new CarFinedCategory();
    //                    am.cfcTitle = Convert.ToString(dr["cfcTitle"]);
    //                    am.cfcOrder = Convert.ToString(dr["cfcOrder"]);
    //                    am.cfcStatus = Convert.ToString(dr["cfcStatus"]);
    //                    am.CarFinedCategoryTID = Convert.ToString(dr["CarFinedCategoryTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarFinedCategory findByPrimaryKey(int CarFinedCategoryTID)
    //    {
    //        CarFinedCategory am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CarFinedCategory a WHERE a.CarFinedCategoryTID = " + CarFinedCategoryTID;
    //            DataSet ds = my.select(sqlCmd, "CarFinedCategory");
    //            if (ds.Tables["CarFinedCategory"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarFinedCategory"].Rows[0];
    //                am = new CarFinedCategory();
    //                am.cfcTitle = Convert.ToString(dr["cfcTitle"]);
    //                am.cfcOrder = Convert.ToString(dr["cfcOrder"]);
    //                am.cfcStatus = Convert.ToString(dr["cfcStatus"]);
    //                am.CarFinedCategoryTID = Convert.ToString(dr["CarFinedCategoryTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String cfcTitle, String cfcOrder, String cfcStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(cfcTitle) ? "''" : "N'" + Regex.Replace(cfcTitle, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(cfcOrder) ? "''" : "N'" + Regex.Replace(cfcOrder, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(cfcStatus) ? "''" : "N'" + Regex.Replace(cfcStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into CarFinedCategory(cfcTitle,cfcOrder,cfcStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int CarFinedCategoryTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CarFinedCategory where CarFinedCategoryTID = " + CarFinedCategoryTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String cfcTitle, String cfcOrder, String cfcStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("cfcTitle=" + (String.IsNullOrEmpty(cfcTitle) ? "''" : "N'" + Regex.Replace(cfcTitle, "'", "''") + "'") + ",");
    //            sb_value.Append("cfcOrder=" + (String.IsNullOrEmpty(cfcOrder) ? "''" : "N'" + Regex.Replace(cfcOrder, "'", "''") + "'") + ",");
    //            sb_value.Append("cfcStatus=" + (String.IsNullOrEmpty(cfcStatus) ? "''" : "N'" + Regex.Replace(cfcStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CarFinedCategory set  " + sb_value.ToString() + "  where CarFinedCategoryTID = " + this.CarFinedCategoryTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.create() : " + e.ToString());
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
    //            sb_value.Append("cfcTitle=" + (String.IsNullOrEmpty(this.cfcTitle) ? "''" : "N'" + Regex.Replace(this.cfcTitle, "'", "''") + "'") + ",");
    //            sb_value.Append("cfcOrder=" + (String.IsNullOrEmpty(this.cfcOrder) ? "''" : "N'" + Regex.Replace(this.cfcOrder, "'", "''") + "'") + ",");
    //            sb_value.Append("cfcStatus=" + (String.IsNullOrEmpty(this.cfcStatus) ? "''" : "N'" + Regex.Replace(this.cfcStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CarFinedCategory set  " + sb_value.ToString() + "  where CarFinedCategoryTID = " + this.CarFinedCategoryTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarFinedCategory");
    //            if (ds.Tables["CarFinedCategory"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarFinedCategory"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedCategory.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


