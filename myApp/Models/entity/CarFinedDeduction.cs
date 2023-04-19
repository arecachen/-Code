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
    //public partial class CarFinedDeduction
    //{
    //    public Collection<CarFinedDeduction> findAll()
    //    {
    //        Collection<CarFinedDeduction> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CarFinedDeduction order by CarFinedDeductionTID asc", "CarFinedDeduction");
    //            if (ds.Tables["CarFinedDeduction"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarFinedDeduction>();
    //                foreach (DataRow dr in ds.Tables["CarFinedDeduction"].Rows)
    //                {
    //                    CarFinedDeduction am = new CarFinedDeduction();
    //                    am.cfdTitle = Convert.ToString(dr["cfdTitle"]);
    //                    am.cfdOrder = Convert.ToString(dr["cfdOrder"]);
    //                    am.cfdStatus = Convert.ToString(dr["cfdStatus"]);
    //                    am.CarFinedDeductionTID = Convert.ToInt32(dr["CarFinedDeductionTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarFinedDeduction> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarFinedDeduction> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarFinedDeduction");
    //            if (ds.Tables["CarFinedDeduction"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarFinedDeduction>();
    //                foreach (DataRow dr in ds.Tables["CarFinedDeduction"].Rows)
    //                {
    //                    CarFinedDeduction am = new CarFinedDeduction();
    //                    am.cfdTitle = Convert.ToString(dr["cfdTitle"]);
    //                    am.cfdOrder = Convert.ToString(dr["cfdOrder"]);
    //                    am.cfdStatus = Convert.ToString(dr["cfdStatus"]);
    //                    am.CarFinedDeductionTID = Convert.ToInt32(dr["CarFinedDeductionTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarFinedDeduction findByPrimaryKey(int CarFinedDeductionTID)
    //    {
    //        CarFinedDeduction am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CarFinedDeduction a WHERE a.CarFinedDeductionTID = " + CarFinedDeductionTID;
    //            DataSet ds = my.select(sqlCmd, "CarFinedDeduction");
    //            if (ds.Tables["CarFinedDeduction"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarFinedDeduction"].Rows[0];
    //                am = new CarFinedDeduction();
    //                am.cfdTitle = Convert.ToString(dr["cfdTitle"]);
    //                am.cfdOrder = Convert.ToString(dr["cfdOrder"]);
    //                am.cfdStatus = Convert.ToString(dr["cfdStatus"]);
    //                am.CarFinedDeductionTID = Convert.ToInt32(dr["CarFinedDeductionTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String cfdTitle, String cfdOrder, String cfdStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(cfdTitle) ? "''" : "N'" + Regex.Replace(cfdTitle, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(cfdOrder) ? "''" : "N'" + Regex.Replace(cfdOrder, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(cfdStatus) ? "''" : "N'" + Regex.Replace(cfdStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into CarFinedDeduction(cfdTitle,cfdOrder,cfdStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int CarFinedDeductionTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CarFinedDeduction where CarFinedDeductionTID = " + CarFinedDeductionTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String cfdTitle, String cfdOrder, String cfdStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("cfdTitle=" + (String.IsNullOrEmpty(cfdTitle) ? "''" : "N'" + Regex.Replace(cfdTitle, "'", "''") + "'") + ",");
    //            sb_value.Append("cfdOrder=" + (String.IsNullOrEmpty(cfdOrder) ? "''" : "N'" + Regex.Replace(cfdOrder, "'", "''") + "'") + ",");
    //            sb_value.Append("cfdStatus=" + (String.IsNullOrEmpty(cfdStatus) ? "''" : "N'" + Regex.Replace(cfdStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CarFinedDeduction set  " + sb_value.ToString() + "  where CarFinedDeductionTID = " + this.CarFinedDeductionTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.create() : " + e.ToString());
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
    //            sb_value.Append("cfdTitle=" + (String.IsNullOrEmpty(this.cfdTitle) ? "''" : "N'" + Regex.Replace(this.cfdTitle, "'", "''") + "'") + ",");
    //            sb_value.Append("cfdOrder=" + (String.IsNullOrEmpty(this.cfdOrder) ? "''" : "N'" + Regex.Replace(this.cfdOrder, "'", "''") + "'") + ",");
    //            sb_value.Append("cfdStatus=" + (String.IsNullOrEmpty(this.cfdStatus) ? "''" : "N'" + Regex.Replace(this.cfdStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CarFinedDeduction set  " + sb_value.ToString() + "  where CarFinedDeductionTID = " + this.CarFinedDeductionTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarFinedDeduction");
    //            if (ds.Tables["CarFinedDeduction"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarFinedDeduction"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedDeduction.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


